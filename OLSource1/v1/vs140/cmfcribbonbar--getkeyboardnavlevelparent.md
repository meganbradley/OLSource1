---
title: "CMFCRibbonBar::GetKeyboardNavLevelParent"
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
  - "CMFCRibbonBar::GetKeyboardNavLevelParent"
  - "GetKeyboardNavLevelParent"
  - "CMFCRibbonBar.GetKeyboardNavLevelParent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetKeyboardNavLevelParent method"
ms.assetid: 66edb9e3-6357-473e-a2a0-413df99f07e9
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::GetKeyboardNavLevelParent
Retrieves the parent keyboard navigation object on the ribbon bar.  
  
## Syntax  
  
```  
CObject* GetKeyboardNavLevelParent() const;  
```  
  
## Return Value  
 The parent keyboard navigation object on the ribbon bar; otherwise `NULL`.  
  
## Remarks  
 When the user presses a keytip on the ribbon bar, the current keyboard navigation object becomes the parent keyboard navigation object.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)