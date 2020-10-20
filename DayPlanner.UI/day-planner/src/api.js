import axios from 'axios'

export default axios.create({
    baseURL: 'https://localhost:44399',
    headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
    }
})