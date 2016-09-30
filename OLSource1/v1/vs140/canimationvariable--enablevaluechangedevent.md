---
title: "CAnimationVariable::EnableValueChangedEvent"
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
  - "afxanimationcontroller/CAnimationVariable::EnableValueChangedEvent"
  - "EnableValueChangedEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableValueChangedEvent method"
ms.assetid: 0c1498e2-ee46-45c9-bfdb-e8d8f760d1f6
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationVariable::EnableValueChangedEvent
Enables or disables the ValueChanged event.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to parent controller.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 TRUE - enable event, FALSE - disable event.  
  
## Remarks  
 When ValueChanged event is enabled, the framework calls virtual method CAnimationController::OnAnimationValueChanged. You need to override it in a class derived from CAnimationController in order to process this event. This method is called every time the value of animation variable is changed.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationVariable Class](../vs140/canimationvariable-class.md)