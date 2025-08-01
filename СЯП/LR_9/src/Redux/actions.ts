export const actionAddNewTask = (newTask:any):any=> {return ({type: 'ADD_TODO', payload: newTask})};
export const actionEditTask = (id:any, newTitle:any) => {return ({ type: 'EDIT_TODO', payload: { id, title: newTitle } })};
export const actionDeleteTask = (task:any) => {return ({type: 'DELETE_TODO', payload: task})}
export const actionToggle = (task:any) => {return ({type: 'TOGGLE_TODO', payload: task})}