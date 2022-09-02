const person = {
    address: {
        country: "United States"
    },
    age : 28
};

let country = person?.age;

document.writeln(`<p>${country}</p>`);