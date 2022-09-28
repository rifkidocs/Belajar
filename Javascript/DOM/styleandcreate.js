// const title = document.querySelector('#main-heading');
// title.style.color = 'red';
// console.log(title);

const listitem = document.querySelectorAll('.list-items')
console.log(listitem);

for (let index = 0; index < listitem.length; index++) {
    listitem[index].style.fontSize = '2rem';
}

//creating elements
const ul = document.querySelector('ul');
const li = document.createElement('li');

// Adding elements
ul.append(li)

//Modify the text

const firstListItem = document.querySelector('.list-items');

console.log(firstListItem.innerText);
console.log(firstListItem.textContent);
console.log(firstListItem.innerHTML);

li.innerText = 'X _ Men'

//Modifying Attributes & Classes

li.setAttribute('class', 'list-items');
li.removeAttribute('class');

li.classList.add('list-items')
li.classList.remove('list-items')