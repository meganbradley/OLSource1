---
title: "CAnimationPoint::SetDefaultValue"
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
  - afxanimationcontroller/CAnimationPoint::SetDefaultValue
  - SetDefaultValue
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetDefaultValue method
ms.assetid: 9b159e8a-34c1-4c00-9b1e-924d5235bfd6
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimationPoint::SetDefaultValue
Sets default value.  
  
## Syntax  
  
```  
void SetDefaultValue(  
   const POINT& ptDefault  
);  
```  
  
#### Parameters  
 `ptDefault`  
 Specifies the default point value.  
  
## Remarks  
 Use this function to set a default value to animation object. This methods assigns default values to X and Y coordinates of animation point. It also recreates underlying COM objects if they have been created. If you subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationPoint Class](../vs140/canimationpoint-class.md)