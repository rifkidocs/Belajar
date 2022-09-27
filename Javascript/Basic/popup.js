// alert("Hello world!");

const name = prompt("Siapa Nama Anda ? : ") //input dari user
const masuk = confirm("Anda Yakin Mau Masuk Dek?");

if (masuk) {
    alert(`Halo ${name}`);
} else {
    alert(`Bye Bye ${name}`);
}