import { MdEmail, MdLock  } from "react-icons/md";
import { Button } from '../../componentes/button/Index'
import { Header } from '../../componentes/header'
import { Input } from '../../componentes/input'

import 
{
    Container,
    Row,
    Title,
    TitleLogin,
    SubTitleLogin,
    Column,
    Wrapper,
    EsqueciText,
    CriarText
} from './styles'


const Login = () => {
    return(
        <>
            <Header />
            <Container>
                <Column>
                    <Title> 
                        A plataforma para você aprender com experts, 
                        dominar as principais tecnologias e entrar mais 
                        rápido nas empresas mais desejadas
                    </Title>
                </Column>
                <Column>
                <Wrapper>
                    <TitleLogin>Faça seu cadastro</TitleLogin>
                    <SubTitleLogin>Faça seu login e make the change._</SubTitleLogin>
                    <form>
                    <Input placeholder="E-mail" leftIcon={<MdEmail/>}/>
                    <Input placeholder="Senha" type='password' leftIcon={<MdLock/>}/>
                        <Button title='Entrar' variant="secondary"/>
                    </form>
                    <Row>
                        <EsqueciText>Esqueci minha senha</EsqueciText>
                        <CriarText>Criar conta</CriarText>
                    </Row>
                </Wrapper>
                    
                </Column>
            </Container>
        </>
    )
}

export { Login }