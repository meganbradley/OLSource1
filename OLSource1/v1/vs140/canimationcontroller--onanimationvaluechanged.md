---
title: "CAnimationController::OnAnimationValueChanged"
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
  - "OnAnimationValueChanged"
  - "afxanimationcontroller/CAnimationController::OnAnimationValueChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnAnimationValueChanged method"
ms.assetid: 28dcf3df-5dd8-4f63-91e8-c1016b89cb63
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationController::OnAnimationValueChanged
Called by the framework when value of animation variable has changed.  
  
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
 This method is called if you enable animation variable events with EnableValueChangedEvent called for a specific animation variable or animation object. It can be overridden in a derived class to take application-specific actions.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationController Class](../vs140/canimationcontroller-class.md)