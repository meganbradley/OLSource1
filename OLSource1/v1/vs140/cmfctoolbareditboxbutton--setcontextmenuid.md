---
title: "CMFCToolBarEditBoxButton::SetContextMenuID"
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
  - "CMFCToolBarEditBoxButton.SetContextMenuID"
  - "SetContextMenuID"
  - "CMFCToolBarEditBoxButton::SetContextMenuID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetContextMenuID method"
ms.assetid: 92434b67-9181-4e70-a0d4-351213c74485
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarEditBoxButton::SetContextMenuID
Specifies the resource ID of the shortcut menu that is associated with the button.  
  
## Syntax  
  
```  
void SetContextMenuID(UINT uiResID);  
```  
  
#### Parameters  
 [in] `uiCmd`  
 The resource ID of the shortcut menu.  
  
## Remarks  
 The framework uses the resource ID to create the shortcut menu when the user right-clicks the toolbar button.  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
## See Also  
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarEditBoxButton::GetContextMenuID](../vs140/cmfctoolbareditboxbutton--getcontextmenuid.md)