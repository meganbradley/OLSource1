---
title: "CAnimationVariable::GetValue"
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
  - "GetValue"
  - "afxanimationcontroller/CAnimationVariable::GetValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetValue method"
ms.assetid: 45997822-65a2-46bb-b097-850dc449628f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationVariable::GetValue
Returns the current value of animation variable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The current value of the animation variable.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The current value of the animation variable.  
  
## Return Value  
 S_OK if the value was obtained successfully, or underlying animation variable has not been created. Otherwise HRESULT error code.  
  
## Remarks  
 This method can be called to retrieve the current value of animation variable. If the underlying COM object has not been created, dblValue will contain a default value, when the function returns.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationVariable Class](../vs140/canimationvariable-class.md)