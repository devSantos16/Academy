interface IPerson {
    sayMyName() : void;
}

class Person implements IPerson {
    protected id: number
    protected firstName: string

    constructor(id: number, firstName: string) {
        this.id = id
        this.firstName = firstName
    }

    public sayMyName(): void {
        console.log(this.firstName)
    }
}

class Employee extends Person {
    constructor(id: number, firstName: string) {
        super(id, firstName)
    }

    public override sayMyName(): void {
        console.log(`Hi my name is ${this.firstName}`)
    }
}

const p = new Employee(1, "Hunk")
p.sayMyName()