import React from "react";

const defaultClass = "w-full text-xl bg-blue-500 hover:bg-blue-600 text-white font-semibold py-2 px-4 rounded focus:outline-none focus:ring-2 focus:ring-blue-500 focus:ring-offset-2";

const Button = ({children, type="button", className='',...props}) => {
  return (
    <button type={type} {...props} className={defaultClass + " " + className}>
      {children}
    </button>
  );
};

export default Button;
