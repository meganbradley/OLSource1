---
title: "CMFCRibbonColorButton::SetColorName"
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
  - "CMFCRibbonColorButton::SetColorName"
  - "SetColorName"
  - "CMFCRibbonColorButton.SetColorName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetColorName method"
ms.assetid: 2519aac3-c265-49ee-8a53-a342acb2d107
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonColorButton::SetColorName
Sets a new name for a specified color.  
  
## Syntax  
  
```  
static void __stdcall SetColorName(  
   COLORREF color,  
   const CString& strName  
);  
```  
  
#### Parameters  
 [in] `color`  
 The RGB value of a color.  
  
 [in] `strName`  
 The new name for the specified color.  
  
## Remarks  
 Because it calls `CMFCColorBar::SetColorName`, this method changes the name of the specified color in all `CMFCColorBar` objects in your application.  
  
## Requirements  
 **Header:** afxribboncolorbutton.h  
  
## See Also  
 [CMFCRibbonColorButton Class](../vs140/cmfcribboncolorbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)