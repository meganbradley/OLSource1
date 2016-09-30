---
title: "Methods of Creating a Status Bar"
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
  - "CStatusBar class, vs. CStatusBarCtrl"
  - "methods [MFC], creating status bars"
  - "CStatusBarCtrl class, vs. CStatusBar"
  - "CStatusBarCtrl class, creating"
  - "methods [MFC]"
  - "status bars, creating"
ms.assetid: 9aeaf290-7099-4762-a5ba-9c26705333c9
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Methods of Creating a Status Bar
MFC provides two classes to create status bars: [CStatusBar](../vs140/cstatusbar-class.md) and [CStatusBarCtrl](../vs140/cstatusbarctrl-class.md) (which wraps the Windows common control API). <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> provides all of the functionality of the status bar common control, it automatically interacts with menus and toolbars, and it handles many of the required common control settings and structures for you; however, your resulting executable usually will be larger than that created by using <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> usually results in a smaller executable, and you may prefer to use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if you do not intend to integrate the status bar into the MFC architecture. If you plan to use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and integrate the status bar into the MFC architecture, you must take additional care to communicate status bar control manipulations to MFC. This communication is not difficult; however, it is additional work that is unneeded when you use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 Visual C++ provides two ways to take advantage of the status bar common control.  
  
-   Create the status bar using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and then call [CStatusBar::GetStatusBarCtrl](../vs140/cstatusbar--getstatusbarctrl.md) to get access to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member functions.  
  
-   Create the status bar using [CStatusBarCtrl](../vs140/cstatusbarctrl-class.md)'s constructor.  
  
 Either method will give you access to the member functions of the status bar control. When you call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, it returns a reference to a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object so you can use either set of member functions. See [CStatusBar](../vs140/cstatusbar-class.md) for information on constructing and creating a status bar using <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## See Also  
 [Using CStatusBarCtrl](../vs140/using-cstatusbarctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)