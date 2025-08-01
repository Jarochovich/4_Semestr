import { useDispatch } from "react-redux";
import Button from "../UI/Button/Button";
import Input from "../UI/Input/Input";
import classes from './TodoForm.module.css';
import { useState } from "react";
import { actionAddNewTask } from "../../Redux/actions";

function TodoForm({children, title, number, ...props} :any) {

  const dispatch = useDispatch();

  const [task, setTask] = useState('');

  const addTask = (newTask:any) => {
    dispatch(actionAddNewTask(newTask));
  }

  const addNewTask = (e:any) => {
      e.preventDefault();
      if (task.trim() !== '') {
        const newTask = {
          id: Date.now(),
          title: task,
          isDone: false
      };
      addTask(newTask);
      setTask('');
      }
  }

  return (
    <form className={classes.form}>
          <label>Название задачи:</label>
          <Input value={task}
                 onChange={(e:any) => setTask(e.target.value)} 
                 placeholder='Введите задачу' />
          <Button onClick={addNewTask} 
                  type='button'>Добавить задачу</Button>
    </form>
  );
}

export default TodoForm;