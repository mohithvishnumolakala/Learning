// Using fetch() to make an API call
async function getData() {
    try {
      // Make a GET request to an API
      const response = await fetch('https://jsonplaceholder.typicode.com/posts/1');
      
      // Check if the response is OK (status 200-299)
      if (!response.ok) {
        throw new Error('Network response was not ok');
      }
  
      // Parse the response as JSON
      const data = await response.json();
  
      // Log the fetched data
      console.log(data);
    } catch (error) {
      console.error('There was a problem with the fetch operation:', error);
    }
  }
  
  // Calling the whole function
  getData();
  

