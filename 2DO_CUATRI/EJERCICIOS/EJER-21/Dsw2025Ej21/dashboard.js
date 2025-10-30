document.addEventListener('DOMContentLoaded', () => {
  const logoutButton = document.getElementById('logout');

  const menuButton = document.getElementById('boton');

  const nav = document.querySelector('nav');

  logoutButton.addEventListener('click', () => {
    window.location.href = 'login.html';
  });

  menuButton.addEventListener('click', () => {
    nav.classList.toggle('active');
  });

  const navItems = document.querySelectorAll('nav ul li2');

  navItems.forEach(item => {
    item.addEventListener('click', () => {
      nav.classList.remove('active');
    });
  });
});