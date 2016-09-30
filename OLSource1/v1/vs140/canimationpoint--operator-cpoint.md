---
title: "CAnimationPoint::operator CPoint"
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
  - "afxanimationcontroller/CAnimationPoint::operator CPoint"
  - "operator CPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator CPoint operator"
ms.assetid: 7138141b-c9f3-4308-938f-3d59407d99df
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationPoint::operator CPoint
Converts a CAnimationPoint to a CPoint.  
  
## Syntax  
  
```  
operator CPoint();  
```  
  
## Return Value  
 Current value of CAnimationPoint as CPoint.  
  
## Remarks  
 This function internally calls GetValue. If GetValue for some reason fails, the returned point will contain default values for X and Y coordinates.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationPoint Class](../vs140/canimationpoint-class.md)