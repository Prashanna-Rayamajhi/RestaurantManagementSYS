/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./src/**/*.{html,ts}",
  ],
  theme: {
    extend: {
      fontFamily:{
        'roboto-slab':['Roboto Slab', 'sans-serif'] 
      }
    },
    screens:{
      'mobile': {'min': '320px', 'max': '450px'},
      'tablet' : {'min':'451px', 'max': '800px'},
      'laptop': {'min':'801px', 'max': '1024px'},
      'desktop': '1440px'

    }
  },
  plugins: [],
}