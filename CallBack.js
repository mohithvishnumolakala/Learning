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


// //Asyncrous callback
//   function fetchData(callback) {
//     console.log("Fetching data...");
//     setTimeout(() => {
//       const data = { id: 1, name: "John Doe" };
//       callback(data);
//     }, 2000);
//   }
  
//   function displayData(data) {
//     console.log("Data received:", data);
//   }
  
//   fetchData(displayData);
  
//   // Output:
//   // Fetching data...
//   // Data received: { id: 1, name: 'John Doe' }


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
  