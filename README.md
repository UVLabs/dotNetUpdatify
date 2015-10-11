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


