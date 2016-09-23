---
title: "CAnimationRect::SetDefaultValue"
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
  - afxanimationcontroller/CAnimationRect::SetDefaultValue
  - SetDefaultValue
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetDefaultValue method
ms.assetid: cdcef737-61e5-49e8-a894-9ec1da83cf93
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimationRect::SetDefaultValue
Sets default value.  
  
## Syntax  
  
```  
void SetDefaultValue(  
   const CRect& rect  
);  
```  
  
#### Parameters  
 `rect`  
 Specifies new default values for left, top, right and bottom.  
  
## Remarks  
 Use this function to set a default value to animation object. This methods assigns default values to rectangle's bounds. It also recreates underlying COM objects if they have been created. If you subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationRect Class](../vs140/canimationrect-class.md)