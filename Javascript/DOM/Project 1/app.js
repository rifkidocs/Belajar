//Variables

let btn = document.querySelector('#new-Quote');
let quote = document.querySelector('.Quote');
let person = document.querySelector('.person');

const quotes = [
    {
        quote:"The way to get started is to quit talking and begin doing.",
        person:"Walt Disney"
    },
    {
        quote:"Your time is limited, so don't waste it living someone else's life. Don't be trapped by dogma – which is living with the results of other people's thinking.",
        person:"Steve Jobs"
    },
];

btn.addEventListener('click', function(){

    let random = Math.floor(Math.random() * quotes.length);

    quote.innerText = quotes[random].quote;
    person.innerText = quotes[random].person;
})