/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./input/**/*.{cshtml,html,js}"],
    theme: {
      extend: {},
    },
    plugins: [
        require('prettier-plugin-tailwindcss'),
        require("daisyui")
    ],
  }