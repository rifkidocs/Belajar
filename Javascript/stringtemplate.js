const name = "Muhammad Rifki Ardiansah";
const firstname = "Muhammad";
const middlename = "Rifki";
const lastname = "Ardiansah";
const template = `Name : ${name}`;

console.log(template);
console.log(`Name : ${firstname} ${middlename} ${lastname}`);

const value = 90;

// Substitusi
const kelulusan = `Name : ${name}, Lulus : ${value > 75}`;
console.log(kelulusan);

// Multiline stringtemplate
let MultilineString = `Nama Saya Rifki,
Sering Maen Game,
Kalo lagi males, Baca Buku
`;

document.writeln("<pre>")
document.writeln(MultilineString);
document.writeln("</pre>")