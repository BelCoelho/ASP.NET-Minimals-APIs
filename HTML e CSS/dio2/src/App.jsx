import React, {useEffect, useState} from "react";

const Input = ({ value, onChangeText }) => {
    return (
      <input type="text" value={value} onChange={onChangeText} />
    );
  };//Definido o Input

const App = () => 
{
    const[count, setCount] = useState()
    const [usuario, setUsuario] = useState("")
    const [usuarios, setUsuarios] = useState([]) //Criação de estado inicial
    /*esse useState retorna uma arrays de duas opções, 
      sendo a primeira o estado atual e a segunda é a função para mudar o valor do estado*/
      
    const handleAddUser = () => {
        setUsuarios([...usuarios, usuario])//Os três pontos servem para deixar aquilo que tinha antes
        setUsuario("")
    }

    useEffect(() => {
        setCount(usuarios.length)
    }, [usuarios])

    return (
        <div className="App">
            <h1>Olá</h1>
            <h3>Total: {count}</h3>
            <div>
                <Input 
                    value = {usuario}
                    onChangeText = {(event) => setUsuario(event.target.value)}
                />
                <button onClick={handleAddUser}>Adicionar</button>
            </div>
            {usuarios.map((item) => (
                <p>{item}</p>
            ))}
        </div>
        )
}
//Quando clica no botão ele adiciona na lista o valor que está no input

export default App
 
