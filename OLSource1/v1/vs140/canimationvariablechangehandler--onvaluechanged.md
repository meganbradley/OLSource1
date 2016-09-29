---
title: "CAnimationVariableChangeHandler::OnValueChanged"
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
  - "afxanimationcontroller/CAnimationVariableChangeHandler::OnValueChanged"
  - "OnValueChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnValueChanged method"
ms.assetid: 814bd971-4113-4197-93b6-1253d4b4fcec
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationVariableChangeHandler::OnValueChanged
Called when a value of an animation variable has changed.  
  
## Syntax  
  
```  
IFACEMETHOD(  
   OnValueChanged  
) ( __in IUIAnimationStoryboard *storyboard, __in IUIAnimationVariable *variable, __in DOUBLE newValue, __in DOUBLE previousValue );  
```  
  
#### Parameters  
 `storyboard`  
 The storyboard that is animating the variable.  
  
 `variable`  
 The animation variable that was updated.  
  
 `newValue`  
 The new value.  
  
 `previousValue`  
 The previous value.  
  
## Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationVariableChangeHandler Class](../vs140/canimationvariablechangehandler-class.md)