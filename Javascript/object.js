const orang = {};

// Menambah atau mengurangi

orang["nama"] = "Muhammad Rifki Ardiansah";
orang["alamat"] = "Indonesia";
orang["umur"] = 30;

console.table(orang);

delete orang["nama"];

console.table(orang);

// meembuat object dengan properties

const pemain = {
    "nama lengkap": "Messi",
    alamat: "Argentina",
    umur: "35"
};

console.table(pemain);

delete pemain["nama lengkap"];

console.table(pemain);

console.info()