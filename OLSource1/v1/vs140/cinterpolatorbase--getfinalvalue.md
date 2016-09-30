---
title: "CInterpolatorBase::GetFinalValue"
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
  - "GetFinalValue"
  - "afxanimationcontroller/CInterpolatorBase::GetFinalValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFinalValue method"
ms.assetid: 2ffebfbe-a9f3-449d-8084-58eca98d4fdf
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInterpolatorBase::GetFinalValue
Gets the final value to which the interpolator leads.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Output. The final value of a variable at the end of the transition.  
  
## Return Value  
 If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not set, or custom implementation returns FALSE from the GetFinalValue method.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CInterpolatorBase Class](../vs140/cinterpolatorbase-class.md)