const person1={
    firstname : "mohith",
    secondname : "vishnumolakala",
    age:21,
    salary:15000,
  
}
const person2={
    firstname:"geetha",
    secondname:"gopalam",
    age:18,
    salary:20000,
   
}
function display(person){
    console.log(`firstname:${person.firstname}`);
    console.log(`secondname:${person.secondname}`);
    console.log(`age:${person.age}`);
    console.log(`salary:${person.salary}`);
}

console.log("details of mohith:")
display(person1);

console.log();

console.log("details of geetha:")
display(person2);