---
title: "CContextMenuManager::AddMenu"
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
  - "AddMenu"
  - "CContextMenuManager::AddMenu"
  - "CContextMenuManager.AddMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddMenu method"
ms.assetid: 0b6f39ba-76c2-4bb0-b60a-ebf6ee6c3deb
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CContextMenuManager::AddMenu
Adds a new shortcut menu to the [CContextMenuManager](../vs140/ccontextmenumanager-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A resource ID for a string that contains the name for the new menu.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The menu resource ID.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A string that contains the name for the new menu.  
  
## Return Value  
 Nonzero if the method was successful; 0 if the method fails.  
  
## Remarks  
 This method fails if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is invalid or if another menu with the same name already is in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxcontextmenumanager.h  
  
## See Also  
 [CContextMenuManager Class](../vs140/ccontextmenumanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)