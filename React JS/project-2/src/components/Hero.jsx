import React from 'react'

function addTwoNumbers(a , b) {
    return a + b
}

console.log(addTwoNumbers(10,5));



function Hero() {
    return (

        <section className='hero'>
            <img src='assets/photo-grid.png' alt="" className='hero--photo' />
            <h1 className='hero--header'>Online Experience</h1>
            <p className='hero--text'>Join unique interactive activities led by one-of-a-kind hosts—all without leaving home.</p>
        </section>


    )
}

export default Hero