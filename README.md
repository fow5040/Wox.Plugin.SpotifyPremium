Wox.Plugin.SpotifyPremium
==================

Spotify plugin for the [Wox launcher](https://github.com/Wox-launcher/Wox)

### About

Control your Spotify client from Wox. Search for tracks, artists, or albums and launch the results directly to your client.
This plugin requires the use of the Spotify Web API, which is only accessible through Spotify Premium

![image](http://i.imgur.com/AfUkPvd.gif)

### Usage
| Keyword                            | Description                   |
| ---------------------------------- | ----------------------------- |
| `` sp ``                           | Show currently playing track  |
| `` sp {spotify search query} ``    | Search all of Spotify         |
| `` sp track {track name} ``        | Search for a track            |
| `` sp artist {artist name} ``      | Search for an artist          |
| `` sp album {album name} ``        | Search for an album           |
| `` sp playlist {playlist name} ``  | Search personal playlists     |
| `` sp queue {track name} ``        | Search for track and queue it |
| `` sp next ``                      | Play next track               |
| `` sp last ``                      | Play previous track           |
| `` sp play ``                      | Resume currently playing track|
| `` sp pause ``                     | Pause currently playing track |
| `` sp mute ``                      | Toggle Mute                   |
| `` sp volume ``                    | Set Volume (1-100)            |
| `` sp device ``                    | Set Active Device             |
| `` sp shuffle ``                   | Toggle Shuffle Mode           |
| `` sp reconnect ``                 | Force a full reconnection     |

### Notice
- Spotify relies on Web Authentication Calls to Connect to the API remotely - you will need to authorize it to use this plugin
- **You _NEED_ a client secret and client ID to use this plugin!**
    - This app currently hardcodes my personal Client ID and Client Secret to interact with Spotify. If current app usage hits any API limits, naturally you will need to switch out the current Client ID and Secret
    - To use a custom ID/Secret, create a file called security.store in _%localAppData%\Wox\app-1.3.578\Plugins\Wox.Plugin.SpotifyPremium\security.store_ with the following format:
    ```
    {"ClientID":"yourClientSecret","ClientSecret":"yourClientSecret"}
    ```
    - To generate a key pair, navigate to ``https://developer.spotify.com/dashboard/``, login, and generate your own ID & Key
    - After generating a key pair, under "edit settings", add `http://localhost:4002/callback` as a Redirect URI
- This plugin cannot currently search for Podcasts - this is due to a restructure of the Spotify API which enabled support for "FullEpisode", among other things. See the [SpotifyAPI-NET Documentation](https://johnnycrazy.github.io/SpotifyAPI-NET/docs/iplayableitem) for more information.
- The Spotify queue API currently only supports adding single tracks to queues, not albums, even though the player can add albums, etc.
- Set Wox Maximum Results Shown to 12 or higher for best results

### Development
- To get started developing:
    - Restore all NuGet dependencies (dotnet restore)
    - Run build script (visual studio code > Run Build Task)

### Third-Party Libraries

- [SpotifyAPI-NET](https://github.com/JohnnyCrazy/SpotifyAPI-NET) : Spotify API wrapper
- [Json.Net](https://github.com/JamesNK/Newtonsoft.Json) : High performance json library

## To Do - Ideas

- Search user content (saved music)
- Configurable default search type
- Add configuration menu
    - Would really like a config menu for people to put their own app ID/Secrets
- Enable full integration with API - including "Episode" and podcast control

### Reminder Section - because I'm forgetful
#### _"Release"_ steps
- Bump version number in `plugin.json`
- `dotnet build --configuration Release`
- zip up contents of bin/Release as <something>.wox
- Upload 
