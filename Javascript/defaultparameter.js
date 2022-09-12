function register(name, gender = "UNKNOWN") {
    document.writeln(`<p>${name}</p>`);
    document.writeln(`<p>${gender}</p>`);
};

register("Eko");
register("Rifki", "Laki-Laki");