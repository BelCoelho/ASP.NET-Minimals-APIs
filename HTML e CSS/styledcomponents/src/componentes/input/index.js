import React from 'react';
import {
  InputConatiner,
  IconConatiner,
  InputText
} from './styles';

const Input = ({ leftIcon, placeholder, ...rest }) => {
  return (
    <InputConatiner>
      {leftIcon ? (<IconConatiner>{leftIcon}</IconConatiner>) : null}
      <InputText {...rest} placeholder={placeholder} />
    </InputConatiner>
  );
};

export { Input };