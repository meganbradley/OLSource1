---
title: "Adding a Menu Controller to a Toolbar"
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
  - "toolbars [Visual Studio], adding menu controllers"
  - "menus, adding menu controllers to toolbars"
  - "menu controllers, adding to toolbars"
ms.assetid: 6af9b0b4-037f-404c-bb40-aaa1970768ea
caps.latest.revision: 42
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Adding a Menu Controller to a Toolbar
This walkthrough builds on the [Adding a Toolbar to a Tool Window](../vs140/adding-a-toolbar-to-a-tool-window.md) walkthrough and shows how to add a menu controller to the tool window toolbar. The steps shown here also can be applied to the toolbar that is created in the [Adding a Toolbar](../vs140/adding-a-toolbar.md) walkthrough.  
  
 A menu controller is a split control. The left side of the menu controller shows the last-used command, and it can be run by clicking it. The right side of the menu controller is an arrow that, when clicked, opens a list of additional commands. When you click a command on the list, the command runs, and it replaces the command on the left side of the menu controller. In this way, the menu controller operates like a command button that always shows the last-used command from a list.  
  
 Menu controllers can appear on menus but they are most often used on toolbars.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
## Creating a Menu Controller  
  
#### To create a menu controller  
  
1.  Follow the procedures described in [Adding a Toolbar to a Tool Window](../vs140/adding-a-toolbar-to-a-tool-window.md) to create a tool window that has a toolbar.  
  
2.  In TWTestCommandPackage.vsct, go to the Symbols section. In the GuidSymbol element named **guidTWTestCommandPackageCmdSet**, declare your menu controller, menu controller group, and three menu items.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  In the Menus section, after the last menu entry, define the menu controller as a menu.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> flags must be included to enable the menu controller to reflect the last selected command.  
  
4.  In the Groups section, after the last group entry, add the menu controller group.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     By setting the menu controller as the parent, any commands placed in this group will appear in the menu controller. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute is omitted, which sets it to the default value of 0, because it will be the only group on the menu controller.  
  
5.  In the Buttons section, after the last button entry, add a Button element for each of your menu items.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
6.  At this point, you can look at the menu controller. Build the project and start debugging. You should see the experimental instance.  
  
    1.  On the **View / Other Windows** menu, open **Test ToolWindow**.  
  
    2.  The menu controller appears on the toolbar in the tool window.  
  
    3.  Click the arrow on the right-hand side of the menu controller to see the three possible commands.  
  
     Notice that when you click a command, the title of the menu controller changes to display that command. In the next section, we will add the code to activate these commands.  
  
## Implementing the Menu Controller Commands  
  
1.  In TWTestCommandPackageGuids.cs, add command IDs for your three menu items after the existing command IDs.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
2.  In TWTestCommand.cs, add the following code at the top of the TWTestCommand class.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
3.  In the TWTestCommand constructor, after the last call to the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method, add code to route the events for each command through the same handlers.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
4.  Add an event handler to the TWTestCommand class to mark the selected command as checked.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
5.  Add an event handler that displays a MessageBox when the user selects a command on the menu controller:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## Testing the Menu Controller  
  
1.  Build the project and start debugging. You should see the experimental instance.  
  
2.  Open the **Test ToolWindow** on the **View / Other Windows** menu.  
  
     The menu controller appears in the toolbar in the tool window and displays **MC Item 1**.  
  
3.  Click the menu controller button to the left of the arrow.  
  
     You should see three items, the first of which is selected and has a highlight box around its icon. Click **MC Item 3**.  
  
     A dialog box appears with the message **You selected Menu controller Item 3**. Notice that the message corresponds to the text on the menu controller button. The menu controller button now displays **MC Item 3**.  
  
## See Also  
 [Adding a Toolbar to a Tool Window](../vs140/adding-a-toolbar-to-a-tool-window.md)   
 [Adding a Toolbar to the IDE](../vs140/adding-a-toolbar.md)