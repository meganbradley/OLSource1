---
title: "CMFCCaptionBar::OnDrawButton"
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
  - "CMFCCaptionBar.OnDrawButton"
  - "OnDrawButton"
  - "CMFCCaptionBar::OnDrawButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawButton method"
ms.assetid: fd93f136-7d07-4113-8510-d2bc02c9f54d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCaptionBar::OnDrawButton
Called by the framework to draw the caption bar button.  
  
## Syntax  
  
```  
virtual void OnDrawButton(  
   CDC* pDC,  
   CRect rect,  
   const CString& strButton,  
   BOOL bEnabled   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context that is used to display the button.  
  
 [in] `rect`  
 The bounding rectangle of the button.  
  
 [in] `strButton`  
 The button's text label.  
  
 [in] `bEnabled`  
 `TRUE` if the button is enabled; `FALSE` otherwise.  
  
## Remarks  
 Override this method in a `CMFCCaptionBar` derived class to customize the appearance of the caption bar's button.  
  
## Requirements  
 **Header:** afxcaptionbar.h  
  
## See Also  
 [CMFCCaptionBar Class](../vs140/cmfccaptionbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)