/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./Pages/*.razor", "./Shared/*.razor"],
  theme: {
    extend: {},
  },
  daisyui: {
    themes: [
      {
        paper: {
          primary: "#f59e0b",

          secondary: "#fcd34d",

          accent: "#fde68a",

          neutral: "#2a323c",

          "base-100": "#fef3c7",

          info: "#3abff8",

          success: "#36d399",

          warning: "#fbbd23",

          error: "#f87272",
        },
      },
    ],
  },
  plugins: [require("daisyui")],
};
