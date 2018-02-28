(function(){

	const body = $('body'),
		  header = $('.header'),
		  content = $('.content'),
		  fullOverlay = $('.fullOverlay'),
		  navItems = $('.navItem'),
		  frames = $('.frame');

	let active = 0, headerOpened = false;

	function closeHeader(){
		header.removeClass('active');
		content.removeClass('active');
		fullOverlay.removeClass('active');
		body.removeClass('active');
		headerOpened = false;
	}

	$('.hamburger').click(function(){
		headerOpened=true;
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
			if(active == index)
				return;
			$(navItems[active]).removeClass('active');
			$(navItems[index]).addClass('active');
			active = index;
			closeHeader();
			setTimeout(function(){
				$('html, body').animate({
					scrollTop: $(frames[index]).offset().top
				}, 300);
			}, 300);
		})
	});

	$(document).ready(function(){
		$('.logo').addClass('active');
		$('html, body').animate({
			scrollTop: 0
		}, 0);

	});

	document.addEventListener('scroll', function(){
		if(headerOpened)
			return;
		const scrollPos = $('html, body').scrollTop();
		for(let i=frames.length-1; i>=0; --i){
			if(scrollPos>=Math.trunc($(frames[i]).offset().top)){
				$(navItems[active]).removeClass('active');
				$(navItems[i]).addClass('active');
				active = i;
				break;
			}
		}
	});
	
})();