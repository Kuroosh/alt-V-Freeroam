//----------------------------------//
///// VenoX Gaming & Fun 2019 © ///////
//////By Solid_Snake & VnX RL Crew////
////////www.venox-reallife.com////////
//----------------------------------//

alt.on('Scoreboard:Show', function () {
	$("#playerlist").removeClass("d-none")
});
alt.on('Scoreboard:Hide', function () {
	$("#playerlist").addClass("d-none")
});


function load_datatables() {
	var c = document.body.children;
	var i;
	for (i = 0; i < c.length; i++) {
		document.getElementById("scoreboardplayer").innerHTML = '';
		document.getElementById("scoreboardping").innerHTML = '';
	}
};


alt.on("FillScoreboard", (pl_li) => {
	load_datatables();
	let p = JSON.parse(pl_li);
	for (let i = 0; i < p.length; i++) {
		let data_pl = p[i];
		let name = data_pl.SpielerName;
		let ping = data_pl.Ping;
		let R_Storage = data_pl.ColorStorageR;
		let G_Storage = data_pl.ColorStorageG;
		let B_Storage = data_pl.ColorStorageB;

		var first = document.createElement("li");
		first.className = 'player_v';
		var second = document.createElement("li");
		second.className = 'player_v_s_v';

		var first_ping = document.createElement("li");
		first_ping.className = 'player_v_ping';
		var second_ping = document.createElement("li");
		second_ping.className = 'player_v_s_v_ping';

		var textnode = document.createTextNode(name);
		second.appendChild(textnode);
		document.getElementById("scoreboardplayer").appendChild(first);
		document.getElementById("scoreboardplayer").appendChild(second);


		var ping_dev = document.createTextNode(ping);
		second_ping.appendChild(ping_dev);
		document.getElementById("scoreboardping").appendChild(first_ping);
		document.getElementById("scoreboardping").appendChild(second_ping);

		second.style.color = "rgba(" + R_Storage + "," + G_Storage + "," + B_Storage + ",1)";
		second_spielzeit.style.color = "rgba(" + R_Storage + "," + G_Storage + "," + B_Storage + ",1)";
		second_state.style.color = "rgba(" + R_Storage + "," + G_Storage + "," + B_Storage + ",1)";
		second_tode.style.color = "rgba(" + R_Storage + "," + G_Storage + "," + B_Storage + ",1)";
		second_kills.style.color = "rgba(" + R_Storage + "," + G_Storage + "," + B_Storage + ",1)";

	}
});