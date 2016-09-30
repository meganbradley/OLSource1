---
title: "CWnd::HiliteMenuItem"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CWnd::HiliteMenuItem"
  - "CWnd.HiliteMenuItem"
  - "HiliteMenuItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HiliteMenuItem method"
ms.assetid: a07411af-437a-4ecc-b578-b7fe164fe47f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::HiliteMenuItem
Highlights or removes the highlight from a top-level (menu-bar) menu item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Identifies the top-level menu that contains the item to be highlighted.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the menu item to be highlighted, depending on the value of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies whether the menu item is highlighted or the highlight is removed. It can be a combination of **MF_HILITE** or **MF_UNHILITE** with **MF_BYCOMMAND** or **MF_BYPOSITION**. The values can be combined using the bitwise OR operator. These values have the following meanings:  
  
-   **MF_BYCOMMAND** Interprets <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> as the menu-item ID (the default interpretation).  
  
-   **MF_BYPOSITION** Interprets <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> as the zero-based offset of the menu item.  
  
-   **MF_HILITE** Highlights the item. If this value is not given, the highlight is removed from the item.  
  
-   **MF_UNHILITE** Removes the highlight from the item.  
  
## Return Value  
 Specifies whether the menu item was highlighted. Nonzero if the item was highlighted; otherwise 0.  
  
## Remarks  
 The **MF_HILITE** and **MF_UNHILITE** flags can be used only with this member function; they cannot be used with the [CMenu::ModifyMenu](../vs140/cmenu--modifymenu.md) member function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::ModifyMenu](../vs140/cmenu--modifymenu.md)   
 [HiliteMenuItem](http://msdn.microsoft.com/library/windows/desktop/ms647986)