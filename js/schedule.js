(function(){
	const topSchedule = $('.top-schedule-content'),
		  bottomSchedule = $('.bottom-schedule-content');

	var active = 0, total = topSchedule.length;

	function init(){
		$(topSchedule[active]).addClass('active');
		$(topSchedule[active]).find('svg').addClass('active');
		$(bottomSchedule[active]).addClass('active');
		$(bottomSchedule[active]).addClass('displayContent');
	}

	$('.divider-left').click(function(){
		if(active > 0){
			$(topSchedule[active]).removeClass('active');
			$(topSchedule[active]).find('svg').removeClass('active');
			$(bottomSchedule[active]).removeClass('active');
			$(bottomSchedule[active]).removeClass('displayContent');

			--active;
			$(topSchedule[active]).addClass('active');
			$(bottomSchedule[active]).addClass('active');
			setTimeout(function(){
				$(topSchedule[active]).find('svg').addClass('active');
				$(bottomSchedule[active]).addClass('displayContent');
			}, 0);
			
			if(active === 0){
				$('.divider-left').addClass('inactive');
			}

			if(active < total-1){
				$('.divider-right').removeClass('inactive');
			}
		}
	});

	$('.divider-right').click(function(){
		if(active < total-1){
			$(topSchedule[active]).removeClass('active');
			$(topSchedule[active]).find('svg').removeClass('active');
			$(bottomSchedule[active]).removeClass('active');
			$(bottomSchedule[active]).removeClass('displayContent');

			++active;
			$(topSchedule[active]).addClass('active');
			$(bottomSchedule[active]).addClass('active');
			setTimeout(function(){
				$(topSchedule[active]).find('svg').addClass('active');
				$(bottomSchedule[active]).addClass('displayContent');
			}, 0);
			
			if(active === total-1){
				$('.divider-right').addClass('inactive');
			}

			if(active > 0){
				$('.divider-left').removeClass('inactive');
			}
		}
	});

	$(document).ready(init);

})();