---
title: "CAnimationManagerEventHandler::CreateInstance"
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
  - "afxanimationcontroller/CAnimationManagerEventHandler::CreateInstance"
  - "CreateInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInstance method"
ms.assetid: 68686070-42f1-4649-aeab-143752b8d809
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationManagerEventHandler::CreateInstance
[!INCLUDE[dev10_sp1required](../vs140/includes/dev10_sp1required_md.md)]  
  
 Creates an instance of CAnimationManagerEventHandler object.  
  
## Syntax  
  
```  
static COM_DECLSPEC_NOTHROW HRESULT CreateInstance(  
   CAnimationController* pAnimationController,  
   IUIAnimationManagerEventHandler **ppManagerEventHandler  
);  
```  
  
#### Parameters  
 `pAnimationController`  
 A pointer to animation controller, which will receive events.  
  
 `ppManagerEventHandler`  
 Output. If the method succeeds it contains a pointer to COM object that will handle status updates to an animation manager.  
  
## Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationManagerEventHandler Class](../vs140/canimationmanagereventhandler-class.md)