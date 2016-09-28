---
title: "CAnimationVariableIntegerChangeHandler::CreateInstance"
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
  - "afxanimationcontroller/CAnimationVariableIntegerChangeHandler::CreateInstance"
  - "CreateInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInstance method"
ms.assetid: 4c962e09-589a-47e3-afb3-3415c54776f9
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationVariableIntegerChangeHandler::CreateInstance
Creates an instance of CAnimationVariableIntegerChangeHandler callback.  
  
## Syntax  
  
```  
static COM_DECLSPEC_NOTHROW HRESULT CreateInstance(  
   CAnimationController* pAnimationController,  
   IUIAnimationVariableIntegerChangeHandler **ppHandler  
);  
```  
  
#### Parameters  
 `pAnimationController`  
 A pointer to animation controller, which will receive events.  
  
 `ppHandler`  
  
## Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationVariableIntegerChangeHandler Class](../vs140/canimationvariableintegerchangehandler-class.md)