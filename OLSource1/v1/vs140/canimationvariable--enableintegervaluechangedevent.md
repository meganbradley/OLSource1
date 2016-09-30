---
title: "CAnimationVariable::EnableIntegerValueChangedEvent"
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
  - "afxanimationcontroller/CAnimationVariable::EnableIntegerValueChangedEvent"
  - "EnableIntegerValueChangedEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableIntegerValueChangedEvent method"
ms.assetid: 20c6d481-fd8c-4216-bffa-ec18334934a3
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationVariable::EnableIntegerValueChangedEvent
Enables or disables the IntegerValueChanged event.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to parent controller.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 TRUE - enable event, FALSE - disable event.  
  
## Remarks  
 When ValueChanged event is enabled, the framework calls virtual method CAnimationController::OnAnimationIntegerValueChanged. You need to override it in a class derived from CAnimationController in order to process this event. This method is called every time the integer value of animation variable is changed.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationVariable Class](../vs140/canimationvariable-class.md)