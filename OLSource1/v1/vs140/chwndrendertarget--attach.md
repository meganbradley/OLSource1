---
title: "CHwndRenderTarget::Attach"
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
  - Attach
  - afxrendertarget/CHwndRenderTarget::Attach
dev_langs: 
  - C++
helpviewer_keywords: 
  - Attach method
ms.assetid: 00fbea9c-48ef-480b-8ed0-df7a23d1a54d
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHwndRenderTarget::Attach
Attaches existing render target interface to the object  
  
## Syntax  
  
```  
void Attach(  
   ID2D1HwndRenderTarget* pTarget  
);  
```  
  
#### Parameters  
 `pTarget`  
 Existing render target interface. Cannot be NULL  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CHwndRenderTarget Class](../vs140/chwndrendertarget-class.md)