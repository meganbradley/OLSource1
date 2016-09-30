---
title: "CInterpolatorBase::SetInitialValueAndVelocity"
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
  - "afxanimationcontroller/CInterpolatorBase::SetInitialValueAndVelocity"
  - "SetInitialValueAndVelocity"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetInitialValueAndVelocity method"
ms.assetid: 91ef2211-4bc9-4179-955a-7bb824b362b8
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInterpolatorBase::SetInitialValueAndVelocity
Sets the interpolator's initial value and velocity.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The value of the variable at the start of the transition.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The velocity of the variable at the start of the transition.  
  
## Return Value  
 If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not set, or custom implementation returns FALSE from the SetInitialValueAndVelocity method.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CInterpolatorBase Class](../vs140/cinterpolatorbase-class.md)