---
title: "CMFCToolBarImages::DrawEx"
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
  - "DrawEx"
  - "CMFCToolBarImages::DrawEx"
  - "CMFCToolBarImages.DrawEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawEx method"
ms.assetid: dbea13e9-bd31-4aa8-a986-90a65a6dcf9c
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarImages::DrawEx
[!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
## Syntax  
  
```  
BOOL DrawEx(  
   CDC* pDC,  
   CRect rect,  
   int iImageIndex,  
   ImageAlignHorz horzAlign = ImageAlignHorzLeft,  
   ImageAlignVert vertAlign = ImageAlignVertTop,  
   CRect rectSrc = CRect(0,  
    0,  
    0,  
    0),  
   BYTE alphaSrc = 255  
);  
```  
  
#### Parameters  
 [in] `pDC`  
  [in] `rect`  
  [in] `iImageIndex`  
  [in] `horzAlign`  
  [in] `vertAlign`  
  [in] `rectSrc`  
  [in] `0`  
  [in] `0)`  
  [in] `alphaSrc`  
  
## Return Value  
  
## Remarks  
  
## Requirements  
 **Header:** afxtoolbarimages.h  
  
## See Also  
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)