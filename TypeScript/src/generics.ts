// Generics
let returnValue = <T> (value: T): T => value

const message = returnValue<string>('Hello world')
const count = returnValue<number>(5)

function Method<T>(value: T) : T { 
    return value
}

let v = Method<string>("2")
