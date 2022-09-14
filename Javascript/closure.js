function createAdder(value){
    const owner = "Rifki";
    function add(param){
        console.info(owner);
        return value + param;
    }
    return add; // ini penting return add bukan add()
}

const addTwo = createAdder(2);
console.info(addTwo(10));
console.info(addTwo(20));

