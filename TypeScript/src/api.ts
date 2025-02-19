import axios from "axios"

const displayNarutoCharacter = async () => {
    try {
        const user = (await axios.get("https://narutodb.xyz/api/character")).data.characters[0]
        console.log(user)
    }
    catch(error){
        console.log(error)
    }
}

displayNarutoCharacter()
