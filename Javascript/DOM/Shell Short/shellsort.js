let data = new Array();
let hasilsort = new Array();
const txtAngka = document.getElementById("txtAngka");
let array = document.querySelector(".array");
let add = document.querySelector(".add");
let reset = document.querySelector(".reset");
let sort = document.querySelector(".sort");
let output = document.querySelector(".output");


function addElement() {
    data.push(txtAngka.value);
    txtAngka.value = "";
    displayData()
    console.log(data);
};

function displayData() {
    let str = ""
    for (let index = 0; index < data.length; index++) {
        str += data[index] + " "
    }
    array.innerHTML = str;
};


add.addEventListener("click", addElement)

function deleteArray() {
    while (data.length > 0) {
        data.pop();
    }
    while (hasilsort.length > 0) {
        hasilsort.pop();
    }
    array.innerHTML = "0";
    output.innerHTML = "0";
}

reset.addEventListener("click", deleteArray)

function sortingFunction(arr) {
    let n = arr.length;

    for (let gap = Math.floor(n / 2); gap > 0; gap = Math.floor(gap / 2)) {

        for (let i = gap; i < n; i += 1) {
            let temp = arr[i];

            let j;
            for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                arr[j] = arr[j - gap];

            arr[j] = temp;
        }
    }
    hasilsort = arr
    return arr;
}

function displayOutput() {
    let str = ""
    for (let index = 0; index < hasilsort.length; index++) {
        str += hasilsort[index] + " "
    }
    output.innerHTML = str;
};


function SortAlgo() {
    for (let i = 0; i < data.length; i++){
        hasilsort.push(parseInt(data[i]));
    }
    // Print the array of numbers
    sortingFunction(hasilsort);
    displayOutput();
};

sort.addEventListener("click",SortAlgo);