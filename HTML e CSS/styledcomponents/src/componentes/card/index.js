import React from 'react'

import { FiThumbsUp } from 'react-icons/fi'

import {
    CardContainer,
    Content,
    HasInfo,
    ImageBackground,
    PostInfo,
    UserInfo,
    UserPicture
} from './styles'

const Card = () => {
  return (
    <CardContainer>
        <ImageBackground src='https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEGgM5EBlYZsYMYoObaJDpUiX5QUsVvUYaBg&s'/>
        <Content>
            <UserInfo>
                <UserPicture src='https://avatars.githubusercontent.com/u/177854169?v=4'/>
                <div>
                    <h4>Isabela</h4>
                    <p>Há 8 minutos</p>
                </div>
            </UserInfo>
            <PostInfo>
                <h4>Aprendendo HTML, CSS e JavaScript</h4>
                <p>Projeto em processo...<strong>Saiba Mais</strong></p>
            </PostInfo>
            <HasInfo>
                <h4>#HTML #CSS #JavaScript</h4>
                <p><FiThumbsUp/> 10</p> 
            </HasInfo>
        </Content>
    </CardContainer>
  )
}

export  { Card }