import React, { useState } from "react";

const Form = () => {

    const[userName,setuserName]=useState("")

    const[userData,setuserDetails]=useState()

    const getUserName=(m)=>{
        return(
            setuserName(m.target.value)
        )
    }


    const userDetails=(e)=>{
        e.preventDefault()
        return(
            setuserDetails(userName)
        )
    }

    return (
        <section className="formSection">
            <h2>{userData}</h2>
            <div className="inputDiv" >
                <form onSubmit={userDetails}>
                    <input type="text" placeholder="enter your name"onChange={getUserName}/> 
                    <br/>
                    <button className="submitbtn" type="submit">Submit</button>
                </form>
            </div>
        </section>
    );
};

export default Form
