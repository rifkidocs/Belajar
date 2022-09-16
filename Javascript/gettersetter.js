const person = {
    firstname: "Rifki",
    lastname: "Ardiansah",
    //getter
    get fullname() {
        return `${this.firstname} ${this.lastname}`;
    },
    //setter
    set fullname(value) {
        const array = value.split(" ");
        this.firstname = array[0];
        this.lastname = array[1];
    }
};
document.writeln(`<p>${person.fullname}</p>`);
person.fullname = "Sri Mulyana";
document.writeln(`<p>${person.fullname}</p>`);
