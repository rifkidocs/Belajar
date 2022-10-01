// Parent Node Traversal

let ul = document.querySelector('ul');

console.log(ul.parentNode.parentNode);
console.log(ul.parentElement.parentElement);

const html = document.documentElement;
console.log(html.parentNode);
console.log(html.parentElement);

console.log(ul.childNodes);
console.log(ul.firstChild);
console.log(ul.lastChild);

ul.childNodes[1].style.backgroundColor = 'blue';
ul.childNodes[5].style.backgroundColor = 'blue';

const div = document.querySelector('div');
console.log(div.childNodes);

div.childNodes[1].style.backgroundColor = 'red';