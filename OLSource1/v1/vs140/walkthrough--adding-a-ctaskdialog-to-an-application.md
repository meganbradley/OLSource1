---
title: "Walkthrough: Adding a CTaskDialog to an Application"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTaskDialog, adding"
  - "walkthroughs [C++], dialogs"
ms.assetid: 3a62abb8-2d86-4bec-bdb8-5784d5f9a9f8
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Adding a CTaskDialog to an Application
This walkthrough introduces the [CTaskDialog Class](../vs140/ctaskdialog-class.md) and shows you how to add one to your application.  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a task dialog box that replaces the Windows message box in [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> improves the original message box and adds functionality. The Windows message box is still supported in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
> [!NOTE]
>  Versions of Windows earlier than [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] do not support the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. You must program an alternative dialog box option if you want to show a message to a user who runs your application on an earlier version of Windows. You can use the static method [CTaskDialog::IsSupported](../vs140/ctaskdialog--issupported.md) to determine at run time whether a user's computer can display a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. In addition, the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is only available when your application is built with the Unicode library.  
  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> supports several optional elements to gather and display information. For example, a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> can display command links, customized buttons, customized icons, and a footer. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> also has several methods that enable you to query the state of the task dialog box to determine what optional elements the user selected.  
  
## Prerequisites  
 You need the following components to complete this walkthrough:  
  
-   [!INCLUDE[vs_dev10_long](../vs140/includes/vs_dev10_long_md.md)]  
  
-   [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]  
  
## Replacing a Windows Message Box with a CTaskDialog  
 The following procedure demonstrates the most basic use of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, which is to replace the Windows message box. This example also changes the icon associated with the task dialog box. Changing the icon makes the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> appear identical to the Windows message box.  
  
#### To Replace a Windows Message Box with a CTaskDialog  
  
1.  Create a new MFC Application project with the default settings. Call it <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
2.  Use the **Solution Explorer** to open the file MyProject.cpp.  
  
3.  Add <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> after the list of includes.  
  
4.  Find the method <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. Insert the following lines of code before the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statement. This code creates the strings that we use in either the Windows message box or in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
5.  Add the following code after the code from step 4. This code guarantees that the user's computer supports the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. If the dialog is not supported, the application displays a Windows message box instead.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
6.  Insert the following code between the brackets after the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> statement from step 5. This code creates the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
7.  On the next line, add the following code. This code sets the warning icon.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
8.  On the next line, add the following code. This code displays the task dialog box.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 You can omit step 7 if you do not want the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> to display the same icon as the Windows message box. If you omit that step, the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> has no icon when the application displays it.  
  
 Compile and run the application. The application displays the task dialog box after it starts.  
  
## Adding Functionality to the CTaskDialog  
 The following procedure shows you how to add functionality to the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> that you created in the previous procedure. The example code shows you how to execute specific instructions based on the user's selections.  
  
#### To Add Functionality to the CTaskDialog  
  
1.  Navigate to the **Resource View**. If you cannot see the **Resource View**, you can open it from the **View** menu.  
  
2.  Expand the **Resource View** until you can select the **String Table** folder. Expand it and double-click the **String Table** entry.  
  
3.  Scroll to the bottom of the string table and add a new entry. Change the ID to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. Set the caption to **Command Line 1**.  
  
4.  Add another new entry. Change the ID to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. Set the caption to **Command Line 2**.  
  
5.  Navigate back to MyProject.cpp.  
  
6.  After <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, add the following code:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
7.  Find the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> statement and replace that statement with the following code. This code updates the task dialog box and adds new controls:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
8.  Add the following line of code that displays the task dialog box to the user and retrieves the user's selection:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
9. Insert the following code after the call to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. This section of code processes the user's input:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 In the code in step 9, replace the comments that start with PROCESS IF with the code that you want to execute under the specified conditions.  
  
 Compile and run the application. The application displays the task dialog box that uses the new controls and additional information.  
  
## Displaying a CTaskDialog Without Creating a CTaskDialog Object  
 The following procedure shows you how to display a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> without first creating a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object. This example continues the previous procedures.  
  
#### To Display a CTaskDialog Without Creating a CTaskDialog Object  
  
1.  Open the MyProject.cpp file if it is not already open.  
  
2.  Navigate to the closing bracket for the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> statement.  
  
3.  Insert the following code immediately before the closing bracket of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> statement (before the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> block):  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Compile and run the application. The application displays two task dialog boxes. The first dialog box is from the To Add Functionality to the CTaskDialog procedure; the second dialog box is from the last procedure.  
  
 These examples do not demonstrate all the available options for a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, but should help you get started. See [CTaskDialog Class](../vs140/ctaskdialog-class.md) for a full description of the class.  
  
## See Also  
 [Dialog Boxes](../vs140/dialog-boxes.md)   
 [CTaskDialog Class](../vs140/ctaskdialog-class.md)   
 [CTaskDialog::CTaskDialog](../vs140/ctaskdialog--ctaskdialog.md)