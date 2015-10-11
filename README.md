# Updatify
Simple Windows .Net Updater 


# Flow

MainApp runs updater--->updater checks for updates to itself:

If update found for updater:

Run daemon--->daemon closes updater--->downloads update to updater and updates it-->opens updater and closes itself.

Updater agains check for updates

if no update found for updater:

Asks user to close main app-->Downloads updates for main app-->updates main app-->opens main app-->closes itself.

# Daemon

This never updates, use a url path to somewhere you know might not change for a VERY long time, such as your personal website.

#IMPORTANT File version (Main app and updater)

On your server create a text file e.g version.txt with the version of your application e.g 1.0.0.0, when you update your application remember to update the file version and assembly version. App properties-->assembly information-->update assembly and file version. This is how your app will know there is an update. Once you have finished uploading your new update, change the version of the version.txt on your server e.g 1.0.0.1. When "Check for updates" is clicked, it will see that the version number of the version.txt changed; it will download the update.

# Knowning when files changed from your previous Update

By default the app does no hashchecking on it's own...it simply overwrites if it finds a file with same name. So how do you know which files have changed from your previous update?

Nirsoft comes to the rescue again with a great app: http://www.nirsoft.net/utils/hash_my_files.html

Check the hash of your app files with the ones previously released in an update. All additional files should just be added obviously.

If your app is in a git repo...you could use that too.


