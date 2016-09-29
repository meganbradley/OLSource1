---
title: "CCustomInterpolator::SetDuration"
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
  - "SetDuration"
  - "afxanimationcontroller/CCustomInterpolator::SetDuration"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDuration method"
ms.assetid: 36254eec-b79c-411a-b5f5-a92c3b57eccb
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCustomInterpolator::SetDuration
Sets the interpolator's duration.  
  
## Syntax  
  
```  
virtual BOOL SetDuration(  
   UI_ANIMATION_SECONDS duration  
);  
```  
  
#### Parameters  
 `duration`  
 The duration of the transition.  
  
## Return Value  
 Basic implementation always returns TRUE. Return FALSE from overridden implementation if you wish to fail the event.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CCustomInterpolator Class](../vs140/ccustominterpolator-class.md)