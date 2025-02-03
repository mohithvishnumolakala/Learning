class person:
    def __init__(this,firstname,secondname,age,salary):
        this.firstname=firstname
        this.secondname=secondname
        this.age=age
        this.salary=salary
    
    def display(this):
        print(f"firstname:{this.firstname}")
        print(f"secondname:{this.secondname}")
        print(f"age:{this.age}")
        print(f"salary:{this.salary}")
        

person1=person("mohith","vishnumolakala",21,15000)
person2=person("geetha","gopalam",22,20000)

print("Details of mohith")
person1.display()
print("\nDetails of geetha")
person2.display()
        