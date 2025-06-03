//componet within the component is known as nested components

import React from 'react';
import Sena from './Sample';


function Bob(){
    return(
        <div>Good</div>
    )
}

/* 
we can also crate like this (arrow component)
*/

const Jack=()=>{
    return(
        <div>Best</div>
    )
}


function Alice(){
    return(
        <div><h1>
            Sweet 
            <Bob/> 
            <Jack/>
            <Sena/>
        </h1></div>
      
    )
}
export default Alice;