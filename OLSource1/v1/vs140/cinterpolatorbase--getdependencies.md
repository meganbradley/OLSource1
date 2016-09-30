---
title: "CInterpolatorBase::GetDependencies"
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
  - "GetDependencies"
  - "afxanimationcontroller/CInterpolatorBase::GetDependencies"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDependencies method"
ms.assetid: d2290372-c8ca-407d-94ff-21ef15e50895
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CInterpolatorBase::GetDependencies
Gets the interpolator's dependencies.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Output. Aspects of the interpolator that depend on the initial value passed to SetInitialValueAndVelocity.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Output. Aspects of the interpolator that depend on the initial velocity passed to SetInitialValueAndVelocity.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Output. Aspects of the interpolator that depend on the duration passed to SetDuration.  
  
## Return Value  
 If the method succeeds, it returns S_OK. It returns E_FAIL if CCustomInterpolator is not set, or custom implementation returns FALSE from the GetDependencies method.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CInterpolatorBase Class](../vs140/cinterpolatorbase-class.md)