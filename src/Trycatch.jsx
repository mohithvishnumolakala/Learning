import React, { useState } from "react";

const Trycatch = () => {
    const [userName, setuserName] = useState("");
    const [userData, setuserData] = useState();

    const getuserName = (e) => {
        setuserName(e.target.value);
    };

    const getuserDetails = (e) => {
        e.preventDefault();

        try {
            if (!userName.trim()) {
                throw new Error("Username cannot be empty!");
            }

            setuserData(userName);
            alert("Submitted successfully!");
        } catch (error) {
            alert(`Error: ${error.message}`);
        }
    };

    return (
        <div>
            <section className="formSection">
                <div className="inputDiv">
                    <form onSubmit={getuserDetails}>
                        <input
                            type="text"
                            placeholder="Write here"
                            onChange={getuserName}
                        />
                        <br />
                        <button className="submitbtn" type="submit">Submit</button>
                        <h2>{userData}</h2>
                    </form>
                </div>
            </section>
        </div>
    );
};

export default Trycatch;
