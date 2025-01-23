class person{
    constructor(firstname,secondname,age,salary){
        this.firstname=firstname;
        this.secondname=secondname;
        this.age=age;
        this.salary=salary;
    }
    display(){
        console.log(`firstname:${this.firstname}`);
        console.log(`secondname:${this.secondname}`);
        console.log(`age:${this.age}`);
        console.log(`salary:${this.salary}`);
    }

}
const person1 = new person("mohith","vishnumolakala",21,15000);
const person2 = new person("geetha","gopalam",18,20000);

console.log("mohith details:")
person1.display();

console.log();

console.log("geetha details:")
person2.display();