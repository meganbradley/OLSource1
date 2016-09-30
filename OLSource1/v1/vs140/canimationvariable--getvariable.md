---
title: "CAnimationVariable::GetVariable"
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
  - "GetVariable"
  - "afxanimationcontroller/CAnimationVariable::GetVariable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetVariable method"
ms.assetid: b7fbeaf8-f712-471b-bc35-f544621ad621
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationVariable::GetVariable
Returns a pointer to IUIAnimationVariable COM object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A valid pointer to IUIAnimationVariable COM object, or NULL if animation variable was not created, or can't be created.  
  
## Remarks  
 Use this function to access the underlying IUIAnimationVariable COM object and call its methods directly if needed.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationVariable Class](../vs140/canimationvariable-class.md)