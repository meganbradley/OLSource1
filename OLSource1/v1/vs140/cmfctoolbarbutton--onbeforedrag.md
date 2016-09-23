---
title: "CMFCToolBarButton::OnBeforeDrag"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - OnBeforeDrag
  - CMFCToolBarButton.OnBeforeDrag
  - CMFCToolBarButton::OnBeforeDrag
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnBeforeDrag method
ms.assetid: c8cce0f1-6f97-4847-83d5-dfcd3ec7a251
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarButton::OnBeforeDrag
Specifies whether the button can be dragged.  
  
## Syntax  
  
```  
virtual BOOL OnBeforeDrag() const;  
```  
  
## Return Value  
 `TRUE` if the button can be dragged; otherwise `FALSE`.  
  
## Remarks  
 The framework calls this method before the user starts to drag the button.  
  
 The default implementation of this method returns `TRUE`. Override this method to return `FALSE` to disable dragging of the button.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)