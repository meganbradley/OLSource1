---
title: "How to: Use the Finder Tool"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - Window Finder Tool
ms.assetid: 5841926b-08c3-4e43-88bd-4223d04f9aef
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Use the Finder Tool
You can use the Finder Tool in the **Find Window** dialog box to display window properties or messages. The Finder Tool can also locate disabled child windows, and discern which window to highlight if disabled child windows overlap.  
  
 ![Spy&#43;&#43; Find Window Dialog Box](../vs140/media/icon_spy--_find.png "Icon_Spy++_Find")  
Finder Tool in the Find Window dialog box  
  
 The figure above shows the Find Window dialog box after step 3 below.  
  
### To display window properties or messages  
  
1.  Arrange your windows so that both Spy++ and the target window are visible.  
  
2.  From the **Spy** menu, choose **Find Window**.  
  
     The [Find Window Dialog Box](../vs140/find-window-dialog-box.md) opens.  
  
3.  Drag the **Finder Tool** over the target window.  
  
     As you drag the tool, the **Find Window** dialog box displays details on the selected window.  
  
     – or –  
  
     If you have the handle of the window you want to examine (for example, copied from the debugger), type it into the **Handle** text box.  
  
    > [!TIP]
    >  To reduce screen clutter, select the **Hide Spy** option. This option conceals the main Spy++ window, leaving only the **Find Window** dialog box visible on top of your other applications. The Spy++ main window is restored when you click **OK** or **Cancel**, or when you clear the **Hide Spy++** option.  
  
4.  Under **Show**, select either **Properties** or **Messages**.  
  
5.  Press **OK**.  
  
     If you selected **Properties**, the [Window Properties Dialog Box](../vs140/window-properties-dialog-box.md) opens. If you selected **Messages**, a [Messages View](../vs140/messages-view.md) window opens.  
  
## See Also  
 [Spy++ Views](../vs140/spy---views.md)   
 [Using Spy++](../vs140/using-spy--.md)   
 [Spy++ Reference](../vs140/spy---reference.md)