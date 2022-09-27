// simple case
function* createNames() {
    yield "Muhammad";
    yield "Rifki";
    yield "Ardiansah";
}

const names = createNames();
for (const name of names) {
    document.writeln(`<p>${name}</p>`);
}
// complex case
function* buatGanjil(value) {
    for (let i = 0; i <= value; i++) {
        if (i % 2 === 1) {
            yield i;
        }
    }
}

for (const number of buatGanjil(100)) {
    document.writeln(`<p>${number}</p>`);
}

const numbers = buatGanjil(100);
console.info(numbers.next().value);
console.info(numbers.next().value);
