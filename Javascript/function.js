function sayHelloWorld() {
    document.writeln(`<p>Hello World!</p>`);
};

sayHelloWorld();
sayHelloWorld();
sayHelloWorld();

//function Parameter
function sayHello(firstname, lastname) {
    document.writeln(`<p>Hello ${firstname} ${lastname} !</p>`);
}

sayHello("Rifki", "Ardiansah");
sayHello(9, 2);
sayHello("Rifki", 2);

//function ReturnValue

function sayReturn(firstname, lastname) {
    const say = `Hello ${firstname} ${lastname}`;
    return say;
}

let result = sayReturn("Rifki", "Return");
document.writeln(`<p>${result}</p>`);

function getFinalScore(value) {
    if (value > 90) {
        return "A";
    } else if (value > 80) {
        return "B";
    } else if (value > 70) {
        return "C";
    } else if (value > 60) {
        return "D";
    } else {
        return "E";
    }
}
result = getFinalScore(92);
document.writeln(`<p>${result}</p>`);

//function can break the loop

function isContains(array, searchValue) {
    for (const element of array) {
        if (element === searchValue) {
            return true;
        }
    }
    return false;
}

const array = [12, 12, 42, 124, 4, 14, 235, 23, 23, , 1235, 4, 5123, 4, 34]
const search = 5123;
const found = isContains(array, search);
document.writeln(`<p>${found}</p>`);