import classes from './Counter.module.css'
import Button from '../Button/Button';
import { useDispatch} from 'react-redux';
import { decrement, increase, reset } from '../../redux/actions';

export default function Counter({count, ...props}:any) {

    const dispatсh = useDispatch();

    return (

        <div className={classes.wrapper}>
            <h1 className={classes.counter}>{count}</h1>
            <h3>{count}</h3>
            <div className={classes.buttons}>
                <Button fnc = {() => dispatсh(increase())}>+</Button>
                <Button fnc = {() => dispatсh(decrement())} disabled = {count === 0}>-</Button>
                <Button fnc = {() => dispatсh(reset())} disabled = {count === 0}>Reset</Button>
            </div>

        </div>
    );
}