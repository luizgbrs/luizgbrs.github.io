:root {
    --primary-color: #00AEEF;   /* se não rodar, volta pro vid, minuto 12,27 */
    --secondary-color: #0074E4;  
    --background-dark: #070707; 
    --text-light: #F5F5F5;      
    --text-dark: #2C2C2C; 
    --border: #858585;
    font-size: 10px;
}
* {
   margin: 0px;
   padding: 0px;
   outline: none;
   border: none;
   text-decoration: none;
   text-transform: capitalize;
   transition: 0.4s linear;
   font-family: "Ubuntu", serif;
}
body {
   background-color: var(--background-dark)
}
section {
   padding: 3rem 2rem;
   margin: 0 auto;
   max-width: 1200px;
}
.header {
   height: 90px;
   padding: 15px 25px;
   position: fixed;
   align-items: center;
   justify-content: space-between;
   top: 0;
   left: 0;
   right: 0;
   z-index: 99;
   border-bottom: 1px solid #ffffff;
   background-color: #070707;
}
nav {
   display: flex;
   align-items: center;
}
nav ul {
   list-style: none;
   display: flex;
   gap: 20px; 
}
nav ul li {
   display: flex;
   align-items: center;
}
.logo {
   display: flex;
   align-items: center;
   max-height: 40px; 
}
.header section {
   display: flex;
   align-items: center;
   justify-content: space-between;
   padding-top: 1.5rem;
   padding-bottom: 1.5rem;
}
.navbar a {
   margin: 0 1rem;
   font-size: 1.8rem;
   color: #F5F5F5;
}
.navbar a:hover {
   color: #00AEEF;
   border-bottom: 0.1rem solid #00AEEF;
   padding-bottom: 0.3rem;
   font-size: 1.6rem;
}
.icons img {
   margin: 1rem;
   cursor: pointer;
}
.icons img:hover {
   width: 40px;
   height: 40px;
}
.btn {
   background: #0074E4;
   color: #fff;
   padding: 1.4rem 10rem;
   font-size: 1.75rem;
   cursor: pointer;
   margin-top: 2rem;
   display: inline-block;
}
.btn:hover {
   color: #ffffff;
   border-bottom: 0.1rem solid #fff;
   padding-bottom: 1.8rem;
   font-size: 2.5em;
}
.home-container {
   background: url(imgs/apple-watch-3-9.jpg) no-repeat center center;
   background-position: center;
   background-size: cover;
}
.home-container section {
   display: flex;
   align-items: center;
   min-height: 100vh;
}
.content {
   max-width: 60rem;
}
.content h3 {
   color: #fff;
   font-size: 6rem;
}
.content p{
   color: #fff;
   font-size: 2rem;
   font-weight: 100;
   line-height: 2;
   padding: 1rem 0;
}
