import axios from "axios";
import postSlice, { IPost } from "./postSlice";
import { createAsyncThunk } from "@reduxjs/toolkit";

export const fetchAllPosts = createAsyncThunk(
    'post/fetchAll',
    async (_, thunkAPI) => {
        try {
            const response = await axios.get<IPost[]>("https://jsonplaceholder.typicode.com/posts");
            return response.data;
        } catch (error) {
            return thunkAPI.rejectWithValue("Не удалось загрузить посты");
        }
    }
)
