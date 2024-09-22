const form = document.getElementById("form");
const dateInput = document.getElementById("date");
const activityContainer = document.getElementById("activity-container");
const addActivityButton = document.getElementById("add-activity");
const previewButton = document.getElementById("preview");
const previewContainer = document.getElementById("preview-container");
const showTimesheet = document.getElementById("showTimesheet");

let ActivityIndex = 0;

addActivityButton.addEventListener("click", function () {
    const newActivityForm = document.createElement("div");
    newActivityForm.classList.add("activity-form");
    newActivityForm.innerHTML = `
    <hr>
        <h3>Activity ${ActivityIndex + 1}</h3>
        <label for="project-name-${ActivityIndex}">Enter Project Name:</label>
        <select id="project-name-${ActivityIndex}">
            <option value="Lending">Lending</option>
            <option value="Banking">Banking</option>
        </select>

        <label for="sub-project-${ActivityIndex}">Enter Sub-project Name:</label>
        <select id="sub-project-${ActivityIndex}">
            <option value="lending-sub">lending sub</option>
            <option value="banking-sub">banking sub</option>
        </select>

        <label for="batch-${ActivityIndex}">Enter Batch:</label>
        <select id="batch-${ActivityIndex}">
            <option value="Apro Captive">Apro Captive</option>
            <option value="Apro Payments">Apro Payments</option>
        </select>

        <div>
          <label for="hours-needed-${ActivityIndex}">Hours Needed:</label>
          <input type="number" id="hours-needed-${ActivityIndex}" />
        </div>

        <div>
          <label for="activity-${ActivityIndex}">Activity:</label>
          <textarea id="activity-${ActivityIndex}"></textarea>
        </div>
    `;
    activityContainer.appendChild(newActivityForm);
    ActivityIndex++;
});

form.addEventListener("submit", function (event) {
    event.preventDefault();

    const date = dateInput.value;
    const onLeave = document.getElementById("on-leave").value === "true";

    const activityForms = document.querySelectorAll(".activity-form");
    const activities = Array.from(activityForms).map((form, index) => ({
        project: form.querySelector(`#project-name-${index}`).value,
        subProject: form.querySelector(`#sub-project-${index}`).value,
        batch: form.querySelector(`#batch-${index}`).value,
        hoursNeeded: parseInt(
            form.querySelector(`#hours-needed-${index}`).value,
            10
        ),
        activityDone: form.querySelector(`#activity-${index}`).value,
    }));

    const data = {
        dateDataId: 0,
        todaysDate: date,
        onLeave: onLeave,
        timesheetList: activities,
    };

    fetch("http://localhost:5234/api/TimeSheet", {
        method: "POST",
        headers: {
            "Content-Type": "application/json",
        },
        body: JSON.stringify(data),
    })
        .then((response) => {
            if (!response.ok) {
                return response.json().then((err) => Promise.reject(err));
            }
            return response.json();
        })
        .then((data) => {
            console.log("Successfully posted:", data);
            alert("Timesheet submitted successfully!");
            form.reset();
            activityContainer.innerHTML = "";
            ActivityIndex = 0;
            previewContainer.innerHTML = ""; // Clear preview on submit
        })
        .catch((error) => {
            console.error("Error:", error);
        });
});

previewButton.addEventListener("click", function () {
    const date = dateInput.value;
    const onLeave =
        document.getElementById("on-leave").value === "true" ? "Yes" : "No";

    let previewHTML = `<h3>Preview Timesheet</h3><p><strong>Date:</strong> ${date}</p><p><strong>On Leave:</strong> ${onLeave}</p><hr />`;

    const activityForms = document.querySelectorAll(".activity-form");
    activityForms.forEach((form, index) => {
        const project = form.querySelector(`#project-name-${index}`).value;
        const subProject = form.querySelector(`#sub-project-${index}`).value;
        const batch = form.querySelector(`#batch-${index}`).value;
        const hoursNeeded = form.querySelector(`#hours-needed-${index}`).value;
        const activityDone = form.querySelector(`#activity-${index}`).value;

        previewHTML += `<h4>Activity ${index + 1}</h4>`;
        previewHTML += `<p><strong>Project:</strong> ${project}</p>`;
        previewHTML += `<p><strong>Sub-project:</strong> ${subProject}</p>`;
        previewHTML += `<p><strong>Batch:</strong> ${batch}</p>`;
        previewHTML += `<p><strong>Hours Needed:</strong> ${hoursNeeded}</p>`;
        previewHTML += `<p><strong>Activity:</strong> ${activityDone}</p><hr />`;
    });

    const previewWindow = window.open(
        "",
        "Preview Timesheet",
        "width=600,height=400"
    );
    previewWindow.document.write(
        `<html><head><title>Timesheet Preview</title></head><body>${previewHTML}</body></html>`
    );
    previewWindow.document.close();
});

const showTimesheetButton = document.getElementById("showData");

showTimesheetButton.addEventListener("click", function () {
    fetch("http://localhost:5234/api/TimeSheet")
        .then((response) => {
            if (!response.ok) {
                throw new Error("Network response was not ok");
            }
            return response.json();
        })
        .then((data) => {
            displayTimesheet(data);
        })
        .catch((error) => {
            console.error("Error fetching timesheet data:", error);
        });
});

function displayTimesheet(data) {
    const tableContainer = document.createElement("div");
    tableContainer.innerHTML = `
      <div class="container">
        <h3>Previous Timesheet Entries</h3>
        <table class="table table-bordered">
          <thead>
            <tr>
            <th>Sr.No</th>
            <th>Date</th>
              <th>On Leave</th>
              <th>Project</th>
              <th>Sub-project</th>
              <th>Batch</th>
              <th>Hours Needed</th>
              <th>Activity</th>
              <th>Action</th>
            </tr>
          </thead>
          <tbody>
             ${data.map((entry, entryIndex) =>
        entry.timesheetList.map((activity, activityIndex) => `
                <tr>
                  <td>${entryIndex + 1}.${activityIndex + 1}</td>
                  <td>${entry.todaysDate}</td>
                  <td>${entry.onLeave ? "Yes" : "No"}</td>
                  <td>${activity.project}</td>
                  <td>${activity.subProject}</td>
                  <td>${activity.batch}</td>
                  <td>${activity.hoursNeeded}</td>
                  <td>${activity.activityDone}</td>
                  <td>
                    <button class="btn btn-danger" onclick="deleteEntry(${entry.dateDataId})">Delete</button>
                  </td>
                </tr>
              `).join('')
    ).join('')}
          </tbody>
        </table>
      </div>
    `;

    const existingTable = document.querySelector(".table");
    if (existingTable) {
        existingTable.remove(); 
    }

    document.body.appendChild(tableContainer); 
}

function deleteEntry(id) {
    fetch(`http://localhost:5234/api/TimeSheet/${id}`, {
        method: "DELETE",
    })
        .then((response) => {
            if (!response.ok) {
                throw new Error("Network response was not ok");
            }
            alert("Entry deleted successfully");
            showTimesheetButton.click();
        })
        .catch((error) => {
            console.error("Error deleting entry:", error);
        });
}
