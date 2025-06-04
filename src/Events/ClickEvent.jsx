import React from "react";
import { useState } from "react";

const ClickEvent = () => {
    const [Num, setNum]=useState(0)

    const increment=()=>{
        setNum(Num+1)
    }

    const decrement=()=>{
        if(Num>0){
        setNum(Num-1)
        }
    }

    const reset=()=>{
        setNum(0)
    }


    return (
        <div>
            <h2>I am ClickEvent</h2>
            <h1>{Num}</h1>
            <button onClick={increment}>Increment</button>
            <button onClick={decrement}>Decrement</button>
            <button onClick={reset}>reset</button>
        </div>
    );
};

export default ClickEvent;
