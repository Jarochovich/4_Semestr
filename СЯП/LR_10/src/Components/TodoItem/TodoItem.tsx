import classes from './TodoItem.module.css';
import Button from '../UI/Button/Button';
import Checkbox from '../UI/Checkbox/Checkbox';
import { useState } from 'react';
import { useDispatch } from 'react-redux';
import { deleteTask, editTask } from '../../Redux/todoSlice';
import { AppDispatch } from '../../Redux/store';

function TodoItem({id, children, title, number, ...props} :any) {

  const dispatch = useDispatch<AppDispatch>();

  const [newTitle, setNewTitle] = useState(title);
  const [isEditing, setIsEditing] = useState(false);

  const [checked, setChecked] = useState(false);


  const saveEditTask = () => {
    if (newTitle.trim() !== '') {
      dispatch(editTask({id, newTitle}));
      setIsEditing(false);
    }
  };

  const delTask = (task:any) => {
    dispatch(deleteTask(task.id))
  } 

  const handleDelete = (e: any) => {
    e.preventDefault();
      const task = {
        id: id,
        title: title
    };
    delTask(task);
}

  return (
    <div className={classes.task}>
        <div className={classes.content}>
            <div className={classes.body}>
                <Checkbox name="done" 
                          type="checkbox"
                          checked={checked}
                          onChange={() => setChecked(!checked)}/>
                {isEditing 
                ? 
                  <input
                  type="text"
                  value={newTitle}
                  onChange={(e) => setNewTitle(e.target.value)}
                  onBlur={saveEditTask}
                  autoFocus
                  />
                : 
                  checked 
                  ?
                  <strong><s>{number}. {title}</s></strong>
                  : 
                  <strong>{number}. {title}</strong>}
                  
            </div>
        </div>
        <div className={classes.task_btn}>
          
          <div className={classes.task_operations}>
          <Button onClick={() => setIsEditing(true)}>Редактировать</Button>
          <Button onClick={handleDelete} 
                  style={{ borderColor: 'red', color: 'red' }}>Удалить</Button>
          </div>
        </div>
    </div>
  );
}

export default TodoItem;