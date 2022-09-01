let array = ["Muhammad", "Rifki", 'Ardiansah'];

if (array[2] === undefined) {
    document.writeln("UNDEFINED");
} else {
    document.writeln("DEFINED");
};
document.writeln("<p></p>");
delete array[1];
if (array[1] === undefined) {
    document.writeln("UNDEFINED");
} else {
    document.writeln("DEFINED");
};