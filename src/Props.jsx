// props means Properties (communication between 2 components)
// parent to child between communication one way communication

import React from 'react';
import First from './PropsContainer/First';
import Second from './PropsContainer/Second';
import Fourth from './PropsContainer/Fourth';
import Third from './PropsContainer/Third';

function App() {
  return (
   <div className='container'>

    <First name="Alice"/>
    <Second name={user.name2}/>
    <Third name="Tom"/>
    <Fourth name={user.name4}/>

   </div>
  );
}
export default App

/* aslo use this dictionary*/

const user={
    name1:"Jack" ,
    name2:"Zoom" ,
    name3:"Ali",
    name4:"Babi"

}

