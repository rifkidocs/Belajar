function outer (){
    function inner (){
        document.writeln(`<p>Ini Adalah Inner dari Nested Function</p>`);
    }
    inner();
}

outer();