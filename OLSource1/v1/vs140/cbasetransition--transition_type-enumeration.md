---
title: "CBaseTransition::TRANSITION_TYPE Enumeration"
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
  - TRANSITION_TYPE
  - afxanimationcontroller/CBaseTransition::TRANSITION_TYPE
dev_langs: 
  - C++
helpviewer_keywords: 
  - TRANSITION_TYPE enumeration
ms.assetid: 72f1324a-260d-43c0-9de9-f401abe9ca82
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBaseTransition::TRANSITION_TYPE Enumeration
Defines the transition types currently supported by the MFC implementation of Windows Animation API.  
  
## Syntax  
  
```  
enum TRANSITION_TYPE;  
```  
  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|`ACCELERATE_DECELERATE`||  
|`CONSTANT`||  
|`CUBIC`||  
|`CUSTOM`||  
|`DISCRETE`||  
|`INSTANTENEOUS`||  
|`LINEAR`||  
|`LINEAR_FROM_SPEED`||  
|`PARABOLIC_FROM_ACCELERATION`||  
|`REVERSAL`||  
|`SINUSOIDAL_FROM_RANGE`||  
|`SINUSOIDAL_FROM_VELOCITY`||  
|`SMOOTH_STOP`||  
|`UNKNOWN`||  
  
## Remarks  
 A transition type is set in the constructor of specific transition. For example, CSinusoidalTransitionFromRange sets its type to SINUSOIDAL_FROM_RANGE.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CBaseTransition Class](../vs140/cbasetransition-class.md)