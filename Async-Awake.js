async function matter() {      //async  is a keyword that return a prommise
    // using a Promise
    let data = await new Promise((resolve, reject) => {
      setTimeout(() => {
        resolve("Data fetched successfully!");
      }, 2000);  // Simulate a 2-second delay
    });
  
    return data;
  }
  
  // Calling the async function
  matter()
  .then((message) => {     //here .then(message) indicates a as we create new promise(a,b) the first value
    console.log("Fulfilled: " + message);
  });
  