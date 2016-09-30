---
title: "CAnimationVariable::SetDefaultValue"
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
  - "afxanimationcontroller/CAnimationVariable::SetDefaultValue"
  - "SetDefaultValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDefaultValue method"
ms.assetid: 9dfae92b-27b9-4fbf-8ef4-64b93fce8f3b
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationVariable::SetDefaultValue
Sets default value and releases IUIAnimationVariable COM object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the new default value.  
  
## Remarks  
 Use this method to reset the default value. This method releases the internal IUIAnimationVariable COM object, therefore when animation variable is recreated, the underlying COM object gets the new default value. The default value is returned by GetValue if the COM object representing the animation variable is not created, or if the variable has not been animated.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationVariable Class](../vs140/canimationvariable-class.md)