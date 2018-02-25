(function(){
	document.getElementsByClassName('hamburger')[0].addEventListener("click", function(){
		document.getElementsByClassName('header')[0].className = "header active";
		document.getElementsByClassName('content')[0].className = "content active";
		document.getElementsByClassName('fullOverlay')[0].className = "fullOverlay active";
		document.body.className="active"
	});

	document.getElementsByClassName("fullOverlay")[0].addEventListener("click", function(){
		document.getElementsByClassName('header')[0].className = "header";
		document.getElementsByClassName('content')[0].className = "content";
		document.getElementsByClassName('fullOverlay')[0].className = "fullOverlay";
		document.body.className=""
	});

	document.getElementsByClassName("closeHeader")[0].addEventListener("click", function(){
		document.getElementsByClassName('header')[0].className = "header";
		document.getElementsByClassName('content')[0].className = "content";
		document.getElementsByClassName('fullOverlay')[0].className = "fullOverlay";
		document.body.className=""
	});
	
})();