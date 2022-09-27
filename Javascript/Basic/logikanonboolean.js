console.info("Hello" || "");
console.info("" || []);
console.info("0" || "NOL");
console.info(0 || "NOL");
console.info(null || "NULL");
console.info(undefined || "UNDEFINED");
console.info(0 || false);

const person = {
    firstname: "",
    lastname: "Doe"
}

let sayhi = person.firstname || person.lastname;
document.writeln(`<p>${sayhi}</p>`);

let sayhi2 = person.firstname && person.lastname;
console.info(sayhi2);