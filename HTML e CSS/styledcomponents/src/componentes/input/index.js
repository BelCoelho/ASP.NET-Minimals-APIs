import React from 'react';

import { Controller } from "react-hook-form";

import {
  InputConatiner,
  IconConatiner,
  InputText,
  ErrorText
} from './styles';

const Input = ({ control, name, leftIcon, placeholder, errorMessege, ...rest }) => {
  return (
    <>
    <InputConatiner>
      {leftIcon ? (<IconConatiner>{leftIcon}</IconConatiner>) : null}
      <Controller
        control={control}
        name={name}
        rules={{ required: true }}
        render={({ field }) => <InputText {...field} {...rest} placeholder={placeholder} />}
      />
      
    </InputConatiner>
    
    {errorMessege ? <ErrorText>{errorMessege}</ErrorText> : null}
    </>
  );
};

export { Input };