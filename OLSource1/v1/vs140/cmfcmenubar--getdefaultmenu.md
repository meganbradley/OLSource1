---
title: "CMFCMenuBar::GetDefaultMenu"
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
  - "GetDefaultMenu"
  - "CMFCMenuBar::GetDefaultMenu"
  - "CMFCMenuBar.GetDefaultMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDefaultMenu method"
ms.assetid: d7fd7943-30df-4680-958d-95f32774ad67
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMenuBar::GetDefaultMenu
Retrieves a handle to the original menu. The framework loads the original menu from the resource file.  
  
## Syntax  
  
```  
HMENU GetDefaultMenu() const;  
```  
  
## Return Value  
 A handle to a menu resource.  
  
## Remarks  
 If your application customizes a menu, you can use this method to retrieve a handle to the original menu.  
  
## Requirements  
 **Header:** afxmenubar.h  
  
## See Also  
 [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)