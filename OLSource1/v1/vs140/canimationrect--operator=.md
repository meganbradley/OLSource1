---
title: "CAnimationRect::operator="
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
  - operator=
  - afxanimationcontroller/CAnimationRect::operator=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator= operator
ms.assetid: d1d3eced-1204-49b0-85c0-86b5e75328fa
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimationRect::operator=
Assigns rect to CAnimationRect.  
  
## Syntax  
  
```  
void operator=(  
   const RECT& rect  
);  
```  
  
#### Parameters  
 `rect`  
 The new value of animation rectangle.  
  
## Remarks  
 It's recommended to do that before animation start, because this operator calls SetDefaultValue, which recreates the underlying COM objects for color components if they have been created. If you subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationRect Class](../vs140/canimationrect-class.md)