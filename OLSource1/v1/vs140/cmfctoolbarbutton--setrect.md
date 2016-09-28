---
title: "CMFCToolBarButton::SetRect"
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
  - "CMFCToolBarButton::SetRect"
  - "SetRect"
  - "CMFCToolBarButton.SetRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRect method"
ms.assetid: 3ee71126-15c1-42e2-b419-266db1d15c79
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::SetRect
Sets the bounding rectangle of the button.  
  
## Syntax  
  
```  
void SetRect(  
   const CRect rect   
);  
```  
  
#### Parameters  
 [in] `rect`  
 The new bounding rectangle of the button.  
  
## Remarks  
 This method calls the [CMFCToolBarButton::OnMove](../vs140/cmfctoolbarbutton--onmove.md) method after it sets the new bounding rectangle.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::OnMove](../vs140/cmfctoolbarbutton--onmove.md)