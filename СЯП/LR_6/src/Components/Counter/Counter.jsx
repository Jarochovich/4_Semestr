import classes from './Counter.module.css'
import Button from '../Button/Button';
import { useState } from 'react';

export default function Counter(props) {

    const [count, setCount] = useState(0);

    function increase() {
        if (count < 5) setCount(count + 1);
    }

    function reset() {
        setCount(0);
    }

    return (
        <div className={classes.wrapper}>
            <h1 className={`${classes.counter} ${count === 5 ? classes.red : ''}`}>{count}</h1>

            <div className={classes.buttons}>
                <Button title = 'increase' fnc = {increase} disabled = {count === 5}/>
                <Button title = 'reset' fnc = {reset} disabled = {count === 0}/>
            </div>

        </div>
    );
}