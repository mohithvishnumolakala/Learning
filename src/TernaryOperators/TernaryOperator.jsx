import react from "react";
import { useState } from "react";
import One from "./Onecom";
import Two from "./TwoCom"




const App=()=> {

    const [sampleCondition,setSampleCondition] =useState(false)

    


    return(
        <div>
            <h1>Welcome to react
                <br/>
                {sampleCondition ? <One /> : <Two/>}

            </h1>
        </div>
    )
}

export default App;

//use this also {sampleCondition ? "This is True Statement" : "This is False Statement"}