import axios from "axios";
import { Post } from "../Models/Post";

class ApiPost {
    baseUrl: string;

    constructor(baseUrl: string) {
        this.baseUrl = baseUrl;
    }

    async getList() {
        try {
            const response = await axios.get<Post[]>(`${this.baseUrl}/Post`);
            return response.data;
        } catch (error) {
            throw error;
        }
    }

    async getById(id: number) {
        try {
            const response = await axios.get<Post>(`${this.baseUrl}/Post/${id}`);
            return response.data;
        } catch (error) {
            throw error;
        }
     }
}

export default ApiPost;