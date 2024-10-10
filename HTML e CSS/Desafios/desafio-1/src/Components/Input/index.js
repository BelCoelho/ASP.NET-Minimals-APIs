import React from 'react';

// @ts-ignore // Para TypeScript
import { InputContainer } from './styles';//Faz a div estilizada

const Input = ({value}) => {
    return(
        <div classname ="App">
            <InputContainer>
                <input disabled value = {value}/>            
            </InputContainer>
        </div>
    );
};

export default Input