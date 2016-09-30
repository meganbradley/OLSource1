---
title: "Dynamically Adding Menu Items"
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
  - "DYNAMICITEMSTART"
  - "menu items, adding dynamically"
  - "menus, adding dynamic items"
ms.assetid: d281e9c9-b289-4d64-8d0a-094bac6c333c
caps.latest.revision: 41
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Dynamically Adding Menu Items
You can add menu items at run time by specifying the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> command flag on a placeholder button definition in the Visual Studio command-table (.vsct) file, then defining (in code) the number of menu items to display and handling the command(s). When the VSPackage is loaded, the placeholder is replaced with the dynamic menu items.  
  
 Visual Studio uses dynamic lists in the **Most Recently Used** (MRU) list, which displays the names of documents that have been opened recently, and the **Windows** list, which displays the names of windows that are currently open.   The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> flag on a command definition specifies that the command is a placeholder until the VSPackage is opened. When the VSPackage is opened, the placeholder is replaced with 0 or more commands that are created at run time and added to the dynamic list. You may not be able to see the position on the menu where the dynamic list appears until the VSPackage is opened.  To populate the dynamic list, Visual Studio asks the VSPackage to look for a command with an ID whose first characters are the same as the ID of the placeholder. When Visual Studio finds a matching command, it adds the name of the command  to the dynamic list. Then it increments the ID and looks for another matching command to add to the dynamic list until there are no more dynamic commands.  
  
 This walkthrough shows how to set the startup project in a Visual Studio solution with a command on the **Solution Explorer** toolbar. It uses a menu controller that has a dynamic dropdown list of the projects in the active solution. To keep this command from appearing when no solution is open or when the open solution has only one project, the VSPackage is loaded only when a solution has multiple projects.  
  
 For more information about .vsct files, see [XML-Based Command Table Configuration (.vsct) Files](../vs140/visual-studio-command-table--.vsct--files.md).  
  
## Creating an Extension with a Menu Command  
  
1.  Create a VSIX project named <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
2.  When the project opens, add a custom command item template and name it **DynamicMenu**. For more information, see [Creating a VSPackage with a Menu Command](../vs140/creating-an-extension-with-a-menu-command.md).  
  
## Setting up the elements in the .vsct file  
 To create a menu controller with dynamic menu items on a toolbar, you specify the following elements:  
  
-   Two command groups, one that contains the menu controller and another that contains the menu items in the dropdown  
  
-   One menu element of type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
-   Two buttons, one that acts as the placeholder for the menu items and another that supplies the icon and the tooltip on the toolbar.  
  
1.  In DynamicMenuPackage.vsct, define the command IDs. Go to the Symbols section and replace the IDSymbol elements in the **guidDynamicMenuPackageCmdSet** GuidSymbol block. You need to define IDSymbol elements for the two groups, the menu controller, the placeholder command, and the anchor command.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  In the Groups section, delete the existing groups and add the two groups you just defined:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     Add the MenuController. Set the DynamicVisibility command flag, since it is not always visible. The ButtonText is not displayed.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
3.  Add two buttons, one as a placeholder for the dynamic menu items and one as an anchor for the MenuController.  
  
     The parent of the placeholder button is the **MyMenuControllerGroup**. Add the DynamicItemStart, DynamicVisibility, and TextChanges command flags to the placeholder button. The ButtonText is not displayed.  
  
     The anchor button holds the icon and the tooltip text. The parent of the anchor button is also the **MyMenuControllerGroup**. You add the NoShowOnMenuController command flag to make sure the button doesn’t actually appear in the menu controller dropdown, and the FixMenuController command flag to make it the permanent anchor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
4.  Add an icon to the project (in the Resources folder), and then add the reference to it in the .vsct file. In this walkthrough, we use the Arrows icon that's included in the project template.  
  
5.  Add a VisibilityConstraints section outside the Commands section just before the Symbols section. (You may get a warning if you add it after Symbols.) This section makes sure that the menu controller appears only when a solution with multiple projects is loaded.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Implementing the dynamic menu command  
 You create a dynamic menu command class that inherits from \<xref:Microsoft.VisualStudio.Shell.OleMenuCommand*>. In this implementation, the constructor specifies a predicate to be used for matching commands. You must override the \<xref:Microsoft.VisualStudio.Shell.OleMenuCommand.DynamicItemMatch*> method to use this predicate to set the \<xref:Microsoft.VisualStudio.Shell.OleMenuCommand.MatchedCommandId*> property, which identifies the command to be invoked.  
  
1.  Create a new C# class file named DynamicItemMenuCommand.cs, and add a class named **DynamicItemMenuCommand** that inherits from \<xref:Microsoft.VisualStudio.Shell.OleMenuCommand*>:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
2.  Add the following using statements:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
3.  Add a private field to store the match predicate:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
4.  Add a constructor that inherits from the \<xref:Microsoft.VisualStudio.Shell.OleMenuCommand*> constructor and specifies a command handler and a \<xref:Microsoft.VisualStudio.Shell.OleMenuCommand.BeforeQueryStatus*> handler. Add a predicate for matching the command:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
5.  Override the \<xref:Microsoft.VisualStudio.Shell.OleMenuCommand.DynamicItemMatch*> method so that it calls the matches predicate and sets the \<xref:Microsoft.VisualStudio.Shell.OleMenuCommand.MatchedCommandId*> property:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## Adding the command  
 The DynamicMenu constructor is where you set up menu commands, including dynamic menus and menu items.  
  
1.  In DynamicMenuPackageGuids.cs, add the GUID of the command set and the command ID:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
2.  In the DynamicMenu.cs file, add the following using statements:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
3.  In the DynamicMenu class, add a private field **dte2**.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
4.  Add a private rootItemId field:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
5.  In the DynamicMenu constructor, add the menu command. In the next section we'll define the command handler, the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> event handler, and the match predicate.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
## Implementing the handlers  
 To implement dynamic menu items on a menu controller, you must handle the command when a dynamic item is clicked. You must also implement the logic that sets the state of the menu item. Add the handlers to the DynamicMenu class.  
  
1.  To implement the **Set Startup Project** command, add the **OnInvokedDynamicItem** event handler. It looks for the project whose name is the same as the text of the command that has been invoked, and sets it as the startup project by setting its absolute path in the \<xref:EnvDTE.SolutionBuild.StartupProjects*> property.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
2.  Add the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> event handler. This is the handler called before a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> event. It determines whether the menu item is a “real” item, that is, not the placeholder item, and whether the item is already checked (meaning that the project is already set as the startup project).  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
## Implementing the command ID match predicate  
  
1.  Now implement the match predicate. We need to determine two things: first, whether the command ID is valid (it is greater than or equal to the declared command ID), and second, whether it specifies a possible project (it is less than the number of projects in the solution).  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
## Setting the VSPackage to load only when a solution has multiple projects  
 Because the **Set Startup Project** command doesn’t make sense unless the active solution has more than one project, you can set your VSPackage to auto-load only in that case. You use \<xref:Microsoft.VisualStudio.Shell.ProvideAutoLoadAttribute*> together with the UI context \<xref:Microsoft.VisualStudio.Shell.Interop.UIContextGuids.SolutionHasMultipleProjects*>. In the DynamicMenuPackage.cs file add the following attributes to the DynamicMenuPackage class:  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
## Testing the Set Startup Project command  
 Now you can test your code.  
  
1.  Build the project and start debugging. The experimental instance should appear.  
  
2.  In the experimental instance, open a solution that has more than one project.  
  
     You should see the arrow icon on the **Solution Explorer** toolbar. When you expand it, menu items that represent the different projects in the solution should appear.  
  
3.  When you check one of the projects, it becomes the startup project.  
  
4.  When you close the solution, or open a solution that has only one project, the toolbar icon should disappear.  
  
## See Also  
 [Menu and Toolbar Commands](../vs140/commands--menus--and-toolbars.md)   
 [How VSPackages Contribute User Interface Elements](../vs140/how-vspackages-add-user-interface-elements.md)