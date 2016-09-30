---
title: "CMFCToolBarMenuButton::OpenPopupMenu"
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
  - "OpenPopupMenu"
  - "CMFCToolBarMenuButton::OpenPopupMenu"
  - "CMFCToolBarMenuButton.OpenPopupMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OpenPopupMenu method"
ms.assetid: af4e7f44-de0e-45ae-b224-198754dca0d1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarMenuButton::OpenPopupMenu
Called by the framework when the user opens the drop-down menu of a toolbar menu button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the window that receives the drop-down menu commands. It can be <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> only if the toolbar menu button has a parent window.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> when a[CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md) object was created and opened successfully; otherwise <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function is called by the framework when the user opens a drop-down menu from a toolbar menu button.  
  
## Requirements  
 **Header:** afxtoolbarmenubutton.h  
  
## See Also  
 [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)