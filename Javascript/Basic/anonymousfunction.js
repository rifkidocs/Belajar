let say = function (name){
    document.writeln(`<p>Hello ${name}</p>`);
};

say("Rifki");

function giveMeName (callback){
    callback("Ardiansah");
}


giveMeName(say);