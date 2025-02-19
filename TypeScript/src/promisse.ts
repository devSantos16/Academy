interface UserPromisse {
    email: string,
    password: string
}

// Promisses
const loginUserPromisse = (email: string, password: string): Promise<UserPromisse> => {
    return new Promise((resolve, reject) => {
        const execute = () => {
            const error = true;
    
            if(error) {
                reject(new Error("Deu ruim"))
            }
    
            const user: UserPromisse = {
                email: email,
                password: password
            }
    
            resolve(user)
        }

        setTimeout(execute, 4000)
    })
    
    
}

const resolve = (userPromisse: UserPromisse): void => {
    console.log(userPromisse)
}

const reject = (error: Error) => {
    console.log("Erro inesperado")
    console.log(error)
}

loginUserPromisse("devsantos@gmail.com", "123456")
.then(resolve)
.catch(reject)