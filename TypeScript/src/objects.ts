// Type 
type Order = { 
    productId: string,
    price: number
};

type User = {
    firstName: string,
    age: Number,
    email?: string,
    password: string
    orders?: Order []
};

type Author = {
    isbn: number
};

const joao : User = {
    firstName: "Joao",
    age: 10,
    password: "joaozinho",
    orders: [
        { 
            productId: "Pc Gamer", price: 300 
        }
    ]
};

// Union
const pedrinho: User & Author = {
    firstName: "Pedrinho",
    age: 15,
    password: "pedrinho",
    isbn: 12345,
};


const printOrder = (message: Order[]) => {
    console.log(message.toString());
}

interface UserInterface {
    readonly firstName: string,
    email: string
}

const emailUser: UserInterface = {
    firstName: "HelloWorld",
    email: "helloworld@gmail.com"
};

// You cannot use this because this is readonly, and this feature works with interface
// emailUser.firstName = "jorginho";


// Interfaces with Function
interface MathFunc {
    math(x: number, y: number): number,
}

interface OtherMathFunc {
    (x: number, y: number): number
}

const mathSum: MathFunc = { 
     math: (x, y) => x + y
}

const otherMathSum : OtherMathFunc = (x, y) => {
    return x + y
}