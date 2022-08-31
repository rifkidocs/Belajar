const nilaiUjian = 80;
const nilaiabsensi = 75;

const lulusujian = nilaiUjian > 75;
const lulusabsensi = nilaiabsensi > 75;

const lulus = lulusujian || lulusabsensi;
const lulus2 = lulusujian && lulusabsensi;
document.writeln(lulus);
document.writeln(lulus2);
