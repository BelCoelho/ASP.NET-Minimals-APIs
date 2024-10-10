//Faz a configuração na tela

// @ts-ignore // Para TypeScript
import Input from "./Components/Input/index";
// @ts-ignore // Para TypeScript
import Button from "./Components/Button/index";
import { Contaier, Content, Row, Column } from "./styles"; //Importa o arquivo styles, que contem o container para a página
import { useState } from "react";



function App() {
  //seção de funções
  const [currentNumber, setCurrentNumber] = useState('')//Primeiro valor a aparecer no display será o 0
  const [firstNumber, setFirtNumber] = useState('0')
  const [operation, setOperation] = useState('')

  const handClear = () => { 
    setCurrentNumber ('') 
    setOperation('')
  }//Retorna qualquer valor no display para 0
  

  const handleAddNumber = (number) => {
    setCurrentNumber(prev => {
      // Permite adicionar '0' se o número atual não estiver vazio ou se o número adicionado for diferente de '0'
      return prev !== '' || number !== '0' ? `${prev}${number}` : prev;
    });
  };


/********MATEMÁTICA ******* */

  const handleSoma = () => {
    if (firstNumber === '0')
    {
      setFirtNumber(String(currentNumber))
      setCurrentNumber('')
      setOperation('+')
    }else{
      const soma =  Number(firstNumber) + Number(currentNumber)
      setCurrentNumber(String(soma))
      setFirtNumber('0')
      setOperation('')
    }
  }

  const handleSubtrair = () => {
    if (firstNumber === '0')
    {
      setFirtNumber(String(currentNumber))
      setCurrentNumber('')
      setOperation('-')
    }else{
      const subtrair =  Number(firstNumber) - Number(currentNumber)
      setCurrentNumber(String(subtrair))
      setFirtNumber('0')
      setOperation('')
    }
  }

  const handleMultiplicar = () => {
    if (firstNumber === '0')
    {
      setFirtNumber(String(currentNumber))
      setCurrentNumber('')
      setOperation('x')
    }else{
      const multiplicar =  Number(firstNumber) * Number(currentNumber)
      setCurrentNumber(String(multiplicar))
      setFirtNumber('0')
      setOperation('')
    }
  }

  const handleDividir = () => {
    if (firstNumber === '0')
    {
      setFirtNumber(String(currentNumber))
      setCurrentNumber('')
      setOperation('÷')
    }else{
      const dividir =  Number(firstNumber) / Number(currentNumber)
      setCurrentNumber(String(dividir))
      setFirtNumber('0')
      setOperation('')
    }
  }

  const handleEgual = () => {
    if (firstNumber !== '0' && operation !== '' && currentNumber !== '0')
    {
      
      switch(operation)
      {
      case '+':
      handleSoma();
      //Chama a operação de soma
      break

      case '-':
      handleSubtrair();
      //Chama a operação de subtração
      break

      case 'x':
      handleMultiplicar();
      //Chama a operação de multiplicação
      break

      case '÷':
      handleDividir();
      //Chama a operação de divisão
      break

      default: break
      }
      ///setFirtNumber(String(currentNumber))
      ///handClear()
    }
      
  }

  return (
    <div className="App">
      <Contaier>
        <Content>
          <Input value = {currentNumber} />
          <Row>
            <Button label = '%' onClick={() => handleAddNumber('%')} />
            <Button label = '÷' onClick={handleDividir} />
            <Button label = 'x' onClick={handleMultiplicar} />
            <Button label = 'C' onClick={handClear} />
          </Row>
          <Row>
            <Button label = '1' onClick={() => handleAddNumber('1')} />
            <Button label = '2' onClick={() => handleAddNumber('2')} />
            <Button label = '3' onClick={() => handleAddNumber('3')} />
            <Button label = '+' onClick={handleSoma} />
          </Row>
          <Row>
            <Button label = '4' onClick={() => handleAddNumber('4')} />
            <Button label = '5' onClick={() => handleAddNumber('5')} />
            <Button label = '6' onClick={() => handleAddNumber('6')} />
            <Button label = '-' onClick={handleSubtrair} />
          </Row>
          <Row>
            <Button label = '7' onClick={() => handleAddNumber('7')} />
            <Button label = '8' onClick={() => handleAddNumber('8')} />
            <Button label = '9' onClick={() => handleAddNumber('9')} />
            <Button label = '=' onClick={handleEgual} />
          </Row>
          <Row>
            <Button label = '0' onClick={() => handleAddNumber('0')} />
          </Row>
        </Content>
      </Contaier>
    </div>
  );
}

export default App;
