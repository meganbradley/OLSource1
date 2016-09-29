---
title: "CAnimationRect::operator RECT"
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
  - "afxanimationcontroller/CAnimationRect::operator RECT"
  - "operator RECT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator RECT operator"
ms.assetid: 63a2089a-3372-4da2-8f09-ff2f4f5f9798
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationRect::operator RECT
Converts a CAnimationRect to RECT.  
  
## Syntax  
  
```  
operator RECT();  
```  
  
## Return Value  
 Current value of animation rectangle as RECT.  
  
## Remarks  
 This function internally calls GetValue. If GetValue for some reason fails, the returned RECT will contain default values for all rectangle coordinates.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationRect Class](../vs140/canimationrect-class.md)