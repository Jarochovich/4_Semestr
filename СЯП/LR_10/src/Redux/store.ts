import { configureStore } from '@reduxjs/toolkit';
import todoReducer, { Todo } from './todoSlice';
import type { Reducer } from '@reduxjs/toolkit';

export const store = configureStore({
  reducer: {
    todos: todoReducer as Reducer<Todo[]>
  }
});

// Типы для TypeScript
export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;