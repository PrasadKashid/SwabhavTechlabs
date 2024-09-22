let btnClick = document.querySelectorAll(".circular-btn")
let resetBtn = document.querySelector(".resetAll")

//random number between 1 to 40
function randomNumberGen() {
    return (Math.floor(Math.random() * 40) + 1);
}

let generatedNumber = randomNumberGen();
console.log("Generated Number: " + generatedNumber);

let count = 0
btnClick.forEach(button => {
    button.addEventListener('click', (e) => {
        let value = e.target;

        if (generatedNumber == value.textContent) {
            console.log("You clicked the same number");
            value.classList.add("green-btn");
            disableButtons();
            setTimeout(() => winnerDisplay(count), 100)
            // count += 1;

        } else if (generatedNumber <= value.textContent) {
            console.log("Generated number is smaller");
            value.classList.add("red-btn");
            // count += 1;

        } else if (generatedNumber >= value.textContent) {
            console.log("Generated number is bigger");
            value.classList.add("yellow-btn");
        }
        count += 1;

        updateCountDisplay(count)
        if (count >= 6) {
            disableButtons();
            changeButtonColors();
        }
    });
});

resetBtn.addEventListener('click', () => {
    enableButtons();
    count = 0;
    updateCountDisplay(count);
    generatedNumber = randomNumberGen();
    console.log("New num : " + generatedNumber);
})

function disableButtons() {
    btnClick.forEach(btn => {
        btn.classList.add("disabled-btn");
        btn.disabled = true;
    });
}

function enableButtons() {
    btnClick.forEach(btn => {
        btn.classList.remove("disabled-btn")
        btn.classList.remove("green-btn")
        btn.classList.remove("red-btn")
        btn.classList.remove("yellow-btn")
        btn.disabled = false;
        randomNumberGen()
    })
}

function updateCountDisplay(count) {
    let h1 = document.querySelector(".count");
    if (h1) {
        h1.innerHTML = `Total Attempts: ${count} `;
    }
    console.log(count);
}

function winnerDisplay(count) {
    alert(`You won after ${count} Attempts 🎉🎉`)
}

function changeButtonColors() {
    const targetButton = Array.from(btnClick).find(btn => btn.textContent == generatedNumber);
    if (targetButton) {
        targetButton.classList.add("green-btn");
    }
}