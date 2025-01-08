// Creating a Promise
const myPromise = new Promise((a, b) => {
  let success = true; // Change to false to see rejection

  if (success) {
    a("The operation was successful!");
  } else {
    b("The operation failed.");
  }
});

// Using the Promise
myPromise
  .then((message) => {     //here .then(message) indicates a as we create new promise(a,b) the first value
    console.log("Fulfilled: " + message);
  })
  .catch((error) => {        //here .catch(error) indicates b as we create new promise(a,b) the second value 
    console.log("Rejected: " + error);
  });
