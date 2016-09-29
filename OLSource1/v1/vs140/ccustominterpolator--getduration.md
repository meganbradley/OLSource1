---
title: "CCustomInterpolator::GetDuration"
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
  - "GetDuration"
  - "afxanimationcontroller/CCustomInterpolator::GetDuration"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDuration method"
ms.assetid: 26cc64c8-6a44-42a0-ab81-935c1bec9146
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCustomInterpolator::GetDuration
Gets the interpolator's duration.  
  
## Syntax  
  
```  
virtual BOOL GetDuration(  
   UI_ANIMATION_SECONDS *duration  
);  
```  
  
#### Parameters  
 `duration`  
 Output. The duration of the transition, in seconds.  
  
## Return Value  
 Basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CCustomInterpolator Class](../vs140/ccustominterpolator-class.md)