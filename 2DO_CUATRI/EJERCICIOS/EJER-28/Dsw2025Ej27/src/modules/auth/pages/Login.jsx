import React, { useState } from "react";
import { useForm } from "react-hook-form";
import Input from "../../../modules/shared/components/Input";
import Button from "../../../modules/shared/components/Button";
import "./Login.css";

function Login() {

  const onSubmit = (data) => {
    console.log("Formulario enviado:", data);
  };

  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm({mode: 'onChange'});

    return (
      <form onSubmit={handleSubmit(onSubmit)} className="flex flex-col gap-2">
        <Input
          label="Username"
          name="username"
          placeholder="username"
          register={register}
          validationRules={{
            required: 'username requerido',
            minLength: {value: 3, message: 'minimo 3 caracteres'}
          }}
          error={errors.username?.message}
        />

        <Input
          label="Password"
          type="password"
          name="password"
          placeholder="password"
          register={register}
          validationRules={{
            required: 'La contraseña es obligatoria',
            minLength: { value: 6, message: 'Mínimo 6 caracteres'},
          }}
          error={errors.password?.message}
        />

        <Button type="submit">Iniciar Sesión</Button>

      </form>
    );
}

export default Login;
