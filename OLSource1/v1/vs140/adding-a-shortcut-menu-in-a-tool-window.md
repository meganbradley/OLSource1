---
title: "Adding a Shortcut Menu in a Tool Window"
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
  - "context menus, adding to tool windows"
  - "menus, context menus"
  - "shortcut menus, adding to tool windows"
  - "tool windows, adding context menus"
ms.assetid: 50234537-9e95-4b7e-9cb7-e5cf26d6e9d2
caps.latest.revision: 41
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Adding a Shortcut Menu in a Tool Window
This walkthrough puts a shortcut menu in a tool window. A shortcut menu is a menu that appears when a user right-clicks a button, text box, or window background. Commands on a shortcut menu behave the same as commands on other menus or toolbars. To support a shortcut menu, specify it in the .vsct file and display it in response to the right-click of the mouse.  
  
 A tool window consists of a WPF user control in a custom tool window class that inherits from \<xref:Microsoft.VisualStudio.Shell.ToolWindowPane*>.  
  
 This walkthrough shows how to create a shortcut menu as a Visual Studio menu, by declaring menu items in the .vsct file, and then using the Managed Package Framework to implement them in the class that defines the tool window. This approach facilitates access to Visual Studio commands, UI elements, and the Automation object model.  
  
 Alternatively, if your shortcut menu will not access Visual Studio functionality, you can use the \<xref:System.Windows.FrameworkElement.ContextMenu*> property of a XAML element in the user control. For more information, see [ContextMenu](assetId:///2f40b2bb-b702-4706-9fc4-10bcfd7cc35d).  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
## Creating the Tool Window Shortcut Menu Package  
  
1.  Create a VSIX project named <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and add a tool window template named **ShortCutMenu** to it. For more information about creating a tool window, see [Creating an Extension with a Tool Window](../vs140/creating-an-extension-with-a-tool-window.md).  
  
## Specifying the Shortcut Menu  
 A shortcut menu such as the one shown in this walkthrough lets the user select from a list of colors that are used to fill the background of the tool window.  
  
1.  In ShortcutMenuPackage.vsct, find in the GuidSymbol element named guidShortcutMenuPackageCmdSet, and declare the shortcut menu, shortcut menu group, and menu options. The GuidSymbol element should now look like this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Just before the Buttons element, create a Menus element and then define the shortcut menu in it.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     A shortcut menu does not have a parent because it is not part of a menu or toolbar.  
  
3.  Create a Groups element with a Group element that contains the shortcut menu items, and associate the group with the shortcut menu.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
4.  In the Buttons element, define the individual commands that will appear on the shortcut menu. The Buttons element should look like this:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
5.  In ShortcutMenuPackageGuids.cs, add the definitions for the command set GUID, the shortcut menu, and the menu items.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     These are the same command IDs that are defined in the Symbols section of the ShortcutMenuPackage.vsct file. The context group is not included here because it is required only in the .vsct file.  
  
## Implementing the Shortcut Menu  
 This section implements the shortcut menu and its commands.  
  
1.  In ShortcutMenu.cs, the tool window can get the menu command service, but the control it contains cannot. The following steps show how to make the menu command service available to the user control.  
  
2.  In ShortcutMenu.cs, add the following using statements:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
3.  Override the tool window’s Initialize() method to get the menu command service and add the control, passing the menu command service to the contructor:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
4.  In the ShortcutMenu tool window constructor, remove the line that adds the control. The constructor should now look like this:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
5.  In ShortcutMenuControl.xaml.cs, add a private field for the menu command service and change the control constructor to take the menu command service. Then use the menu command service to add the context menu commands. The ShortcutMenuControl constructor should now look like the following code. The command handler will be defined later.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
6.  In ShortcutMenuControl.xaml, add a \<xref:System.Windows.UIElement.MouseRightButtonDown*> event to the top level \<xref:System.Windows.Controls.UserControl*> element. The XAML file should now look like this:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
7.  In ShortcutMenuControl.xaml.cs, add a stub for the event handler.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
8.  Add the following using statements to the same file:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
9. Implement the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> event as follows.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
     This creates a \<xref:System.ComponentModel.Design.CommandID*> object for the shortcut menu, identifies the location of the mouse click, and opens the shortcut menu in that location by using the \<xref:Microsoft.VisualStudio.Shell.OleMenuCommandService.ShowContextMenu*> method.  
  
10. Implement the command handler.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
     In this case, just one method handles events for all of the menu items by identifying the \<xref:System.ComponentModel.Design.CommandID*> and setting the background color accordingly. If the menu items had contained unrelated commands, you would have created a separate event handler for each command.  
  
## Testing the Tool Window Features  
  
1.  Build the project and start debugging. The experimental instance appears.  
  
2.  In the experimental instance, click **View / Other Windows**, and then click **ShortcutMenu**. Doing this should display your tool window.  
  
3.  Right-click in the body of the tool window. A shortcut menu that has a list of colors should be displayed.  
  
4.  Click a color on the shortcut menu. The tool window background color should be changed to the selected color.  
  
## See Also  
 [Menu and Toolbar Commands](../vs140/commands--menus--and-toolbars.md)   
 [Services](../vs140/using-and-providing-services.md)