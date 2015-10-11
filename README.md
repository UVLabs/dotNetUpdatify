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

# Knowning while files changed from your previous Update

By default the app does no hashchecking on it's own...it simply overwrites if it finds a file with same name. So how do you know which files have changed from your previous update?

Nirsoft comes to the rescue again with a great app: http://www.nirsoft.net/utils/hash_my_files.html

Check the hash of your app files with the ones previously released in an update. All additional files should just be added obviously.

If your app is in a git repo...you could use that too.
