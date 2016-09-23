---
title: "CAnimationStoryboardEventHandler::CreateInstance"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - afxanimationcontroller/CAnimationStoryboardEventHandler::CreateInstance
  - CreateInstance
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreateInstance method
ms.assetid: c339e290-a499-4cd7-babe-04e5f06c82d0
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAnimationStoryboardEventHandler::CreateInstance
Creates an instance of CAnimationStoryboardEventHandler callback.  
  
## Syntax  
  
```  
static COM_DECLSPEC_NOTHROW HRESULT CreateInstance(  
   CAnimationController* pAnimationController,  
   IUIAnimationStoryboardEventHandler **ppHandler  
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
 [CAnimationStoryboardEventHandler Class](../vs140/canimationstoryboardeventhandler-class.md)