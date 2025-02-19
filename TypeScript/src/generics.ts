// Generics
let returnValue = <T> (value: T): T => value

const message = returnValue<string>('Hello world')
const count = returnValue<number>(5)

function Method<T>(value: T) : T { 
    return value
}

let v = Method<string>("2")



class GenericNumber<T> {
    x: T
    y: T

    calc: (x: T, y: T) => T

    constructor(x: T , y: T, calc: (x: T, y: T) => T){
        this.x = x
        this.y = y
        this.calc = calc
    }

}

const genericNumber = new GenericNumber<number>(2, 4, 
    (x, y) => {
        return x + y
})