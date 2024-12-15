import { MdEmail, MdLock  } from "react-icons/md";
import { Button } from '../../componentes/button/Index'
import { Header } from '../../componentes/header'
import { Input } from '../../componentes/input'

import { useForm } from "react-hook-form";

import { useNavigate } from "react-router-dom";
import { yupResolver } from '@hookform/resolvers/yup';
import * as yup from "yup";

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
    CriarText,
    ErrorText
} from './styles'


const Login = () => {

    const schema = yup.object({
        email: yup.string().email().required('Campo Obrigatório'),
        password: yup.string().min(3, 'No minímo 3 caracteres').required('Campo Obrigatório'),
      }).required();

    const navigate = useNavigate();

    const { control, handleSubmit, formState: { errors, isValid } } = useForm({
        resolver: yupResolver(schema),
        mode: 'onChange',
});
console.log (isValid, errors)

    const onSubmit = data => console.log(data);

    const handleClickSighIn = () => {
        navigate ('/feed')
    }

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
                    <TitleLogin>Entrar</TitleLogin>
                    <SubTitleLogin>Faça seu login e make the change._</SubTitleLogin>
                    <form onSubmit={handleSubmit(onSubmit)}>
                    <Input name="email" control={control} errorMessege={errors.email?.message} placeholder="E-mail" leftIcon={<MdEmail/>}/>
                    <Input  name="password" control={control} errorMessege={errors.password?.message} placeholder="Senha" type='password' leftIcon={<MdLock/>}/>
                    <Button title='Entrar' variant="secondary" type="submit" onClick={handleClickSighIn}/>
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