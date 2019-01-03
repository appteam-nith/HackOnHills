(function(){
	const canvas = document.getElementById('c'),
		ctx = canvas.getContext('2d'),
		count = 100;
	var width, height, snow = new Array(), animation;

	function init(){
		animation = window.requestAnimationFrame(draw);
		width=window.innerWidth;
		height=window.innerHeight;

		canvas.width = window.innerWidth;
		canvas.height = window.innerHeight;

		for(var i=0; i<count; ++i){
			snow[i] = {
				x: Math.floor(Math.random()*width),
				y: -Math.floor(Math.random()*height),
				s: Math.floor(Math.random()*3 + 2),
				r: Math.floor(Math.random()*2 + 1)
			}
		}
	}

	function updateVals(){
		snow.forEach(function(item, index){
			item.y += item.s;
			if(item.y > height){
				item.y = -Math.floor(Math.random()*height);
				item.s = Math.floor(Math.random()*2 + 2);
				item.r = Math.floor(Math.random()*3 + 1);
			}
			snow[index] = item;
		});
	}

	function draw(){
		updateVals();
		ctx.clearRect(0,0,window.innerWidth,window.innerHeight);
		ctx.beginPath();
		ctx.fillStyle = "white";
		snow.forEach(function(item){
			ctx.beginPath();
			ctx.arc(item.x, item.y, item.r, 0, 2*Math.PI);
			ctx.fill();
			ctx.closePath();
		})
		ctx.closePath();
		cancelAnimationFrame(animation);
		animation = window.requestAnimationFrame(draw);
	}

	window.addEventListener('load',init);
	window.addEventListener('resize',function(){
		cancelAnimationFrame(animation);
		init();
	});
})();