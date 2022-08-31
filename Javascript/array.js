let arraykosong = [];
let arraynama = ["Muhammad","Rifki","Ardiansah", 1, 2, 3, 4, 5, 6, 7, 8];

const names = [];
names.push("Rifki")
names.push("Ardiansah");
names.push("Kepo");

console.table(names);
console.info(names.length);
console.log(names[2]);

names[0] = "Anto";
console.log(names[0]);
delete names[0];
console.log(names[0]);