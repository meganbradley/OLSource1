---
title: "CMFCLinkCtrl::OnDrawFocusRect"
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
  - "CMFCLinkCtrl.OnDrawFocusRect"
  - "CMFCLinkCtrl::OnDrawFocusRect"
  - "OnDrawFocusRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawFocusRect method"
ms.assetid: d0c9e6bc-5564-4035-9260-2f67cea07e38
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCLinkCtrl::OnDrawFocusRect
Called by the framework before the focus rectangle of the button is drawn.  
  
## Syntax  
  
```  
virtual void OnDrawFocusRect(  
   CDC* pDC,  
   const CRect& rectClient   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rectClient`  
 A rectangle that bounds the link control.  
  
## Remarks  
 Override this method when you want to use your own code to draw the button's focus rectangle.  
  
## Requirements  
 **Header:** afxlinkctrl.h  
  
## See Also  
 [CMFCLinkCtrl Class](../vs140/cmfclinkctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)