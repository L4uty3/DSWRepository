import React from 'react';


const Input = ({ label, type='text', name, register, validationRules = {}, error, placeholder }) => {

const baseClass = "text-xl border rounded px-3 py-2 w-full focus:outline-none focus:ring-2 focus:ring-blue-500";

const normalClass = baseClass + " border-gray-300";

const errorClass = baseClass + "";

  return(
    <div className="mb-4">
      {/* <label htmlFor={name} className="text-xl block font-medium text-gray-700 mb-1">
        {label}:</label> */}
      <input
        type={type}
        id={name}
        name={name}
        className={error ? errorClass : normalClass}
        placeholder={placeholder}
        {...register(name, validationRules)}
      />
      {error && (
        <span className="text-red-500 text-xl mt-10">
          {error}
        </span>
      )}
    </div>
  );
};

export default Input;
