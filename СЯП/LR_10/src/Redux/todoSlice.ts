import { createSlice, PayloadAction } from '@reduxjs/toolkit';
import type { Reducer } from '@reduxjs/toolkit';

export interface Todo {
  id: number;
  title: string;
  isDone: boolean;
}

export const initialState: Todo[] = [
  { id: 1, title: 'Learning JavaScript', isDone: false },
  { id: 2, title: 'To Gym', isDone: false },
  { id: 3, title: 'Sleep by 23.00', isDone: false },
];

const todoSlice = createSlice({
  name: 'todos',
  initialState,
  reducers: {
    addNewTask: (state, action: PayloadAction<Todo>) => {
      state.push(action.payload);
    },
    toggleTask: (state, action: PayloadAction<number>) => {
      const task = state.find(task => task.id === action.payload);
      if (task) {
        task.isDone = !task.isDone;
      }
    },
    editTask: (state, action: PayloadAction<{id: number, newTitle: string}>) => {
      const task = state.find(task => task.id === action.payload.id);
      if (task) {
        task.title = action.payload.newTitle;
      }
    },
    deleteTask: (state, action: PayloadAction<number>) => {
      return state.filter(task => task.id !== action.payload);
    }
  }
});

export const { addNewTask, toggleTask, editTask, deleteTask } = todoSlice.actions;
export default todoSlice.reducer as Reducer<Todo[]>
