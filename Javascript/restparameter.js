function sum(name, ...data){
    let total = 0;
    for(const item of data){
        total += item;
    }
    document.writeln(`<p>Total ${name} is ${total}</p>`);
}
const values = [10,10,10,10,10];

sum("Buah", 2,4,5,6,7,1,2,4,5,6,);
sum("Siswa", 6,7,8,4,5,6,8,3,6,7);
sum("Baju", ...values)

