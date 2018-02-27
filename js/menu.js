(function(){

	const body = $('body'),
		  header = $('.header'),
		  content = $('.content'),
		  fullOverlay = $('.fullOverlay'),
		  navItems = $('.navItem');

	let active = 0;

	function closeHeader(){
		header.removeClass('active');
		content.removeClass('active');
		fullOverlay.removeClass('active');
		body.removeClass('active');
	}

	$('.hamburger').click(function(){
		header.addClass('active');
		content.addClass('active');
		fullOverlay.addClass('active');
		body.addClass('active');
	});

	document.getElementsByClassName("fullOverlay")[0].addEventListener("click", closeHeader);
	document.getElementsByClassName("closeHeader")[0].addEventListener("click", closeHeader);

	[].forEach.call(document.getElementsByClassName('navItem'), function(item, index){
		item.addEventListener('click', function(){
			$(navItems[index]).addClass('active');
			$(navItems[active]).removeClass('active');
			active = index;
			closeHeader();
			setTimeout(function(){
				$('html, body').animate({
					scrollTop: $($('.frame')[index]).offset().top
				}, 300);
			}, 300);
		})
	});
	
})();