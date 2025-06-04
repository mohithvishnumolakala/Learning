import React, { useState } from "react";


const DoubleClickExample = () => {
    const [message, setMessage] = useState("Double-click me!");

    const handleDoubleClick = () => {
        setMessage("You double-clicked!");
    };

    return (
        <div onDoubleClick={handleDoubleClick}>
            <h2>{message}</h2>
        </div>
    );
};

export default DoubleClickExample;
