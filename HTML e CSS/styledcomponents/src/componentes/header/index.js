import React from 'react'
import logoDIO from '../../assets/logo-dio.png'

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
                <UserPicture src="https://avatars.githubusercontent.com/u/45184516?v=4"/>
              ) : (
              <>
                <MenuRight href="/">Home</MenuRight>
                <Button title="Entrar" />
                <Button title="Cadastrar" />
              </>
            )}
          </Row>
      </Container>
    </Wrapper>
  )
}

export { Header }
