// const person = {
//     name: "Rifki",
//     sayHello: function (name){
//         alert(`Hello ${name}`);
//     }
// };

// person.sayHello("Ardiansah");

// bisa juga seperti ini 

const person = {
    name : "Rifki"
};

person.sayHello = function (name) {
    alert(`Hello ${name}`);
}

person.sayHello("Ardiansah");