const person = {
    firstname: "Muhammad",
    middlename: "Rifki",
    lastname: "Ardiansah"
};

document.writeln(`<p>${person.firstname}</p>`);
document.writeln(`<p>${person.middlename}</p>`);
document.writeln(`<p>${person.lastname}</p>`);

document.writeln(`<p>.</p>`);
with(person){
    document.writeln(`<p>${firstname}</p>`);
    document.writeln(`<p>${middlename}</p>`);
    document.writeln(`<p>${lastname}</p>`);
}