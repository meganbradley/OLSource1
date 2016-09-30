---
title: "CAnimationController::OnAnimationIntegerValueChanged"
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
  - "afxanimationcontroller/CAnimationController::OnAnimationIntegerValueChanged"
  - "OnAnimationIntegerValueChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnAnimationIntegerValueChanged method"
ms.assetid: 11c72ddf-c352-4ddc-a74b-30a5fd0a4710
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::OnAnimationIntegerValueChanged
Called by the framework when integer value of animation variable has changed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to an animation group that holds an animation object whose value has changed.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to an animation object that contains an animation variable whose value has changed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to an animation variable.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies new value.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies previous value.  
  
## Remarks  
 This method is called if you enable animation variable events with EnableIntegerValueChangedEvent called for a specific animation variable or animation object. It can be overridden in a derived class to take application-specific actions.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)