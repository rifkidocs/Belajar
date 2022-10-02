// Event Propagation

window.addEventListener("click", function() {
    console.log("Window");
},false); //false or true

document.addEventListener("click", function() {
    console.log("Document");
},false);

document.querySelector(".div2").addEventListener("click", function(e) {
    console.log("Div 2");    
    e.stopPropagation(); //stop propagation
}, {once: true});

document.querySelector(".div1").addEventListener("click", function() {
    console.log("Div 1");
},false);

document.querySelector("button").addEventListener("click", function(e){
    console.log(e.target.innerText = "Clicked !");    
},false);

