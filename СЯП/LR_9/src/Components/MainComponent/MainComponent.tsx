import classes from './MainComponent.module.css';
import TodoForm from "../TodoForm/TodoForm";
import TodoList from "../TodoList/TodoList";

function MainComponent({children, title, number, ...props} :any) {

  return (
    <div className={classes.App}>
        <h1>Список задач</h1>

          <div className={classes.main}>
            <TodoForm />
            <hr style={{marginTop: '20px'}}/>
            <TodoList />
          </div>
    </div>
  );
}

export default MainComponent;
 
 
 
