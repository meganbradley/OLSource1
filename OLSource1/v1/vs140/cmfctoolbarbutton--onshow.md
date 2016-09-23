---
title: "CMFCToolBarButton::OnShow"
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
  - OnShow
  - CMFCToolBarButton.OnShow
  - CMFCToolBarButton::OnShow
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnShow method
ms.assetid: 4383bce3-6edf-4f2f-b96a-52682594f72b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarButton::OnShow
Called by the framework when the button becomes visible or invisible.  
  
## Syntax  
  
```  
virtual void OnShow(  
   BOOL bShow  
);  
```  
  
#### Parameters  
 [in] `bShow`  
 Specifies whether the button is visible. If this parameter is `TRUE`, the button is visible. Otherwise, the button is not visible.  
  
## Remarks  
 The default implementation of this method does nothing. Override this method to update the visibility of the button.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)