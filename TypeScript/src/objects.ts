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


const printOrder = (message: Order[]) => {
    console.log(message.toString());
}

printOrder(joao.orders!);