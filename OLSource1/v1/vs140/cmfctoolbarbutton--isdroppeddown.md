---
title: "CMFCToolBarButton::IsDroppedDown"
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
  - "CMFCToolBarButton::IsDroppedDown"
  - "CMFCToolBarButton.IsDroppedDown"
  - "IsDroppedDown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsDroppedDown method"
ms.assetid: 78aef542-b6f0-431d-93e3-dbac49e61914
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::IsDroppedDown
Determines whether the button displays a submenu.  
  
## Syntax  
  
```  
virtual BOOL IsDroppedDown() const;  
```  
  
## Return Value  
 This method returns `FALSE`.  
  
## Remarks  
 The default implementation of this method returns `FALSE`. Override this method to return `TRUE` if your control displays a submenu.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)