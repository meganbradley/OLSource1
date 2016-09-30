---
title: "Adding a Toolbar to a Tool Window"
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
  - "tool windows, adding toolbars"
  - "toolbars [Visual Studio], adding to tool windows"
ms.assetid: 172f64b3-87f8-4292-9c1c-65bffa2b0970
caps.latest.revision: 52
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Adding a Toolbar to a Tool Window
This walkthrough shows how to add a toolbar to a tool window.  
  
 A toolbar is a horizontal or vertical strip that contains buttons bound to commands. The length of a toolbar in a tool window is always the same as the width or height of the tool window, depending on where the toolbar is docked.  
  
 Unlike toolbars in the IDE, a toolbar in a tool window must be docked and cannot be moved or customized. If the VSPackage is written in umanaged code, the toolbar can be docked on any edge.  
  
 For more information about how to add a toolbar, see [Walkthrough: Adding a Toolbar](../vs140/adding-a-toolbar.md).  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
## Creating a Toolbar for a Tool Window  
  
1.  Create a VSIX project named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that has both a menu command named **TWTestCommand** and a tool window named **TestToolWindow**. For more information, see [Creating an Extension with a Menu Command](../vs140/creating-an-extension-with-a-menu-command.md) and [Creating an Extension with a Tool Window](../vs140/creating-an-extension-with-a-tool-window.md). You need to add the command item template before adding the tool window template.  
  
2.  In TWTestCommandPackage.vsct, look for the Symbols section. In the GuidSymbol node named guidTWTestCommandPackageCmdSet declare a toolbar and a toolbar group, as follows.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  At the top of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> section, create a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> section. Add a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element to define the toolbar.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     Toolbars cannot be nested like submenus. Therefore, you do not have to assign a parent. Also, you do not have to set a priority, because the user can move toolbars. Typically, initial placement of a toolbar is defined programmatically, but subsequent changes by the user are persisted.  
  
4.  In the Groups section, define a group to contain the commands for the toolbar.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
5.  In the Buttons section, change the parent of the existing Button element to the toolbar group so that the toolbar will be displayed.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     By default, if a toolbar has no commands, it does not appear.  
  
     Because the new toolbar is not automatically added to the tool window, the toolbar must be added explicitly. This is discussed in the next section.  
  
## Adding the Toolbar to the Tool Window  
  
1.  In TWTestCommandPackageGuids.cs add the following lines.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
2.  In TestToolWindow.cs add the following using statement.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
3.  In the TestToolWindow constructor add the following line.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Testing the Toolbar in the Tool Window  
  
1.  Build the project and start debugging. The Visual Studio experimental instance should appear.  
  
2.  On the **View / Other Windows** menu, click **Test ToolWindow** to display the tool window.  
  
     You should see a toolbar (it looks like the default icon) at the top left of the tool window, just below the title.  
  
3.  On the toolbar, click the icon to display the message **TWTestCommandPackage Inside TWToolbar.TWTestCommand.MenuItemCallback()**.  
  
## See Also  
 [Adding a Toolbar to the IDE](../vs140/adding-a-toolbar.md)