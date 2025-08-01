import classes from './Input.module.css';

function Input(props:any) {
  return (
    <input className={classes.input} {...props}></input>
  );
}

export default Input;