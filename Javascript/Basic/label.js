loopi:
for (let i = 1; i <= 10; i++) {
    loopj:
    for (let j = 1; j <= 20; j++) {
        if(j>=5){
            continue loopi;
        }
        console.info(`${i} ${j}`);
    }
    
}