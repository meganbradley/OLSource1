---
title: "CDCRenderTarget::BindDC"
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
  - afxrendertarget/CDCRenderTarget::BindDC
  - BindDC
dev_langs: 
  - C++
helpviewer_keywords: 
  - BindDC method
ms.assetid: f2674ee7-e0be-442a-a101-79dd2cd1b1c3
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDCRenderTarget::BindDC
Binds the render target to the device context to which it issues drawing commands  
  
## Syntax  
  
```  
BOOL BindDC(  
   const CDC& dc,  
   const CRect& rect  
);  
```  
  
#### Parameters  
 `dc`  
 The device context to which the render target issues drawing commands  
  
 `rect`  
 The dimensions of the handle to a device context (HDC) to which the render target is bound  
  
## Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CDCRenderTarget Class](../vs140/cdcrendertarget-class.md)