---
title: "Adding a Submenu to a Menu"
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
  - "context menus"
  - "submenus, cascading"
  - "cascading submenus"
  - "menus, creating cascading submenus"
ms.assetid: 692600cb-d052-40e2-bdae-4354ae7c6c84
caps.latest.revision: 47
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Adding a Submenu to a Menu
This walkthrough builds on the demonstration in [Walkthrough:Adding a Menu to the Visual Studio Menu Bar (C#)](../vs140/adding-a-menu-to-the-visual-studio-menu-bar.md) by showing how to add a submenu to the **TestMenu** menu.  
  
 A submenu is a secondary menu that appears in another menu. A submenu can be identified by the arrow that follows its name. Clicking the name causes the submenu and its commands to be displayed.  
  
 This walkthrough creates a submenu in a menu on the Visual Studio menu bar and puts a new command on the submenu. The walkthrough also implements the new command.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
## Adding a Submenu to a Menu  
  
1.  Follow the steps in [Walkthrough: Adding a Menu to the Visual Studio Menu Bar (C#)](../vs140/adding-a-menu-to-the-visual-studio-menu-bar.md) to create the project and menu item. The steps in this walkthrough assume that the name of the VSIX project is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
2.  Open TestCommandPackage.vsct. In the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> section, add an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element for the submenu, one for the submenu group, and one for the command, all in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> node named "guidTopLevelMenuCmdSet." This is the same node that contains the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> element for the top-level menu.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  Add the newly created submenu to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> section.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     The GUID/ID pair of the parent specifies the menu group that was generated in [Walkthrough:Adding a Menu to the Visual Studio Menu Bar (C#)](../vs140/adding-a-menu-to-the-visual-studio-menu-bar.md), and is a child of the top-level menu.  
  
4.  Add the menu group defined in step 2 to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> section and make it a child of the submenu.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
5.  Add a new <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> element to the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> section to define the command created in step 2 as an item on the submenu.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
6.  Build the solution and start debugging. You should see the experimental instance.  
  
7.  Click **TestMenu** to see a new submenu named **Sub Menu**. Click **Sub Menu** to open the submenu and see a new command, **Test Sub Command**. Notice that clicking **Test Sub Command** does nothing.  
  
## Adding a Command  
  
1.  Open TestCommand.cs and add the following command ID after the existing command ID.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
2.  Add the sub-command. Find the command constructor. Add the following lines just after the call to the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> command handler will be defined later. The constructor should now look like this:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
3.  Add SubItemCallback(). This is the method that is called when the new command in the submenu is clicked.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
4.  Build the project and start debugging. The experimental instance should appear.  
  
5.  On the **TestMenu** menu, click **Sub Menu** and then click **Test Sub Command**. A message box should appear and display the text, "Test Command Inside TestCommand.SubItemCallback()".  
  
## See Also  
 [Creating a Top Level Menu](../vs140/adding-a-menu-to-the-visual-studio-menu-bar.md)   
 [Menu and Toolbar Commands](../vs140/commands--menus--and-toolbars.md)