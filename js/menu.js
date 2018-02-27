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

	fullOverlay.click(closeHeader);
	$('.closeHeader').click('click', closeHeader);

	[].forEach.call(navItems, function(item, index){
		item = $(item);
		item.click(function(){
			$(navItems[active]).removeClass('active');
			$(navItems[index]).addClass('active');
			active = index;
			closeHeader();
			setTimeout(function(){
				$('html, body').animate({
					scrollTop: $($('.frame')[index]).offset().top
				}, 300);
			}, 300);
		})
	});

	$(document).ready(function(){
		$('.logo svg path').addClass('active');
	});

	document.addEventListener('scroll', function(){
		if($('html, body').scrollTop()){

		}
	});
	
})();