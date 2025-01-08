function greet() {
    console.log("Hello!");
  }
  
  function ask() {
    console.log("How are you?");
  }
  
  function reply() {
    console.log("I'm fine, thank you.");
  }
  
  // Synchronous execution
  greet();
  ask();
  reply();
  
  // Output:
  // Hello!
  // How are you?
  // I'm fine, thank you.
  


/*
console.log("Start");

setTimeout(() => {
  console.log("This runs after 2 seconds");
}, 2000);

setTimeout(()=>{
    console.log("This runs after 5 seconds");
},5000);

// setInterval(()=>{
//   console.log("this will print the no.of delay time");
//   },1000);

console.log("End");

// Output:
// Start
// End
// This runs after 2 seconds
// This runs after 5 seconds 
*/
