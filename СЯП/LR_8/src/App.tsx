import { useSelector } from 'react-redux';
import classes from './App.module.css';
import Counter from './Components/Counter/Counter';

function App() {

  const count = useSelector((state:any) => state.count);

  return (
    <div className={classes.App}>
      <Counter count={count}/>
    </div>
  );
}

export default App;
