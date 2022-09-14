console.info(this);

const person = {
    name : "Rifki",
    sayHello : function(name) {
        console.info(this);
        document.writeln(`<p>Hello ${name} My Name Is ${this.name}</p>`);
    }
};

person.sayHello("Yana");