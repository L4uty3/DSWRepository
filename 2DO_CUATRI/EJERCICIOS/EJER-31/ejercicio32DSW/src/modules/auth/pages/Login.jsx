import React, { useState } from "react";
import { useForm } from "react-hook-form";
import Input from "../../../modules/shared/components/Input";
import Button from "../../../modules/shared/components/Button";

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
      <div className="min-h-screen bg-green-100 grid place-items-center p-4">
      <form onSubmit={handleSubmit(onSubmit)} className="bg-white p-6 rounded shadow-md w-full max-w-sm">
        <h2 className="text-4xl font-bold mb-5 text-center text-gray-800">Iniciar Sesión</h2>

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
      </div>
    );
}

export default Login;
