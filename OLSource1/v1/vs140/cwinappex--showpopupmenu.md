---
title: "CWinAppEx::ShowPopupMenu"
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
  - "CWinAppEx::ShowPopupMenu"
  - "ShowPopupMenu"
  - "CWinAppEx.ShowPopupMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowPopupMenu method"
ms.assetid: da7ff5b2-bdd7-4743-a584-67acb9f8c7d8
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::ShowPopupMenu
Displays a popup menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A menu resource ID.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A [CPoint](../vs140/cpoint-class.md) that specifies the position of the menu in screen coordinates.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the window that owns the popup menu.  
  
## Return Value  
 Nonzero if the popup menu is displayed successfully; 0 otherwise.  
  
## Remarks  
 This method displays the menu associated with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 To support popup menus, you must have a [CContextMenuManager](../vs140/ccontextmenumanager-class.md) object. If you have not initialized the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> will fail.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md)