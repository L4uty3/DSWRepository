import React, { useState } from "react";
import { useForm } from "react-hook-form";
import Input from "./Input";
import "./Login.css";

const Login = () => {

  const [formData, setFormData] = useState({
    username: '',
    password: '',
  });

  const [errors, setErrors] = useState({});

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({
      ...formData,
      [name]: value,
    });
  };

    const validate = () => {
        const newErrors = {};
        if (!formData.username) {
            newErrors.username = "El nombre de usuario es obligatorio";
        }
        if (!formData.password) {
            newErrors.password = "La contraseña es obligatoria";
        }
        return newErrors;
    };

    const handleSubmit = (e) => {
        e.preventDefault(); //Evitamos que la página se recargue
        
        const validationErrors = validate();
        setErrors(validationErrors);

        if (Object.keys(validationErrors).length === 0) {
            console.log("Formulario enviado:", formData);
        }else{
            console.log("Errores de validación:", validationErrors);
        }
    };

    return (
    <div className="login-container">
      <form onSubmit={handleSubmit}>
        <h1>Iniciar Sesión</h1>
        <Input
          label="Usuario"
          type="text"
          name="username"
          value={formData.username}
          onChange={handleChange}
          error={errors.username}
          placeholder="Ingrese su nombre de usuario"
        />
        <Input
          label="Contraseña"
          type="password"
          name="password"
          value={formData.password}
          onChange={handleChange}
          error={errors.password}
          placeholder="Ingrese su contraseña"
        />
        <button type="submit">Iniciar Sesión</button>
      </form>
    </div>
  );
};

export default Login;