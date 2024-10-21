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
        navigate ('/login')
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
                        Domine as tecnoplogias utilizadas pelas empresas mais 
                        inovadoras do mundo e encare seu novo desafio profisional, 
                        evoluindo em comunidade com os melhores experts.
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