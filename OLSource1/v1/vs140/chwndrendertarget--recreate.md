---
title: "CHwndRenderTarget::ReCreate"
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
  - afxrendertarget/CHwndRenderTarget::ReCreate
  - ReCreate
dev_langs: 
  - C++
helpviewer_keywords: 
  - ReCreate method
ms.assetid: f5025793-bce6-48c7-9f16-d8f3b2c91312
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHwndRenderTarget::ReCreate
Re-creates a render target associated with the window  
  
## Syntax  
  
```  
BOOL ReCreate(  
   HWND hWnd  
);  
```  
  
#### Parameters  
 `hWnd`  
 The HWND associated with this render target  
  
## Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CHwndRenderTarget Class](../vs140/chwndrendertarget-class.md)