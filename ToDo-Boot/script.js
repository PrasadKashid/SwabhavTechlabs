let todoBtn = document.getElementById("todobtn");
let todoInput = document.getElementById("todoinput");
let ul = document.getElementById("todo-list");
let completedUl = document.getElementById("completed-list");

let activeTodosArray = [];
let completedTodosArray = [];

todoBtn.addEventListener('click', () => {
    const taskText = todoInput.value;


    if (!activeTodosArray.includes(taskText)) {
        activeTodosArray.push(taskText);

        const li = document.createElement("li");
        li.innerText = taskText;

        const trueBtn = document.createElement("button");
        trueBtn.innerText = "Done";
        trueBtn.classList.add("btn", "btn-success");

        const deleteBtn = document.createElement("button");
        deleteBtn.innerText = "Delete";
        deleteBtn.classList.add("btn", "btn-danger");

        li.appendChild(trueBtn);
        li.appendChild(deleteBtn);
        ul.appendChild(li);
        todoInput.value = "";

        trueBtn.addEventListener('click', () => {
            li.style.textDecoration = "line-through";
            completedUl.appendChild(li);
            li.removeChild(trueBtn); // Remove the Done button from the list item
            // Update the arrays correctly
            activeTodosArray = activeTodosArray.filter(task => task !== taskText);
            completedTodosArray.push(taskText);
            console.log("Active");
            console.log(activeTodosArray);
            console.log("COM");
            console.log(completedTodosArray);
        });

        deleteBtn.addEventListener('click', () => {
            if (ul.contains(li)) {
                ul.removeChild(li); y
                activeTodosArray = activeTodosArray.filter(task => task !== taskText);
            } else if (completedUl.contains(li)) {
                completedUl.removeChild(li);
                completedTodosArray = completedTodosArray.filter(task => task !== taskText);
            }
            console.log("Active");
            console.log(activeTodosArray);
            console.log("COM");
            console.log(completedTodosArray);
        });

    } else {
        alert("Task Already Exists");
        todoInput.value = "";
    }
    console.log("Active");
    console.log(activeTodosArray);
    console.log("COM");
    console.log(completedTodosArray);
});
