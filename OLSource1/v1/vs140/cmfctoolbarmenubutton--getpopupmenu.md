---
title: "CMFCToolBarMenuButton::GetPopupMenu"
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
  - "CMFCToolBarMenuButton.GetPopupMenu"
  - "CMFCToolBarMenuButton::GetPopupMenu"
  - "GetPopupMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPopupMenu method"
ms.assetid: acb5fed8-dd1c-4569-a8d0-9121f6f0fc79
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarMenuButton::GetPopupMenu
Returns a pointer to the [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md) object that represents the drop-down menu of the button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to a [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md) object that was created when the framework drew the submenu of the toolbar menu button; <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if no submenu is displayed.  
  
## Remarks  
 When a toolbar menu button displays a drop-down menu, the button creates a [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md) object to represent the menu. Call this method to obtain a pointer to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object. You should not store the returned pointer, because it is temporary and becomes invalid when the user closes the drop-down menu.  
  
## Requirements  
 **Header:** afxtoolbarmenubutton.h  
  
## See Also  
 [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)