import { useSelector } from 'react-redux';
import TodoItem from '../TodoItem/TodoItem';
import { RootState } from '../../Redux/store';

function TodoList({deleteTask, editTask, ...props}:any) {

   const tasks = useSelector((state: RootState) => state.todos);

  return (
    <div>
        {tasks.length != 0 
          ?
          tasks.map((el:any, num:any) =>
            <TodoItem 
            id = {el.id}
            title={el.title}
            number = {num + 1}
            key = {el.id}/>)
          : 
          <h1 style={{textAlign: 'center'}}>Задач нет</h1>}
    </div>
  );
}

export default TodoList;