//syncrous callback
function greet(name, callback) {
    console.log("Hello, " + name);
    callback();
  }
  
  function sayGoodbye() {
    console.log("Goodbye!");
  }
  
  greet("Mohit", sayGoodbye);
  
  // Output:
  // Hello, Mohit
  // Goodbye!


//   //callback hell pyramid shape
//   setTimeout(() => {
//     console.log("Task 1");
//     setTimeout(() => {
//       console.log("Task 2");
//       setTimeout(() => {
//         console.log("Task 3");
//       }, 1000);
//     }, 1000);
//   }, 1000);
  