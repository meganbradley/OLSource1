---
title: "CMFCVisualManager::OnDrawCaptionBarButtonBorder"
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
  - "OnDrawCaptionBarButtonBorder"
  - "CMFCVisualManager.OnDrawCaptionBarButtonBorder"
  - "CMFCVisualManager::OnDrawCaptionBarButtonBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawCaptionBarButtonBorder method"
ms.assetid: 8bc856aa-bb62-4ca4-a8f4-7600b9527e44
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawCaptionBarButtonBorder
[!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
## Syntax  
  
```  
virtual void OnDrawCaptionBarButtonBorder(  
   CDC* pDC,  
   CMFCCaptionBar* pBar,  
   CRect rect,  
   BOOL bIsPressed,  
   BOOL bIsHighlighted,  
   BOOL bIsDisabled,  
   BOOL bHasDropDownArrow,  
   BOOL bIsSysButton  
);  
```  
  
#### Parameters  
 [in] `pDC`  
  [in] `pBar`  
  [in] `rect`  
  [in] `bIsPressed`  
  [in] `bIsHighlighted`  
  [in] `bIsDisabled`  
  [in] `bHasDropDownArrow`  
  [in] `bIsSysButton`  
  
## Remarks  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)