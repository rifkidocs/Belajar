// Evenet Listener Method
// element.addEventListener("click", function)

const buttonTwo = document.querySelector('.btn-2');

function alertBtn() {
    alert('I Love JavaScript');
};

buttonTwo.addEventListener("click",alertBtn);

//Mouse Over
const newBackgroundColor = document.querySelector('.box3');

function MouseOverBackGround() {
    newBackgroundColor.style.backgroundColor = 'blue';
};

newBackgroundColor.addEventListener("mouseover",MouseOverBackGround);
