import React from 'react';


const Input = ({ label, type='text', name, register, validationRules = {}, error, placeholder }) => {

  return(
    <div className="input-group">
      <label htmlFor={name}>{label}:</label>
      <input
        type={type}
        id={name}
        name={name}
        placeholder={placeholder}
        {...register(name, validationRules)}
      />
      {error && <p className="error-message">{error}</p>}
    </div>
  );
};

export default Input;
