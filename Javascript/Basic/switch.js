const nilai = prompt("Masukkan Nilai Anda :");

switch (nilai) {
    case "a":
    case "A":
        document.writeln("Wow Anda Jago Amat");
        break;
    case "b":
    case "c":
    case "B":
    case "C":
        document.writeln("Selamat Anda Lulus");
        break;
    case "D":
    case "d":
        document.writeln("Anda Tidak Lulus");
    default:
        document.writeln("Sepertinya Anda Salah Jurusan");
}