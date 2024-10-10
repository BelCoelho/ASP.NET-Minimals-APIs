import styled from 'styled-components';

export const Contaier = styled.div //esse container vai envolver toda a aplicação
    `
        width: 100%; 
        height: 100vh;
        background-image: url('https://img.freepik.com/fotos-gratis/quadro-negro-inscrito-com-formulas-e-calculos-cientificos_1150-19413.jpg');

        display: flex;
        align-items: center;
        justify-content: center;
    `
    //Largura 100%
    //Altura 100vh
    //Cor de fundo



export const Content = styled.div`
    background-color: #FFFF;
    width: 40%;
    min-height: 350px;
`

export const Row = styled.div`
    display: flex;
    flex-direction: row;
    justfy-content: space-between;
    align-itens: center
`

export const Column = styled.div`
    display: flex;
    flex-direction: column;
    justfy-content: space-between;
    align-itens: center
`