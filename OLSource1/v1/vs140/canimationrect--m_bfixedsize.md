---
title: "CAnimationRect::m_bFixedSize"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - m_bFixedSize
  - afxanimationcontroller/CAnimationRect::m_bFixedSize
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_bFixedSize data member
ms.assetid: 6e9f6084-eca6-4984-a0e4-4d4b2d6ed379
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimationRect::m_bFixedSize
Specifies whether the rectangle has fixed size.  
  
## Syntax  
  
```  
BOOL m_bFixedSize;  
```  
  
## Remarks  
 If this member is true, then the size of rectangle is fixed and right and bottom values are recalculated each time the top-left corner is moved according to the fixed size. Set this value to TRUE to easily move the rectangle around the screen. In this case transitions applied to right and bottom coordinates are ignored. The size is stored internally when you construct the object and/or call SetDefaultValue. By default this member is set to FALSE.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationRect Class](../vs140/canimationrect-class.md)