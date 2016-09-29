---
title: "CMFCVisualManager::OnFillCaptionBarButton"
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
  - "CMFCVisualManager.OnFillCaptionBarButton"
  - "CMFCVisualManager::OnFillCaptionBarButton"
  - "OnFillCaptionBarButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillCaptionBarButton method"
ms.assetid: bf0e9f76-1234-476c-ba37-c9cd71159e26
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnFillCaptionBarButton
[!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
## Syntax  
  
```  
virtual COLORREF OnFillCaptionBarButton(  
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
  
## Return Value  
  
## Remarks  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)