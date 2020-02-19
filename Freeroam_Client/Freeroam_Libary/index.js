
import * as alt from 'alt-client';
import * as game from "natives";
let cursor = false;
export function ShowCursor(bool) {
    if (cursor == false && bool == false || cursor == true && bool == true) {
        return;
    }
    alt.toggleGameControls(!bool);
    alt.showCursor(bool);
    cursor = bool;
}
export function GetCursorStatus() {
    if (cursor) { return true; }
    else { return false; }
}

export function DrawText(msg, screenPos, scale, fontType, ColorRGB, useOutline = true, useDropShadow = true, layer = 0, align = 0) {
    let hex = msg.match('{.*}');
    if (hex) {
        const rgb = hexToRgb(hex[0].replace('{', '').replace('}', ''));
        r = rgb[0];
        g = rgb[1];
        b = rgb[2];
        msg = msg.replace(hex[0], '');
    }
    if (ColorRGB == undefined || ColorRGB == null) { ColorRGB = 255; }
    game.beginTextCommandDisplayText('STRING');
    game.addTextComponentSubstringPlayerName(msg);
    game.setTextFont(fontType);
    game.setTextScale(scale[0], scale[1]);
    game.setTextWrap(0.0, 1.0);
    game.setTextCentre(true);
    game.setTextColour(ColorRGB[0], ColorRGB[1], ColorRGB[2], ColorRGB[3]);
    game.setTextJustification(align);

    if (useOutline) game.setTextOutline();

    if (useDropShadow) game.setTextDropShadow();

    game.endTextCommandDisplayText(screenPos[0], screenPos[1]);
}


export function CreateBlip(name, pos, sprite, color, shortrange) {
    let blip = new alt.PointBlip(pos[0], pos[1], pos[2]);
    blip.sprite = sprite;
    blip.color = color;
    blip.shortRange = shortrange;
    blip.name = name;
}

export function CreatePed(PedName, Vector3Pos, rot) {
    game.createPed(0, alt.hash(PedName), Vector3Pos[0], Vector3Pos[1], Vector3Pos[2], rot, 0, 0);
}


export function getOffset(x, y, z, rz, rx, ry, offX, offY, offZ) {
    let pos = [];

    pos[0] = (cos(rz) * sin(ry) + cos(ry) * sin(rz) * sin(rx)) * offZ + (-cos(rx) * sin(rz)) * offY + (cos(rz) * cos(ry) - sin(rz) * sin(rx) * sin(ry)) * offX + x;
    pos[1] = (sin(rz) * sin(ry) - cos(rz) * cos(ry) * sin(rx)) * offZ + (cos(rz) * cos(rx)) * offY + (cos(ry) * sin(rz) + cos(rz) * sin(rx) * sin(ry)) * offX + y;
    pos[2] = (cos(rx) * cos(ry)) * offZ + (sin(rx)) * offY + (-cos(rx) * sin(ry)) * offX + z;

    return pos;
}