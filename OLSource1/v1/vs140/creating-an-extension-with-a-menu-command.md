---
title: "Creating an Extension with a Menu Command"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "write a vspackage"
  - "vspackage"
  - "tutorials"
  - "visual studio package"
ms.assetid: f97104c8-2bcb-45c7-a3c9-85abeda8df98
caps.latest.revision: 60
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Creating an Extension with a Menu Command
This walkthrough shows how to create an extension with a menu command that launches Notepad.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
## Creating a Menu Command  
  
1.  Create a VSIX project named **FirstMenuCommand**. You can find the VSIX project template in the **New Project** dialog under **Visual C# / Extensibility**.  
  
2.  When the project opens, add a custom command item template named **FirstCommand**. In the **Solution Explorer**, right-click the project node and select **Add / New Item**. In the **Add New Item** dialog, go to **Visual C# / Extensibility** and select **Custom Command**. In the **Name** field at the bottom of the window, change the command file name to **FirstCommand.cs**.  
  
3.  Build the project and start debugging.  
  
     The experimental instance of Visual Studio appears. For more information about the experimental instance, see [The Experimental Instance](../vs140/the-experimental-instance.md).  
  
4.  In the experimental instance, open the  **Tools / Extensions and Updates** window. You should see the **FirstMenuCommand** extension here. (If you open **Extensions and Updates** in your working instance of Visual Studio, you won’t see **FirstMenuCommand**).  
  
     Now go to the **Tools** menu in the experimental instance. You should see **Invoke FirstCommand** command. At this point it just brings up a message box that says “FirstCommandPackage Inside FirstMenuCommand.FirstCommand.MenuItemCallback()”. We’ll see how to actually start Notepad from this command in the next section.  
  
## Changing the Menu Command Handler  
 Now let’s update the command handler to start Notepad.  
  
1.  Stop debugging and go back to your working instance of Visual Studio. Open the FirstCommand.cs file and add the following using statement:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Find the private FirstCommand constructor. This is where the command is hooked up to the command service and the command handler is specified. Change the name of the command handler to StartNotepad, as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
3.  Remove the MenuItemCallback method and add a StartNotepad method which will just start Notepad:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
4.  Now try it out. When you start debugging the project and click **Tools / Invoke FirstCommand**, you should see an instance of Notepad come up.  
  
     You can use an instance of the \<xref:System.Diagnostics.Process*> class to run any executable, not just Notepad. Try it with calc.exe, for example.  
  
## Cleaning up the Experimental Environment  
 If you are developing multiple extensions, or just exploring outcomes with different versions of your extension code, your experimental environment may stop working the way it should. In this case, you should run the reset script. It’s called **Reset the Visual Studio 2015 Experimental Instance**, and it ships as part of the Visual Studio SDK. This script removes all references to your extensions from the experimental environment, so you can start from scratch.  
  
 You can get to this script in one of two ways:  
  
1.  From the desktop, find **Reset the Visual Studio 2015 Experimental Instance**.  
  
2.  From the command line, run the following:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Deploying your extension  
 Now that you have your tool extension running the way you want, it’s time to think about sharing it with your friends and colleagues. That’s easy, as long as they have Visual Studio 2015 installed. All you have to do is send them the .vsix file you built. (Be sure to build it in Release mode.)  
  
 You can find the .vsix file for this extension in the FirstMenuCommand bin directory. Specifically, assuming you have built the Release configuration, it will be in:  
  
 **\<code directory>\FirstMenuCommand\FirstMenuCommand\bin\Release\ FirstMenuCommand.vsix**  
  
 To install the extension, your friend needs to close all open instances of Visual Studio, then double-click the .vsix file, which brings up the **VSIX Installer**. The files are copied to the **%LocalAppData%\Microsoft\VisualStudio\14.0\Extensions** directory.  
  
 When your friend brings up Visual Studio again, he’ll find the FirstMenuCommand extension in **Tools / Extensions and Updates**. He can go to **Extensions and Updates** to uninstall or disable the extension, too.  
  
## Next Steps  
 This walkthrough has shown you only a small part of what you can do with a Visual Studio extension. Here’s a short list of other (reasonably easy) things you can do with Visual Studio extensions:  
  
1.  You can do many more things with a simple menu command:  
  
    1.  Add your own icon: [Adding Icons to Menu Commands](../vs140/adding-icons-to-menu-commands.md)  
  
    2.  Change the text of the menu command: [Changing the Text of a Menu Command](../vs140/changing-the-text-of-a-menu-command.md)  
  
    3.  Add a menu shortcut to a command: [Binding Keyboard Shortcuts to Commands](../vs140/binding-keyboard-shortcuts-to-menu-items.md)  
  
2.  Add different kinds of commands, menus, and toolbars: [Extending Menus, Commands, and Toolbars](../vs140/extending-menus-and-commands.md)  
  
3.  Add tool windows and extend the built-in Visual Studio tool windows: [Extending and Customizing Tool Windows](../vs140/extending-and-customizing-tool-windows.md)  
  
4.  Add IntelliSense, code suggestions, and other features to existing code editors: [Extending the Editor](../vs140/extending-the-editor-and-language-services.md)  
  
5.  Add Options and Property pages and user settings to your extension: [Extending Properties and the Property Window](../vs140/extending-properties-and-the-property-window.md) and [Extending User Settings and Options](../vs140/extending-user-settings-and-options.md)  
  
 Other kinds of extensions require a little more work, such as creating a new type of project ([Extending Projects and Solutions](../vs140/extending-projects.md)), creating a new type of editor ([Creating Custom Editors and Designers](../vs140/creating-custom-editors-and-designers.md)), or implementing your extension in an isolated shell: [Visual Studio Isolated Shell](../vs140/visual-studio-isolated-shell.md)