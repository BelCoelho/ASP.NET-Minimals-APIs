//Estiliza a parte da entrada

import styled from 'styled-components';

export const InputContainer = styled.div`
    width: 100%;
    height: 75px;
    background-color: #C8F2C8;

    display: flex;
    align-items: center;
    justify-content: flex-end;

    font-size: 24px;
    font-family: 'Arial';

    input {
        width: 100%;
        height: 75px;
        border: 0;
        display: block;
        direction: rtl;
        pandding: 0 10px;

        font-size: 30px;
        font-family: 'Arial';
        color: #000
    }
`
//No imput, é feita a estilização da entrada de dados