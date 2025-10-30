import React, { useState } from "react";
import { useForm } from "react-hook-form";
import Input from "./Input";
import "./Login.css";

function Login() {

  const onSubmit = (data) => {
    console.log("Formulario enviado:", data);
  };
// const Login = () => {

//   const [formData, setFormData] = useState({
//     username: '',
//     password: '',
//   });

//   const [errors, setErrors] = useState({});

//   const handleChange = (e) => {
//     const { name, value } = e.target;
//     setFormData({
//       ...formData,
//       [name]: value,
//     });
//   };

  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm();

    // const validate = () => {
    //     const newErrors = {};
    //     if (!formData.username) {
    //         newErrors.username = "El nombre de usuario es obligatorio";
    //     }
    //     if (!formData.password) {
    //         newErrors.password = "La contraseña es obligatoria";
    //     }
    //     return newErrors;
    // };

    // const handleSubmit = (e) => {
    //     e.preventDefault(); //Evitamos que la página se recargue
        
    //     const validationErrors = validate();
    //     setErrors(validationErrors);

    //     if (Object.keys(validationErrors).length === 0) {
    //         console.log("Formulario enviado:", formData);
    //     }else{
    //         console.log("Errores de validación:", validationErrors);
    //     }
    // };

    return (
      <form onSubmit={handleSubmit(onSubmit)} className="flex flex-col gap-2">
        <input 
          placeholder="username"
          {...register('username', {
            required: 'El nombre de usuario es obligatorio',
            minLength: { value: 3, message: 'Mínimo 3 caracteres'},
          })}
        />
        {errors.username && <span>{errors.username.message}</span>}

        <input 
          type="password"
          placeholder="password"
          {...register('password', {
            required: 'La contraseña es obligatoria',
            minLength: { value: 6, message: 'Mínimo 6 caracteres'},
          })}
        />
        {errors.password && <span>{errors.password.message}</span>}

        <button type="submit">Iniciar Sesión</button>
      </form>
    );
}

export default Login;


    // <div className="login-container">
    //   <form onSubmit={handleSubmit}>
    //     <h1>Iniciar Sesión</h1>
    //     <Input
    //       label="Usuario"
    //       type="text"
    //       name="username"
    //       value={formData.username}
    //       onChange={handleChange}
    //       error={errors.username}
    //       placeholder="Ingrese su nombre de usuario"
    //     />
    //     <Input
    //       label="Contraseña"
    //       type="password"
    //       name="password"
    //       value={formData.password}
    //       onChange={handleChange}
    //       error={errors.password}
    //       placeholder="Ingrese su contraseña"
    //     />
    //     <button type="submit">Iniciar Sesión</button>
    //   </form>
    // </div>
