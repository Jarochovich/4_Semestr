import { createApi, fetchBaseQuery } from '@reduxjs/toolkit/query/react';
import { IPost } from './postSlice';

export const postAPI = createApi({
    reducerPath: 'postApi',
    baseQuery: fetchBaseQuery({baseUrl: 'http://localhost:5000'}),
    tagTypes: ['Post'],
    endpoints: (build) => ({
        fetchALLPosts: build.query<IPost[], number>({
            query: (limit: number = 20) => ({
                url: '/posts',
                params: {
                    _limit: limit
                }
            }),
            providesTags: result => ['Post']
        }),
        createPost: build.mutation<IPost, IPost>({
                 query: (post) => ({
                url: '/posts',
                method: 'POST',
                body: post
            }),
            invalidatesTags: ['Post']
        }),
        updatePost: build.mutation<IPost, IPost>({
                 query: (post) => ({
                url: `/posts/${post.id}`,
                method: 'PUT',
                body: post
            }),
            invalidatesTags: ['Post']
        }),
        deletePost: build.mutation<IPost, IPost>({
                 query: (post) => ({
                url: `/posts/${post.id}`,
                method: 'DELETE',
            }),
            invalidatesTags: ['Post']
        })
    })
})





// const BASE_URL = 'http://localhost:5000/posts';

// export const fetchAllPosts = createAsyncThunk<IPost[], number | undefined>(
//   'posts/fetchAll',
//   async (limit = 20, thunkAPI) => {
//     try {
//       const response = await axios.get<IPost[]>(`${BASE_URL}?_limit=${limit}`);
//       return response.data;
//     } catch (error) {
//       return thunkAPI.rejectWithValue('Ошибка загрузки постов');
//     }
//   }
// );

// export const createPost = createAsyncThunk<IPost, IPost>(
//   'posts/create',
//   async (post, thunkAPI) => {
//     try {
//       const response = await axios.post<IPost>(BASE_URL, post);
//       return response.data;
//     } catch (error) {
//       return thunkAPI.rejectWithValue('Ошибка создания поста');
//     }
//   }
// );

// export const updatePost = createAsyncThunk<IPost, IPost>(
//   'posts/update',
//   async (post, thunkAPI) => {
//     try {
//       const response = await axios.put<IPost>(`${BASE_URL}/${post.id}`, post);
//       return response.data;
//     } catch (error) {
//       return thunkAPI.rejectWithValue('Ошибка обновления поста');
//     }
//   }
// );

// export const deletePost = createAsyncThunk<string, string>(
//   'posts/delete',
//   async (id, thunkAPI) => {
//     try {
//       await axios.delete(`${BASE_URL}/${id}`);
//       return id;
//     } catch (error) {
//       return thunkAPI.rejectWithValue('Ошибка удаления поста');
//     }
//   }
// );

