---
title: "CMFCToolBar::IsDragButton"
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
  - "IsDragButton"
  - "CMFCToolBar::IsDragButton"
  - "CMFCToolBar.IsDragButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsDragButton method"
ms.assetid: 474b05b8-ba5b-4d76-a21a-3206e96f96b5
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::IsDragButton
Determines whether a toolbar button is being dragged.  
  
## Syntax  
  
```  
BOOL IsDragButton(  
   const CMFCToolBarButton* pButton  
) const;  
```  
  
#### Parameters  
 [in] `pButton`  
 Pointer to a toolbar button.  
  
## Return Value  
 `TRUE` if the specified button is being dragged; otherwise, `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)