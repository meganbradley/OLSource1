---
title: "CAnimationColor::GetValue"
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
  - GetValue
  - afxanimationcontroller/CAnimationColor::GetValue
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetValue method
ms.assetid: fafbc114-3c57-48a3-86e4-651a9b3a9a86
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimationColor::GetValue
Returns current value.  
  
## Syntax  
  
```  
BOOL GetValue(  
   COLORREF& color  
);  
```  
  
#### Parameters  
 `color`  
 Output. Contains the current value when this method returns.  
  
## Return Value  
 TRUE, if the current value was successfully retrieved; otherwise FALSE.  
  
## Remarks  
 Call this function to retrieve the current value of animation color. If this method fails or underlying COM objects for color components have not been initialized, color contains default value, which was previously set in constructor or by SetDefaultValue.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationColor Class](../vs140/canimationcolor-class.md)