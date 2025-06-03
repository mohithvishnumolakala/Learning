import React from 'react';
import StateMgm from './PropsContainer/StateMgm';

const mycar={
    model: "maruthi",
    year:2002,
    dealer:"nixon",
    color:"red"
}
function App(){
    return(
        <div className='container'>
            <second name={mycar}/>
            <StateMgm/>

        </div>
    )
}