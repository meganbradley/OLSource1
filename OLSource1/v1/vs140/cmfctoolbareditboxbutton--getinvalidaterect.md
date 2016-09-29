---
title: "CMFCToolBarEditBoxButton::GetInvalidateRect"
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
  - "GetInvalidateRect"
  - "CMFCToolBarEditBoxButton.GetInvalidateRect"
  - "CMFCToolBarEditBoxButton::GetInvalidateRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetInvalidateRect method"
ms.assetid: d118a23c-a89c-4efb-81e6-5f00004e745f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarEditBoxButton::GetInvalidateRect
Retrieves the region of the client area of the button that must be redrawn.  
  
## Syntax  
  
```  
virtual const CRect GetInvalidateRect() const;  
```  
  
## Return Value  
 A `CRect` object that specifies the region that must be redrawn.  
  
## Remarks  
 This method extends the base class implementation, [CMFCToolBarButton::GetInvalidateRect](../vs140/cmfctoolbarbutton--getinvalidaterect.md), by including in the region the area of the text label.  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
## See Also  
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::GetInvalidateRect](../vs140/cmfctoolbarbutton--getinvalidaterect.md)