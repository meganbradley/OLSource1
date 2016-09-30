---
title: "Using a Common Control as a Child Window"
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
  - "controls [MFC], using as child windows"
  - "windows [C++], common controls as"
  - "child windows, common controls as"
  - "common controls [C++], child windows"
  - "Windows common controls [C++], child windows"
ms.assetid: 608f7d47-7854-4fce-bde9-856c51e76753
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using a Common Control as a Child Window
Any of the Windows common controls can be used as a child window of any other window. The following procedure describes how to create a common control dynamically and then work with it.  
  
### To use a common control as a child window  
  
1.  Define the control in the related class or handler.  
  
2.  Use the control's override of the [CWnd::Create](../vs140/cwnd--create.md) method to create the Windows control.  
  
3.  After the control has been created (as early as the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> handler if you subclass the control), you can manipulate the control using its member functions. See the descriptions of individual controls at [Controls (MFC)](../vs140/controls--mfc-.md) for details on methods.  
  
4.  When you are finished with the control, use [CWnd::DestroyWindow](../vs140/cwnd--destroywindow.md) to destroy the control.  
  
## See Also  
 [Making and Using Controls](../vs140/making-and-using-controls.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)