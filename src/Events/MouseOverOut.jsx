import React, { useState } from "react";

const MouseOverOutExample = () => {
    const [text, setText] = useState("Hover over me!");

    return (
        <div
            onMouseOver={() => setText("Mouse is over!")}
            onMouseOut={() => setText("Mouse left!")}
        >
            <h2>{text}</h2>
        </div>
    );
};

export default MouseOverOutExample;
