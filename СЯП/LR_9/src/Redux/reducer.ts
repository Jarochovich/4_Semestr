
const defaultState: any = [
    { id: 1, title: 'Learning JavaScript', isDone: false },
    { id: 2, title: 'To Gym', isDone: false },
    { id: 3, title: 'Go to bed at 23.00', isDone: false },
  ];
  
  export const reducer = (state = defaultState, action: any) => {
    switch (action.type) {
      case 'ADD_TODO':
        return [...state, {...action.payload }];
  
      case 'TOGGLE_TODO':
        return state.map((task:any) =>
          task.id === action.payload ? { ...task, isDone: !task.isDone } : task);
  
      case 'EDIT_TODO':
        return state.map((task:any) =>
          task.id === action.payload.id ? { ...task, title: action.payload.title } : task);
  
      case 'DELETE_TODO':
        return state.filter((task:any) => task.id !== action.payload.id);
  
      default:
        return state;
    }
  };
  