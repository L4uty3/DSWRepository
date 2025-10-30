import { useForm } from "react-hook-form";
import "./App.css";

function App() {
  const {
    register,
    handleSubmit,
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
          minlenghth: { value: 3, message: 'Mínimo 3 caracteres'},
        })}
        />
        {errors.nombre && <span>{errors.nombre.message}</span>}
        
        <input 
        type="mail"
        placeholder="Correo"
        
      </form>
    </>
  );
}
export default App;

