import { createSlice, PayloadAction } from '@reduxjs/toolkit';
import type { Reducer } from '@reduxjs/toolkit';
import { fetchAllPosts } from './postsService';

export interface IPost {
  id: number;
  title: string;
  body: string;
}

export interface PostsState {
  posts: IPost[];
  isLoading: boolean;
  error: string;
}

export const initialState: PostsState = {
  posts: [],
  isLoading: false,
  error: '',
};

const postSlice = createSlice({
  name: 'posts',
  initialState,
  reducers: {},
  extraReducers: (builder) => {
    builder
      .addCase(fetchAllPosts.pending, (state) => {
        state.isLoading = true;
        state.error = '';
      })
      .addCase(fetchAllPosts.fulfilled, (state, action: PayloadAction<IPost[]>) => {
        state.isLoading = false;
        state.posts = action.payload;
      })
      .addCase(fetchAllPosts.rejected, (state, action) => {
        state.isLoading = false;
        state.error = action.error.message || 'Ошибка загрузки постов';
      });
  }
});

export default postSlice.reducer as Reducer<PostsState>;