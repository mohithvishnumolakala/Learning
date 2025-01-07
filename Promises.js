// Creating a Promise
const myPromise = new Promise((resolve, reject) => {
  let success = true; // Change to false to see rejection

  if (success) {
    resolve("The operation was successful!");
  } else {
    reject("The operation failed.");
  }
});

// Using the Promise
myPromise
  .then((message) => {
    console.log("Fulfilled: " + message);
  })
  .catch((error) => {
    console.log("Rejected: " + error);
  });
