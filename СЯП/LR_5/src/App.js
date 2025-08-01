import classes from './App.module.css';
import Counter from "./Components/Counter/Counter";

export default function App() {
  return (
    <div className={classes.App}>
      <Counter />
    </div>
  );
}