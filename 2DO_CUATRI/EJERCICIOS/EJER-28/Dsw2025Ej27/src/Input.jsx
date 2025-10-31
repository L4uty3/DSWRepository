import React from 'react';


const Input = ({ label, type, name, value, onChange, error, placeholder }) => {

  return(
    <div className="input-group">
      <label htmlFor={name}>{label}:</label>
      <input
        type={type}
        id={name}
        name={name}
        value={value}
        onChange={onChange}
        placeholder={placeholder}
      />
      {error && <p className="error-message">{error}</p>}
    </div>
  );
};

export default Input;
