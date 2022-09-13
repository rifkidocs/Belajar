const sayHello =  (name) => {
    const say = `Hello ${name}`;
    document.writeln(`<p>${say}</p>`);
}

sayHello ("Rifki")

//arrow function without block

const arrowSay = name => console.log(`Hello ${name}`);

arrowSay ("Rifki");

//arrow function with return value

const sum = (value1, value2) => value1 + value2;

document.writeln(`<p>${sum(10,10)}</p>`);

