// Toggle icon navbar
let menuIcon = document.querySelector('#menu-icon');
let navbar = document.querySelector('.navbar');

menuIcon.onclick = () => {
    menuIcon.classList.toggle('bx-x');
    navbar.classList.toggle('active');
};

// Scroll Section Active Link
let sections = document.querySelectorAll('section');
let navLinks = document.querySelectorAll('header nav a');

window.onscroll = () => {
    sections.forEach(sec => {
        let top = window.scrollY;
        let offset = sec.offsetTop - 150;
        let height = sec.offsetHeight;
        let id = sec.getAttribute('id');

        if(top >= offset && top < offset + height){
            navLinks.forEach(links => {
                links.classList.remove('active');
                document.querySelector('header nav a[href*=' + id + ']').classList.add('active');
            });
        }
    });

    // stickt navbar
    let header = document.querySelector('header')

    header.classList.toggle('sticky', window.scrollY > 100);

    // Remove Toggle icon and navbar when click navbar link (scroll)
    menuIcon.classList.remove('bx-x');
    navbar.classList.remove('active');
};

    // stickt navbar
    ScrollReveal({ 
        //reset: true,
        distance: '80px',
        duration: 2000,
        delay: 200
    });

    ScrollReveal().reveal('.home-content, .heading', { origin: 'top' });
    ScrollReveal().reveal('.home-image, .services-container, .portfolio-box, .contact form', { origin: 'bottom' });
    ScrollReveal().reveal('.home-content h1, .about-img ', { origin: 'right' });
    ScrollReveal().reveal('.home-content p, .about-content ', { origin: 'left' });

    // typed js
    const typed = new Typed('.multiple-text', {
        strings: ['برنامه نویس', 'طراح سایت', 'طراح نرم افزار'],
        typeSpeed: 100,
        backSpeed: 100,
        backDelay: 1000,
        loop:true
    })
