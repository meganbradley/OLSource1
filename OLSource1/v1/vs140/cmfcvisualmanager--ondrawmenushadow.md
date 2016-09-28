---
title: "CMFCVisualManager::OnDrawMenuShadow"
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
  - "CMFCVisualManager.OnDrawMenuShadow"
  - "CMFCVisualManager::OnDrawMenuShadow"
  - "OnDrawMenuShadow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawMenuShadow method"
ms.assetid: 699f03c8-076c-4ef0-b1d6-7caf10f5ee80
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawMenuShadow
[!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
## Syntax  
  
```  
virtual void OnDrawMenuShadow(  
   CDC* pDC,  
   const CRect& rectClient,  
   const CRect& rectExclude,  
   int nDepth,  
   int iMinBrightness,  
   int iMaxBrightness,  
   CBitmap* pBmpSaveBottom,  
   CBitmap* pBmpSaveRight,  
   BOOL bRTL  
);  
```  
  
#### Parameters  
 [in] `pDC`  
  [in] `rectClient`  
  [in] `rectExclude`  
  [in] `nDepth`  
  [in] `iMinBrightness`  
  [in] `iMaxBrightness`  
  [in] `pBmpSaveBottom`  
  [in] `pBmpSaveRight`  
  [in] `bRTL`  
  
## Remarks  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)