import React, { useState } from "react";

const FormEventsExample = () => {
    const [inputValue, setInputValue] = useState("");
    const [status, setStatus] = useState("");

    const handleSubmit = (e) => {
        e.preventDefault();
        setStatus("Form submitted!");
    };

    const handleReset = () => {
        setInputValue("");
        setStatus("Form reset!");
    };

    return (
        <form onSubmit={handleSubmit} onReset={handleReset}>
            <input
                type="text"
                value={inputValue}
                onChange={(e) => setInputValue(e.target.value)}
                onInput={() => setStatus("Typing...")}
                onFocus={() => setStatus("Input focused")}
                onBlur={() => setStatus("Input blurred")}
            />
            <br />
            <button type="submit">Submit</button>
            <button type="reset">Reset</button>
            <p>{status}</p>
        </form>
    );
};

export default FormEventsExample;
