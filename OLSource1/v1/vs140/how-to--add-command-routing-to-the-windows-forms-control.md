---
title: "How to: Add Command Routing to the Windows Forms Control"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "command routing [C++], adding to Windows Forms controls"
  - "Windows Forms controls [C++], command routing"
ms.assetid: bf138ece-b463-442a-b0a0-de7063a760c0
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Add Command Routing to the Windows Forms Control
[CWinFormsView](../vs140/cwinformsview-class.md) routes commands and update-command UI messages to the user control to allow it to handle MFC commands (for example, frame menu items and toolbar buttons).  
  
 The user control uses [ICommandTarget::Initialize](../vs140/icommandtarget--initialize.md) to store a reference to the command source object in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, as shown in the following example. To use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> you must add a reference to mfcmifc80.dll.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> handles several of the common MFC view notifications by forwarding them to the managed user control. These notifications include the [OnInitialUpdate](../vs140/iview--oninitialupdate.md), [OnUpdate](../vs140/iview--onupdate.md) and [OnActivateView](../vs140/iview--onactivateview.md) methods of the [IView Interface](../vs140/iview-interface.md).  
  
 This topic assumes you have previously completed [How to: Create the User Control and Host in a Dialog Box](../vs140/how-to--create-the-user-control-and-host-in-a-dialog-box.md) and [How to: Create the User Control and Host MDI View](../vs140/how-to--create-the-user-control-and-host-mdi-view.md).  
  
### To create the MFC host application  
  
1.  Open Windows Forms Control Library you created in [How to: Create the User Control and Host in a Dialog Box](../vs140/how-to--create-the-user-control-and-host-in-a-dialog-box.md).  
  
2.  Add a reference to mfcmifc80.dll, which you can do by right-clicking the project node in **Solution Explorer**, selecting **Add**, **Reference**, and then browsing to Microsoft Visual Studio 10.0\VC\atlmfc\lib.  
  
3.  Open UserControl1.Designer.cs and add the following using statement:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
4.  Also, in UserControl1.Designer.cs, change this line:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     to this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
5.  Add this as the first line of the class definition for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
6.  Add the following method definitions to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> (we will create the ID of the MFC control in the next step):  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
7.  Open the MFC application you created in [How to: Create the User Control and Host MDI View](../vs140/how-to--create-the-user-control-and-host-mdi-view.md).  
  
8.  Add a menu option that will invoke <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
     Go to **Resource View** (Ctrl+Shift+E), expand the **Menu** folder, and then double-click **IDR_MFC02TYPE**. This displays the menu editor.  
  
     Add a menu option at the bottom of the **View** menu. Notice the ID of the menu option in the **Properties** window. Save the file.  
  
     In **Solution Explorer**, open the Resource.h file, copy the ID value for the menu option you just added, and paste that value as the first parameter to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> call in the C# project's <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method (replacing <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> if necessary).  
  
9. Build and run the project.  
  
     On the **Build** menu, click **Build Solution**.  
  
     On the **Debug** menu, click **Start without debugging**.  
  
     Select the menu option you added. Notice that the method in the .dll is called.  
  
## See Also  
 [Hosting a Windows Forms User Control as an MFC View](../vs140/hosting-a-windows-forms-user-control-as-an-mfc-view.md)   
 [ICommandSource Interface](../vs140/icommandsource-interface.md)   
 [ICommandTarget Interface](../vs140/icommandtarget-interface.md)   
 [CommandHandler Delegate](../vs140/commandhandler-delegate.md)