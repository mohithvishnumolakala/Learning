import React, { useState } from "react";

const KeyboardEventsExample = () => {
    const [key, setKey] = useState("");

    return (
        <div>
            <input
                type="text"
                placeholder="Type here"
                onKeyDown={(e) => setKey(`KeyDown: ${e.key}`)}
                onKeyUp={(e) => setKey(`KeyUp: ${e.key}`)}
                onKeyPress={(e) => setKey(`KeyPress: ${e.key}`)}
            />
            <p>{key}</p>
        </div>
    );
};

export default KeyboardEventsExample;
