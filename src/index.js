import React from 'react';
import ReactDOM from 'react-dom/client';
import StateMgm from './PropsContainer/StateMgm';
import App from './TernaryOperators/TernaryOperator'
import ClickEvent from './Events/ClickEvent';
import DoubleClickExample from './Events/DoubleClick';
import MouseOverOutExample from './Events/MouseOverOut'
import KeyboardEventsExample from './Events/KeyDownUpPress'
import FormEventsExample from './Events/FormEvents'
import Form from "./FormsEvents/FormExam";
import './App.css'



const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <Form/>
  </React.StrictMode>
);


