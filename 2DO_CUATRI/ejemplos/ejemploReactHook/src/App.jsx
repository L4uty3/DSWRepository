import { useForm } from "react-hook-form";
import "./App.css";

function App() {
  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm();

  const onSubmit = (data) => {
    console.log(data);
  };

  return (
    <>
      <form onSubmit={handleSubmit(onSubmit)} className="flex flex-col gap-2">
        <input 
        placeholder="Nombre"
        {...register('nombre', {
          required: 'El nombre es obligatorio',
          minLength: { value: 3, message: 'Mínimo 3 caracteres'},
        })}
        />
        {errors.nombre && <span>{errors.nombre.message}</span>}
        
        <input 
        type="email"
        placeholder="Correo"
        {...register('email', {
          pattern : {value: /^[^@]+@[^@]+\.[^@ .]{2,}$/,
            message : 'Correo inválido'
          },
        })}
        />
        {errors.email && <span>{errors.email.message}</span>}

        <input
        type="number"
        placeholder="Edad"
        {...register('edad', {
          min: { value: 18, message: 'Debe ser mayor de edad'},
        })}
        />
        {errors.edad && <span>{errors.edad.message}</span>}

        <button type="submit">Enviar</button>
      </form>
    </>
  );
}
export default App;

