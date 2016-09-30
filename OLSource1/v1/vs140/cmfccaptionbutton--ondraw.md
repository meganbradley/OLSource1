---
title: "CMFCCaptionButton::OnDraw"
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
  - "CMFCCaptionButton::OnDraw"
  - "CMFCCaptionButton.OnDraw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDraw method"
ms.assetid: d1e15db1-c054-4d2a-922c-2fdc185a1b90
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCaptionButton::OnDraw
Draws the caption button.  
  
## Syntax  
  
```  
virtual void OnDraw(  
   CDC* pDC,  
   BOOL bActive,  
   BOOL bHorz = TRUE,  
   BOOL bMaximized = TRUE,  
   BOOL bDisabled = FALSE  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to a device context for the button.  
  
 [in] `bActive`  
 Whether to draw an active button image.  
  
 [in] `bHorz`  
 Reserved for use in a derived class.  
  
 [in] `bMaximized`  
 Whether to draw a maximized button image.  
  
 [in] `bDisabled`  
 Whether to draw an enabled button image.  
  
## Remarks  
 The `bMaximized` parameter is used when the button is a maximize or minimize button.  
  
## Requirements  
 **Header:** afxcaptionbutton.h  
  
## See Also  
 [CMFCCaptionButton Class](../vs140/cmfccaptionbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)