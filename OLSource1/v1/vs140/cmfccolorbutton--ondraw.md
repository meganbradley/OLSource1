---
title: "CMFCColorButton::OnDraw"
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
  - "OnDraw"
  - "CMFCColorButton.OnDraw"
  - "CMFCColorButton::OnDraw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDraw method"
ms.assetid: 48898e11-3264-401b-971b-2c8af2276b1f
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorButton::OnDraw
Called by the framework to render an image of the button.  
  
## Syntax  
  
```  
virtual void OnDraw(  
   CDC* pDC,  
   const CRect& rect,  
   UINT uiState   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Points to the device context that is used to render the image of the button.  
  
 [in] `rect`  
 A rectangle that bounds the button.  
  
 [in] `uiState`  
 Specifies the visual state of the button.  
  
## Remarks  
 Override this method to customize the rendering process.  
  
## Requirements  
 **Header:** afxcolorbutton.h  
  
## See Also  
 [CMFCColorButton Class](../vs140/cmfccolorbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)