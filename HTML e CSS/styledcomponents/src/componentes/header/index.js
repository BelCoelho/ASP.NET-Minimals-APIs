import React from 'react'
import logoDIO from '../../assets/logo-dio.png'

import { useNavigate } from 'react-router-dom'


import { Button } from '../button/Index'

import { Container, 
    Wrapper, 
    BuscarInputContainer, 
    Input, 
    Row, 
    Menu, 
    MenuRight, 
    UserPicture
} from './styles'



const Header = ({autenticado}) => {

  const navigate = useNavigate();

  const handleClickSighRegister = () => {
    navigate ('/register')
  }

  const handleClickSighIn = () => {
    navigate ('/login')
  }

  return (
    <Wrapper>
      <Container>

          <Row>
            <img src={logoDIO} alt="Logo da dio"/>
            {//Condição
            autenticado ? (
              <>
                <BuscarInputContainer>
                  <Input placeholder='Buscar...'/>
                </BuscarInputContainer>
                  <Menu>Live Code</Menu>
                  <Menu>Global</Menu>
                  </>
                ):null}
          </Row>

          <Row>
            {//Condição
            autenticado ? (
                <UserPicture src="https://avatars.githubusercontent.com/u/177854169?v=4"/>
              ) : (
              <>
                <MenuRight href="/">Home</MenuRight>
                <Button title="Entrar" onClick={handleClickSighIn}/>
                <Button title="Cadastrar" onClick={handleClickSighRegister}/>
              </>
            )}
          </Row>
      </Container>
    </Wrapper>
  )
}

export { Header }
