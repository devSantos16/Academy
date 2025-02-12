const sum = (x: number | string, y: number): number | string => {

    if (typeof(x) == "number") {
        return "It's not possible to sum";
    }
    
    return x + y;
}

const value = sum(2, 3);