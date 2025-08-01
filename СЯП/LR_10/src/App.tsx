import classes from './App.module.css'
import TodoList from './Components/TodoList/TodoList';
import TodoForm from './Components/TodoForm/TodoForm';

function App() {
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

export default App;
