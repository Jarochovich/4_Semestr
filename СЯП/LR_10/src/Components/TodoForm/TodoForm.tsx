import { useDispatch } from "react-redux";
import Button from "../UI/Button/Button";
import Input from "../UI/Input/Input";
import classes from './TodoForm.module.css';
import { useState } from "react";
import { AppDispatch } from "../../Redux/store";
import { addNewTask } from "../../Redux/todoSlice";

function TodoForm({children, title, number, ...props} :any) {

  const dispatch = useDispatch<AppDispatch>();

  const [task, setTask] = useState('');

  const addTask = (newTask:any) => {
    dispatch(addNewTask(newTask));
  }

  const addNewTaskList = (e:any) => {
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
          <Button onClick={addNewTaskList} 
                  type='button'>Добавить задачу</Button>
    </form>
  );
}

export default TodoForm;