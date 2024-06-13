var swiper = new Swiper(".mySwiper", {
    slidesPerView: 1,
    spaceBetween: 30,
    loop: true,
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
    navigation: {
        nextEl: ".swiper-button-next",
        prevEl: ".swiper-button-prev",
    },
});

var swiper3 = new Swiper(".mySwiper-3", {
    slidesPerView: 5,
    spaceBetween: 10,
    pagination: {
        el: ".mySwiper-3 .swiper-pagination",
        clickable: true,
    },
});

function toggleFilterForm() {
    var filterFormContainer = document.getElementById('filter-form-container');
    if (filterFormContainer.classList.contains('hidden')) {
        filterFormContainer.classList.remove('hidden');
        filterFormContainer.classList.add('visible');
    } else {
        filterFormContainer.classList.remove('visible');
        filterFormContainer.classList.add('hidden');
    }
}

//Count
document.addEventListener('DOMContentLoaded', function () {
    var quantityInput = document.getElementById('quantity-input');
    var btnMinus = document.getElementById('btn-minus');
    var btnPlus = document.getElementById('btn-plus');

    btnMinus.addEventListener('click', function () {
        var currentValue = parseInt(quantityInput.value);
        if (currentValue > 1) { // Prevent going below 1
            quantityInput.value = currentValue - 1;
        }
    });

    btnPlus.addEventListener('click', function () {
        var currentValue = parseInt(quantityInput.value);
        quantityInput.value = currentValue + 1;
    });
});

document.querySelectorAll('.sort-by-product-wrap').forEach(function (dropdown) {
    dropdown.addEventListener('click', function () {
        let dropdownMenu = this.nextElementSibling;
        document.querySelectorAll('.sort-by-dropdown').forEach(function (menu) {
            if (menu !== dropdownMenu) {
                menu.style.display = 'none';
            }
        });
        dropdownMenu.style.display = dropdownMenu.style.display === 'block' ? 'none' : 'block';
    });
});

document.addEventListener('click', function (event) {
    if (!event.target.closest('.sort-by-cover')) {
        document.querySelectorAll('.sort-by-dropdown').forEach(function (menu) {
            menu.style.display = 'none';
        });
    }
});

$(window).on('load', function () {
    $(".loader").fadeOut();
    $("#preloder").delay(200).fadeOut("slow");

    /*------------------
        Gallery filter
    --------------------*/
    $('.featured__controls li').on('click', function () {
        $('.featured__controls li').removeClass('active');
        $(this).addClass('active');
    });
    if ($('.featured__filter').length > 0) {
        var containerEl = document.querySelector('.featured__filter');
        var mixer = mixitup(containerEl);
    }
});