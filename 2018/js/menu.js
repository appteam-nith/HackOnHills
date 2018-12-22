(function(){

	const body = $('body'),
		  header = $('.header'),
		  content = $('.content'),
		  fullOverlay = $('.fullOverlay'),
		  navItems = $('.navItem'),
		  frames = $('.frame');

	var active = 0, headerOpened = false;

	function closeHeader(){
		for(let i=0; i<=navItems.length; ++i){
			setTimeout(function(){
				//navItems[i].addClass("visible");
				$(navItems[i]).removeClass("visible");
			}, 0);
		}

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

		for(let i=0; i<navItems.length; ++i){
			setTimeout(function(){
				//navItems[i].addClass("visible");
				$(navItems[i]).addClass("visible");
			}, i*100);
		}

	});

	fullOverlay.click(closeHeader);
	$('.closeHeader').click('click', closeHeader);

	[].forEach.call(navItems, function(item, index){
		item = $(item);
		item.click(function(){
			if(active == index)
				return;
			headerOpened=true;
			$(navItems[active]).removeClass('active');
			$(navItems[index]).addClass('active');
			active = index;
			closeHeader();
			setTimeout(function(){
				$('html, body').animate({
					scrollTop: $(frames[index]).offset().top
				}, 300, function(){
					headerOpened=false;
				});
			}, 300);
		});
	});

	$(document).ready(function(){
		$('.logo').addClass('active');
		setTimeout(function(){
			$('html, body').animate({
				scrollTop: 0
			})
		}, 0);
	});

	document.addEventListener('scroll', function(){
		if(headerOpened)
			return;
		const scrollPos = $('html, body').scrollTop();
		for(var i=frames.length-1; i>=0; --i){
			if(scrollPos>=(Math.trunc($(frames[i]).offset().top)-window.innerHeight/2)){
				$(navItems[active]).removeClass('active');
				$(navItems[i]).addClass('active');
				active = i;
				break;
			}
		}
	});
	
})();