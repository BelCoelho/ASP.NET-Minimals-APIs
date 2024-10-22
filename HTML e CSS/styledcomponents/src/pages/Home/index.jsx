import { useNavigate } from 'react-router-dom'

import { Button } from '../../componentes/button/Index'
import { Header } from '../../componentes/header'

import ImagemFundo from '../../assets/banner.png'

import 
{
    Container,
    TextContent,
    Title,
    TitleHighLight,
} from './styles'


const Home = () => {

    const navigate = useNavigate();

    const handleClickSighIn = () => {
        navigate ('/register')
    }



    return(
        <>
            <Header />
            <Container>
                <div>
                    <Title> 
                        <TitleHighLight>
                            Implemente 
                            <br/>
                        </TitleHighLight>
                        o seu futuro agora!
                    </Title>
                    <TextContent>
                    A plataforma para você aprender com experts, dominar as principais tecnologias e entrar mais rápido nas empresas mais desejadas.
                    </TextContent>
                    <Button title="Começar agora" variant="secondary" onClick={handleClickSighIn} />
                </div>
                <div>
                    <img src = {ImagemFundo} alt = "Imagem principal"/>
                </div>
            </Container>
        </>
    )
}

export {Home}