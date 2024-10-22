import { useState, useEffect, useMemo, useCallback } from 'react';

const Teste = () => {

const [age, setAge] = useState(25);
const [name, setName] = useState ('Pablo')

  const handleChangeAge = useCallback(() => {
    const newAge = 10 * age
    console.log('Age atual:', age, newAge)
    setAge (prev => prev === 25 ? 77 : 25)
    },[age])

  const handleChangeName = () => {
    console.log('atualizou nome')
    setName (prev => prev === 'Pablo' ? 'José' : 'Pablo')
    }  

  return (
    <div>
      <p>
        Idade: {age}
      </p>
      <p>
        Nome: {name}
      </p>
      <button onClick={handleChangeAge}>Alterar Idade</button>
      <button onClick={handleChangeName}>Alterar Nome</button>

    </div>
  )
}

export { Teste };