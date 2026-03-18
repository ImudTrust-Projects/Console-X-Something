# Console-X-Something (CXS)

CXS is a simple Console and admin system for Gorilla Tag.

---

## Implementation (for developers)

Drag all files from CXS (except `Plugin.cs` and `PluginInfo.cs`) into your project under a folder.

Modify the configuration of `CXS.cs` and `ServerData.cs` in the **"Configuration"** regions.

Add this snippet of code into your `BaseUnityPlugin` (from `Plugin.cs`):

```csharp
// Put this snippet of code in your BaseUnityPlugin
void Start() => CXS.CXS.LoadCXS();
```

---

## Example Usage

To execute CXS commands, you can use the `CXS.ExecuteCommand()` method with its given parameters.  
Here is the list of all working commands:

- `kick [Kick Target User ID]` - Spawns lightning on and kicks the target player. Send as `all` for the lightning to network.
- `silkick [Kick Target User ID]` - Kicks the target player with no effects.
- `kickall` - Spawns lightning on and kicks everyone in the room using CXS.
- `crash` - Crashes the receiver.
- `block` - Blocks the receiver from joining lobbies, can be easily bypassed.
- `join [Room Name]` - Makes the receiver join the specified room.
- `isusing` - Used to find other people using CXS. Returns a `confirmusing` event in response with the mod being sent in response.
- `nocone` - Disables the indicator showing you have CXS on the receiver's end.
- `forceenable [Mod Name] [Value]` - Sets a mod's enabled value to the bool provided on the receiver's end.
- `toggle [Mod Name]` - Toggles a mod on or off on the receiver's end.
- `togglemenu [Toggle]` - Toggles their menu on or off on the receiver's end.
- `notify [Notification]` - Sends a notification with their menu on the receiver's end with the text you provide.
- `sleep [Duration ms]` - Sleeps on the targets main thread for duration.
- `weather [Raining]` - Sets the weather of the user.
- `time [Time]` - Sets whether it's raining or not for the client.
- `rigposition [Enabled] [Body [Position] [Rotation]] [Left Hand [Position] [Rotation]] [Right Hand [Position] [Rotation]]` - Sets whether a rig is enabled or disabled.
- `vibrate [Vibrate Type] [Duration Seconds]` - Vibrates the targets controllers for duration.
- `tp [Position]` - Teleports the receiver to the position provided.
- `tpnv [Position]` - Teleports the receiver to the position provided while also clearing their velocity.
- `vel [Velocity]` - Sets the receiver's velocity to the vector provided.
- `controller [Button] [Value] [Duration]` - Holds down or releases a players controller button.
- `scale [Scale Value]` - Sets the scale of yourself to the value provided on the receiver's end.
- `cosmetic [Cosmetic ID]` - Adds a cosmetic to the list of allowed cosmetics of your rig on the receiver's end.
- `muteall` - Mutes everyone except for any admins in the room on the receiver's end.
- `unmuteall` - Unmutes everyone in the room on the receiver's end.
- `mute [Mute Target User ID]` - Mutes the target for the receiver.
- `unmute [Unmute Target User ID]` - Unmutes the target for the receiver.
- `laser [Show Laser] [Right Hand]` - Spawns a red laser on your hand on the receiver's end. It faces down the palm of your hand.
- `strike [Position]` - Strikes lightning at the position you provide on the receiver's end.
- `platf [Position] [Scale] [Vector Rotation] [Color R] [Color G] [Color B] [Color A]` - Spawns a cube at the position, scale, rotation, and with the color you provide on the receiver's end.
- `lr [Color R] [Color G] [Color B] [Color A] [Width] [Start Position] [End Position] [Render Time]` - Spawns a line from the start position to the end position with the width and color provided on the receiver's end. It will destroy after the render time in seconds.
- `asset-spawn [Bundle] [Name] [Index]` - Spawns an asset with the ID specified.
- `asset-destroy [Index]` - Destroys the specified asset.
- `asset-setposition [Index] [Position]` - Sets the position of the specified asset.
- `asset-setlocalposition [Index] [Position]` - Sets the local position of the specified asset.
- `asset-setrotation [Index] [Rotation]` - Sets the rotation of the specified asset.
- `asset-setlocalrotation [Index] [Rotation]` - Sets the local rotation of the specified asset.
- `asset-setscale [Index] [Scale]` - Sets the local scale of the specified asset.
- `asset-setanchor [Index] [Limb] (Player Actor Number)` - Anchors the specified asset to a position on your rig if the actor number is not specified.
- `asset-playanimation [Index] [Object] [Clip Name]` - Plays the specified animation on the specified object in the specified asset.
- `asset-playsound [Index] [Object] (Sound Name)` - Plays a sound / the specified sound on the specified object in the specified asset.
- `asset-settexture [Index] [Object] [Texture URL]` - Sets the texture of the specified object in the specified asset to the specified URL.
- `asset-setsound [Index] [Object] [Sound URL]` - Plays the specified sound from the specified URL on the specified object in the specified asset.
- `asset-setvideo [Index] [Object] [Video URL]` - Plays the specified video from the specified URL on the specified object in the specified asset.

---

## Credits

- Made by **imudtrust**  
- Originally by **goldentrophy & Twigcore**

If you need help contact me on Discord: `imudtrust`
