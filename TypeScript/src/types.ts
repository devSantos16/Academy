// Types
let age: number;
let userName: string;
let isValid: boolean;
let idk: any;

// Array
const arrayNumbers: number[] = [1,2,3,5,6];
const arrayStrings: string[] = ["Jair", "Messias", "Lula", "Silva"];

// Tuple
const john: [number, string] = [2, "John"];

// List of Tuple
const person: [number, string][] = [
    [1, "Eduardo"],
    john
];

// Intersections
let productId: string | number;

// Enum
enum Direction {
    Up = 1,
    Down = 2
}

let direction: number = Direction.Up;

// Type Assertions
const productName: any = "Boné";
let itemId = productName as string;
itemId = <string> productName;


