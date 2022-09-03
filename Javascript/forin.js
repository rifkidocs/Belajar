const person = {
    firstname: "John",
    middlename: "Kannedy",
    lastname: "Ardiansah"
};

for (const property in person) {
    document.writeln(`<p>${property}</p>`);
};

for (const property in person) {
    document.writeln(`<p>${property} : ${person[property]}</p>`);
}

array = ["Muhammad", "Rifki", "Ardiansah",];

for (const index in array) {
    document.writeln(`<p>${index}</p>`);
}

for (const index in array) {
    document.writeln(`<p>${index} : ${array[index]}</p>`);
}