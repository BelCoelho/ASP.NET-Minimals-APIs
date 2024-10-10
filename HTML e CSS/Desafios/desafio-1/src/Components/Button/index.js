/* eslint-disable no-unreachable */

import styled from "styled-components";
import {ButtonContainer} from './styled';

const Button = ({label, onClick}) => {
        return(
            <ButtonContainer onClick = {onClick}>
                {label}
            </ButtonContainer>
        );
    }
    
    export default Button