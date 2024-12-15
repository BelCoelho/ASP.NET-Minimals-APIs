import Button from "./Components/Button"; // inporta o botão que está na pasta botão na pasta componentes 

function App() {
  return (
    <div className="App">
      <h1>Olá React</h1>
      <Button title = "Entrar"/>
      <Button title = "Sair"/>
      <Button title = "Ligar"/>
      <Button title = "Desligar"/>

    </div>
  );
}

export default App;
