//tidak bisa mengakses this/super dll

const person = {
    name : "Rifki",
    sayHello : (name) => {
        console.info(`Hello ${name}`);
    }
}

person.sayHello("Yana");