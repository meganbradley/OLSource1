---
title: "CMFCColorButton::OnDrawFocusRect"
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
  - "CMFCColorButton.OnDrawFocusRect"
  - "OnDrawFocusRect"
  - "CMFCColorButton::OnDrawFocusRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawFocusRect method"
ms.assetid: 5568d981-572f-4722-be9a-207560ab0543
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorButton::OnDrawFocusRect
Called by the framework to display a focus rectangle when the button has focus.  
  
## Syntax  
  
```  
virtual void OnDrawFocusRect(  
   CDC* pDC,  
   const CRect& rectClient   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Points to the device context used to draw the focus rectangle.  
  
 [in] `rectClient`  
 A rectangle in the device context specified by the `pDC` parameter that defines the boundaries of the button.  
  
## Remarks  
 Override this method to customize appearance of the focus rectangle.  
  
## Requirements  
 **Header:** afxcolorbutton.h  
  
## See Also  
 [CMFCColorButton Class](../vs140/cmfccolorbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)