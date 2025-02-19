interface UserCode {
    email: string,
    password: string
}

// Callback
const loginUserCode = (email: string, password: string, onSucess: (usercode : UserCode) => void, onError: (error: Error) => void)  => {
    setTimeout(
        () => {
            const error: boolean = true;

            if (error) {
                return onError(new Error("Deu ruim"))
            }

            const user : UserCode = {
                email: email,
                password: password
            }

            onSucess(user)
        },        
        4000
    )

    console.log("Test")
}

const onSucess = (usercode: UserCode): void => {
    console.log(usercode)
}

const onError = (error: Error): void => {
    console.log(error)
}


loginUserCode("dev@gmail.com", "1234", onSucess, onError)
