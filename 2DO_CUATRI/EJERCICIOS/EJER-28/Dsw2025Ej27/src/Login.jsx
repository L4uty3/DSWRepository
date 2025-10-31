import React, { useState } from "react";
import { useForm } from "react-hook-form";
import Input from "./Input";
import "./Login.css";

function Login() {

  const onSubmit = (data) => {
    console.log("Formulario enviado:", data);
  };

  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm();

    return (
      <form onSubmit={handleSubmit(onSubmit)} className="flex flex-col gap-2">
        <input 
          placeholder="username"
          {...register('username', {
            required: 'El nombre de usuario es obligatorio',
            minLength: { value: 3, message: 'Mínimo 3 caracteres'},
          })}
        />
        {errors.username && <span className="error-message">{errors.username.message}</span>}

        <input 
          type="password"
          placeholder="password"
          {...register('password', {
            required: 'La contraseña es obligatoria',
            minLength: { value: 6, message: 'Mínimo 6 caracteres'},
          })}
        />
        {errors.password && <span className="error-message">{errors.password.message}</span>}

        <button type="submit">Iniciar Sesión</button>
      </form>
    );
}

export default Login;
