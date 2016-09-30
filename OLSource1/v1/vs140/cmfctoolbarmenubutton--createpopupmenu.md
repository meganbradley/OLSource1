---
title: "CMFCToolBarMenuButton::CreatePopupMenu"
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
  - "CreatePopupMenu"
  - "CMFCToolBarMenuButton::CreatePopupMenu"
  - "CMFCToolBarMenuButton.CreatePopupMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreatePopupMenu method"
ms.assetid: 883ce342-07e3-41c0-90f5-2258b53e1d98
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarMenuButton::CreatePopupMenu
Creates a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object to display the toolbar menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that displays the drop-down menu associated with the toolbar menu button.  
  
## Remarks  
 This method is called by the framework to prepare the display of the drop-down menu associated with the button.  
  
 The default implementation just constructs and returns a new <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. Override this method if you want to use a derived type of [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md) or to perform additional initialization.  
  
## Requirements  
 **Header:** afxtoolbarmenubutton.h  
  
## See Also  
 [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)