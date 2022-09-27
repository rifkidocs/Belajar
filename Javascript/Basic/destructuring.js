//Destructuring Array
{
    const names = ["Muhammad", "Rifki", "Ardiansah", "Sri", "Mulyana"];
    const [firstname, middlename, lastname, ...others] = names;

    console.info(firstname);
    console.info(middlename);
    console.info(lastname);
    console.info(others);
}

//Destructuring Object
const person = {
    firstname: "Rifki",
    lastname: "Ardiansah",
    address: {
        country: "Indonesia",
        street: "Jalan Belum Ada",
        city: "Lamongan",
    },
    hobby: "Main Game",
    nickname: "ayevenx",
}
{
    let { firstname, lastname, address, ...others } = person;
    console.info(firstname);
    console.info(lastname);
    console.info(address);
    console.info(others);

    //Destructuring Nested Object
    let { address: { country, street, city } } = person;
    console.info(country);
    console.info(street);
    console.info(city);
    console.info(address);
}

//Destructuring Function Parameter
{
    const person = {
        firstname: "Muhammad",
        middlename: "Rifki",
        lastname: "Ardiansah",
    }

    function displayPerson({ firstname, middlename, lastname }) {
        console.info(firstname);
        console.info(middlename);
        console.info(lastname);
    }
    displayPerson(person);
}

//Destructuring Function Parameter 2
{
    //cara biasa
    // function sum(array){
    //     return array[0] + array[1];
    // }

    function sum([first, second]) {
        return first + second;
    }

    console.info(sum([10, 20]));
}

//Default Value Array Dan Object
{
    const names = ["Muhammad", "Rifki"];
    const [firstname, middlename = "NamaTengah", lastname = "NamaBelakang"] = names;

    console.info(firstname);
    console.info(middlename);
    console.info(lastname);
}
{
    const person = {
        firstname: "Muhammad",
        middlename: "Rifki"
    }

    let {firstname : namaDepan, //custom variable
        middlename,
        lastname = "NamaBelakang"} = person;
    console.info(namaDepan);
    console.info(middlename);
    console.info(lastname);
}
