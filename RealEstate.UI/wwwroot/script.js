// Slider Script
let slideIndex = 0;
const sliderWrapper = document.getElementById('sliderWrapper');
const slides = sliderWrapper.querySelectorAll('.slide');
const slideCount = slides.length;
const sliderWidth = 100;

function moveSlide(direction) {
    slideIndex += direction;

    if (slideIndex < 0) {
        slideIndex = slideCount - 1;
    } else if (slideIndex >= slideCount) {
        slideIndex = 0;
    }

    sliderWrapper.style.transform = `translateX(${-slideIndex * sliderWidth}%)`;
}

// Image Gallery - Fullscreen
function openFullscreen(imgSrc) {
    const modal = document.getElementById('fullscreenModal');
    const img = document.getElementById('fullscreenImage');
    img.src = imgSrc;
    modal.classList.add('active');
}

function closeFullscreen() {
    const modal = document.getElementById('fullscreenModal');
    modal.classList.remove('active');
}

// Theme Toggle
function toggleTheme() {
    document.querySelector('html').classList.toggle('dark');
    const themeToggle = document.getElementById('themeToggle');
    themeToggle.classList.toggle('rotate-center');
}

// Search Overlay
function toggleSearch() {
    document.getElementById('searchOverlay').classList.toggle('active');
}

// Add an event listener to the search icon to trigger the toggleSearch function
document.querySelector('.search-icon').addEventListener('click', toggleSearch);

// Modal Functions
function toggleModal() {
    document.getElementById('loginModal').classList.toggle('active');
    // Reset to Sign In form when opening the modal
    showSignIn();
}

function showSignUp() {
    document.getElementById('signInForm').style.display = 'none';
    document.getElementById('signUpForm').style.display = 'block';
    document.getElementById('modalTitle').textContent = 'Sign Up';
}

function showSignIn() {
    document.getElementById('signInForm').style.display = 'block';
    document.getElementById('signUpForm').style.display = 'none';
    document.getElementById('modalTitle').textContent = 'Sign In';
}

// Password Visibility Toggle
function togglePasswordVisibility(inputId, toggleId) {
    const passwordInput = document.getElementById(inputId);
    const passwordToggle = document.getElementById(toggleId);

    if (passwordInput.type === 'password') {
        passwordInput.type = 'text';
        passwordToggle.classList.remove('fa-eye');
        passwordToggle.classList.add('fa-eye-slash');
    } else {
        passwordInput.type = 'password';
        passwordToggle.classList.remove('fa-eye-slash');
        passwordToggle.classList.add('fa-eye');
    }
}

// Specific password toggle functions
function toggleSignInPasswordVisibility() {
    togglePasswordVisibility('passwordInput', 'passwordToggle');
}

function toggleSignUpPasswordVisibility() {
    togglePasswordVisibility('signUpPasswordInput', 'signUpPasswordToggle');
}