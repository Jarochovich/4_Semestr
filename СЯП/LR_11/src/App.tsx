import classes from './App.module.css';
import PostForm from "./Components/PostForm/PostForm";
import PostList from "./Components/PostList/PostList";

function App() {
  return (
    <div className={classes.App}>
      <h1>Список постов</h1>
      <div className={classes.main}>
        <PostForm />
        <hr style={{marginTop: '20px'}}/>
        <PostList/>
      </div>
    </div>
  );
}

export default App;
