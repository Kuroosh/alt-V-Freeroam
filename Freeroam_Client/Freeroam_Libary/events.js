import * as alt from 'alt-client';
import * as game from "natives";

let LocalPlayer = alt.Player.local;


//////////////////////////////////////////////////////////////////////////////////////////

alt.onServer("BlipClass:CreateBlip", (BlipJson) => {
    let Blip = JSON.parse(BlipJson);
    for (let i = 0; i < Blip.length; i++) {
        let data_blip = Blip[i];
        //alt.log("Datas : " + data_blip.Name + " | " + [data_blip.posX, data_blip.posY, data_blip.posZ] + " | " + data_blip.Sprite + " | " + data_blip.Color + " | " + data_blip.ShortRange);
        CreateBlip(data_blip.Name, [data_blip.posX, data_blip.posY, data_blip.posZ], data_blip.Sprite, data_blip.Color, data_blip.ShortRange);
    }
});

alt.onServer("Clothes:Load", (clothesslot, clothesdrawable, clothestexture) => {
    game.setPedComponentVariation(LocalPlayer.scriptID, clothesslot, clothesdrawable, clothestexture);
    alt.log("Clothes:Loaded");
});

alt.onServer("Accessories:Load", (clothesslot, clothesdrawable, clothestexture) => {
    game.setPedPreloadVariationData(LocalPlayer.scriptID, clothesslot, clothesdrawable, clothestexture);
    alt.log("Accessories:Loaded");
});



//////////////////////////////////////////////////////////////////////////////////////////


alt.onServer('Player:Visible', (bool) => {
    game.setEntityVisible(LocalPlayer.scriptID, bool, 0);
});

alt.onServer('Player:WarpIntoVehicle', (veh, seat) => {
    alt.setTimeout(() => {
        game.taskWarpPedIntoVehicle(LocalPlayer.scriptID, veh.scriptID, seat);
    }, 500);
});

alt.onServer('Player:WarpOutOfVehicle', () => {
    if (LocalPlayer.vehicle) {
        game.taskLeaveVehicle(alt.Player.local.scriptID, LocalPlayer.vehicle.scriptID, 16);
    }
});

alt.on('keyup', (key) => {
});

alt.on('keydown', (key) => {
});

//////////////////////////////////////////////////////////////////////////////////////////

let lastFrameCount = game.getFrameCount();
let CurrentFPS = 0;

alt.setInterval(() => {
    CurrentFPS = game.getFrameCount() - lastFrameCount;
    lastFrameCount = game.getFrameCount();
}, 1000);

function DrawGlobalHUD() {
    DrawText(CurrentFPS.toString(), [0.99, 0.001], [0.5, 0.5], 0, [0, 105, 145, 200], true, true);
}

alt.everyTick(() => {
    DrawGlobalHUD();

});

//////////////////////////////////////////////////////////////////////////////////////////
