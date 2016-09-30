---
title: "Methods of Creating a Toolbar"
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
  - "CToolBarCtrl class, and CToolBar class"
  - "CToolBar class, creating toolbars"
  - "MFC toolbars"
  - "toolbar controls [MFC]"
  - "toolbar controls [MFC], creating"
  - "CToolBarCtrl class, creating toolbars"
ms.assetid: f19d8d65-d49f-445c-abe8-d47d3e4101c8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Methods of Creating a Toolbar
MFC provides two classes to create toolbars: [CToolBar](../vs140/ctoolbar-class.md) and [CToolBarCtrl](../vs140/ctoolbarctrl-class.md) (which wraps the Windows common control API). <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> provides all of the functionality of the toolbar common control, and it handles many of the required common control settings and structures for you; however, your resulting executable usually will be larger than that created by using <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> usually results in a smaller executable, and you may prefer to use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if you do not intend to integrate the toolbar into the MFC architecture. If you plan to use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and integrate the toolbar into the MFC architecture, you must take additional care to communicate toolbar control manipulations to MFC. This communication is not difficult; however, it is additional work that is unneeded when you use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 Visual C++ provides two ways to take advantage of the toolbar common control.  
  
-   Create the toolbar using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and then call [CToolBar::GetToolBarCtrl](../vs140/ctoolbar--gettoolbarctrl.md) to get access to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member functions.  
  
-   Create the toolbar using [CToolBarCtrl](../vs140/ctoolbarctrl-class.md)'s constructor.  
  
 Either method will give you access to the member functions of the toolbar control. When you call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, it returns a reference to a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object so you can use either set of member functions. See [CToolBar](../vs140/ctoolbar-class.md) for information on constructing and creating a toolbar using <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## See Also  
 [Using CToolBarCtrl](../vs140/using-ctoolbarctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)