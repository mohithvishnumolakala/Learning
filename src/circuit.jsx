import React from 'react';

const apple = { a: 3 };
const mango = { b: 4 ,c:6};
const fruits = { ...apple, ...mango }; 
 console.log(fruits)

const Circuit = () => {
  return (
    <div>
      <p>{JSON.stringify(fruits)}</p>
    </div>
  );
};

export default Circuit;
