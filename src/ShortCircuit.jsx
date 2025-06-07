import React from "react";

const Circuit = () => {
  const game= true


  const MyGame = () => {
    return (
      <div>
        <h2>I like Cricketer Dhoni</h2>
      </div>
    );
  };

  return (
    <div>
      {/* Conditional rendering using && */}
      {game && <MyGame />}
    </div>
  );
};

export default Circuit;
