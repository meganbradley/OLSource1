---
title: "Adding a Most Recently Used List to a Submenu"
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
  - "MRU lists"
  - "menus, creating MRU list"
  - "most recently used"
ms.assetid: 27d4bbcf-99b1-498f-8b66-40002e3db0f8
caps.latest.revision: 50
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Adding a Most Recently Used List to a Submenu
This walkthrough builds on the demonstrations in [Walkthrough: Creating a Cascading Submenu](../vs140/adding-a-submenu-to-a-menu.md), and shows how to add a dynamic list to a submenu. The dynamic list forms the basis for creating a Most Recently Used (MRU) list.  
  
 A dynamic menu list starts with a placeholder on a menu. Every time the menu is shown, the Visual Studio integrated development environment (IDE) asks the VSPackage for all commands that should be shown at the placeholder. A dynamic list can occur anywhere on a menu. However, dynamic lists are typically stored and displayed by themselves on submenus or at the bottoms of menus. By using these design patterns, you enable the dynamic list of commands to expand and contract without affecting the position of other commands on the menu. In this walkthrough, the dynamic MRU list is displayed at the bottom of an existing submenu, separated from the rest of the submenu by a line.  
  
 Technically, a dynamic list can also be applied to a toolbar. However, we discourage that usage because a toolbar should remain unchanged unless the user takes specific steps to change it.  
  
 This walkthrough creates an MRU list of four items that change their order every time that one of them is selected (the selected item moves to the top of the list).  
  
 For more information about menus and .vsct files, see [Menu and Toolbar Commands](../vs140/commands--menus--and-toolbars.md).  
  
## Prerequisites  
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio Software Development Kit (SDK)](../vs140/visual-studio-sdk.md).  
  
## Creating an Extension  
  
-   Follow the procedures in [Walkthrough: Creating a Cascading Submenu](../vs140/adding-a-submenu-to-a-menu.md) to create the submenu that is modified in the following procedures.  
  
 The procedures in this walkthrough assume that the name of the VSPackage is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, which is the name that is used in [Walkthrough: Creating a Top Level Menu](../vs140/adding-a-menu-to-the-visual-studio-menu-bar.md).  
  
## Creating a Dynamic Item List Command  
  
1.  Open TestCommandPackage.vsct.  
  
2.  In the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> section, in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> node named guidTestCommandPackageCmdSet, add the symbol for the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> group and the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> command, as follows.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  In the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> section, add the declared group after the existing group entries.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
4.  In the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> section, add a node to represent the newly declared command, after the existing button entries.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> flag enables the command to be generated dynamically.  
  
5.  Build the project and start debugging to test the display of the new command.  
  
     On the **TestMenu** menu, click the new submenu, **Sub Menu**, to display the new command, **MRU Placeholder**. After a dynamic MRU list of commands is implemented in the next procedure, this command label will be replaced by that list every time that the submenu is opened.  
  
## Filling the MRU List  
  
1.  In TestCommandPackageGuids.cs, add the following lines after the existing command IDs in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class definition.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
2.  In TestCommand.cs add the following using statement.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
3.  Add the following code in the TestCommand constructor after the last AddCommand call. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> will be defined later  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
4.  Add the following code in the TestCommand class. This code initializes the list of strings that represent the items to be shown on the MRU list.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
5.  After the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> method, add the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method. This initializes the MRU list menu commands.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
     You must create a menu command object for every possible item in the MRU list. The IDE calls the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method for each item in the MRU list until there are no more items. In managed code, the only way for the IDE to know that there are no more items is to create all possible items first. If you want, you can mark additional items as not visible at first by using <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> after the menu command is created. These items can then be made visible later by using <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method.  
  
6.  After the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> method, add the following <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> method. This is the handler that sets the text for each MRU item.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
7.  After the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> method, add the following <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> method. This is the handler for selecting an MRU item. This method moves the selected item to the top of the list and then displays the selected item in a message box.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## Testing the MRU List  
  
#### To test the MRU menu list  
  
1.  Build the project and start debugging  
  
2.  On the **TestMenu** menu, click **Invoke TestCommand**. Doing this displays a message box that indicates that the command was selected.  
  
    > [!NOTE]
    >  This step is required to force the VSPackage to load and correctly display the MRU list. If you skip this step, the MRU list is not displayed.  
  
3.  On the **Test Menu** menu, click **Sub Menu**. A list of four items is displayed at the end of the submenu, below a separator. When you click **Item 3**, a message box should appear and display the text, "Selected Item 3". (If the list of four items is not displayed, ensure that you have followed the instructions in the earlier step.)  
  
4.  Open the submenu again. Notice that **Item 3** is now at the top of the list and the other items have been pushed down one position. Click **Item 3** again and notice that the message box still displays "Selected Item 3", which indicates that the text has correctly moved to the new position together with the command label.  
  
## See Also  
 [How to: Dynamically Add Menu Items](../vs140/dynamically-adding-menu-items.md)