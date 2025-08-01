import { CounterActionTypes } from "./types"

   export const increase = () :any => {return({type: CounterActionTypes.INCREMENT, payload: 1})}
  
   export const decrement = () :any=> {return({type: CounterActionTypes.DECREMENT, payload: 1})}
  
   export const reset = () :any => {return({type: CounterActionTypes.RESET})}