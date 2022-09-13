//default looping
function factorial(value) {
    let result = 1;
    for (let i = 1; i <= value; i++) {
        result *= i;
    }
    return result;
}

document.writeln(`<p>${factorial(5)}</p>`);
document.writeln(`<p>${factorial(7)}</p>`);

//recursive function
function factorialRecursive(value) {
    if (value === 1) {
        return value;
    } else {
        return value * factorialRecursive(value - 1);
    }
} 

document.writeln(`<p>${factorialRecursive(5)}</p>`);
document.writeln(`<p>${factorialRecursive(3)}</p>`);