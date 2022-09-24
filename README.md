# Load Accelerator
Made by [gnog#2259](https://discord.com/users/487609645549223941)

## Installation
### Without `git` CLI

*   Press the `code` button at the top of the github page and `Download ZIP`

*   Open File Explorer and navigate to game folder  
    Windows Default: `C:\Program Files (x86)\Steam\steamapps\common\Logic World\GameData`  
    Mac Default: `~/Library/Application Support/Steam/steamapps/common/Logic World/GameData`  
    Linux Default: `cd "~/.local/share/Steam/steamapps/common/Logic World/GameData"`

*   Extract the ZIP file we retrieved from the first step, into the folder we navigated to.

*   Open Game and enjoy!.

### With `git` CLI

*   In a terminal: Navigate to game folder  
    Windows Default: `dir "C:\Program Files (x86)\Steam\steamapps\common\Logic World"`  
    Mac Default: `cd "~/Library/Application Support/Steam/steamapps/common/Logic World"`  
    Linux Default: `cd "~/.local/share/Steam/steamapps/common/Logic World"`

*   Run
    ```sh
    # Windows
    git clone https://github.com/LogicWorld-Mod-Repository/gnog-loadaccelerator.git;
    rm -r gnog-loadaccelerator/.git;
    move gnog-loadaccelerator GameData

    # Mac/Linux
    git clone https://github.com/LogicWorld-Mod-Repository/gnog-loadaccelerator.git;
    rm -rf gnog-loadaccelerator/.git;
    mv gnog-loadaccelerator/ GameData
	```

*   Open Game and enjoy!.