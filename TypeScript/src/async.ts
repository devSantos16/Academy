interface UserPromisse {
    email: string,
    password: string
}

// Promisses
const loginUserAsync = (email: string, password: string): Promise<UserPromisse> => {
    return new Promise((resolve, reject) => {
        const execute = () => {
            const error = true
    
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

const displayUser = async () => {
    try {
        const resolve = await loginUserAsync("dev@gmail.com", "12345")
        console.log(resolve)
    }
    catch(reject) {
        console.log(reject)
    }
}

displayUser()
