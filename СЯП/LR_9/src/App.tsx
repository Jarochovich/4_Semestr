import classes from './App.module.css'
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import MainComponent from './Components/MainComponent/MainComponent';

function App() {

  return (
    <div className={classes.App}>
      <BrowserRouter basename='/TodoList-React-TS'>
        <Routes>
          <Route path='/'>
            <Route index element={<MainComponent />} />
            <Route path='*' element={<h1>Not found page</h1>} />
          </Route>
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
