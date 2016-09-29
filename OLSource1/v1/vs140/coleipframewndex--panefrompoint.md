---
title: "COleIPFrameWndEx::PaneFromPoint"
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
  - "PaneFromPoint"
  - "COleIPFrameWndEx.PaneFromPoint"
  - "COleIPFrameWndEx::PaneFromPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PaneFromPoint method"
ms.assetid: 5e2beeee-923b-4287-a3cb-e1167e9dcf56
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleIPFrameWndEx::PaneFromPoint
[!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
## Syntax  
  
```  
CBasePane* PaneFromPoint(  
   CPoint point,  
   int nSensitivity,  
   bool bExactBar,  
   CRuntimeClass* pRTCBarType  
) const;  
CBasePane* PaneFromPoint(  
   CPoint point,  
   int nSensitivity,  
   DWORD& dwAlignment,  
   CRuntimeClass* pRTCBarType  
) const;  
```  
  
#### Parameters  
 [in] `point`  
  [in] `nSensitivity`  
  [in] `bExactBar`  
  [in] `pRTCBarType`  
  [in] `dwAlignment`  
  
## Return Value  
  
## Remarks  
  
## Requirements  
 **Header:** afxoleipframewndex.h  
  
## See Also  
 [COleIPFrameWndEx Class](../vs140/coleipframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)