import { Link } from 'react-router-dom'

import { Button } from '../../componentes/button/Index'
import { Header } from '../../componentes/header'
import { Card } from '../../componentes/card'
import { UserInfo } from '../../componentes/UserInfo'

import ImagemFundo from '../../assets/banner.png'

import 
{
    Container,
    TextContent,
    Title,
    TitleHighLight,
    Column
} from './styles'


const Feed = () => {
    return(
        <>
            <Header autenticado={true}/>
            <Container>
                <Column flex = {3}>
                    <Title>Feed</Title>
                    <Card/>
                    <Card/>
                    <Card/>
                    <Card/>
                    <Card/>
                </Column>
                <Column flex = {1}>
                <TitleHighLight># RANKING DOS 5 MELHORES DA SEMANA</TitleHighLight>
                <UserInfo percentual={65} nome = 'Isabela' image='https://avatars.githubusercontent.com/u/177854169?v=4'/>
                <UserInfo percentual={45} nome = 'Isabela' image='https://avatars.githubusercontent.com/u/177854169?v=4'/>
                <UserInfo percentual={37} nome = 'Isabela' image='https://avatars.githubusercontent.com/u/177854169?v=4'/>
                <UserInfo percentual={23} nome = 'Isabela' image='https://avatars.githubusercontent.com/u/177854169?v=4'/>
                <UserInfo percentual={9} nome = 'Isabela' image='https://avatars.githubusercontent.com/u/177854169?v=4'/>
                </Column>
            </Container>
        </>
    )
}

export { Feed }