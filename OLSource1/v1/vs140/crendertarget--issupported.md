---
title: "CRenderTarget::IsSupported"
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
  - IsSupported
  - afxrendertarget/CRenderTarget::IsSupported
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsSupported method
ms.assetid: 58e7ecfc-956c-4aef-a0dd-399ec2f16c2e
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRenderTarget::IsSupported
Indicates whether the render target supports the specified properties  
  
## Syntax  
  
```  
BOOL IsSupported(  
   const D2D1_RENDER_TARGET_PROPERTIES& renderTargetProperties  
) const;  
```  
  
#### Parameters  
 `renderTargetProperties`  
 The render target properties to test  
  
## Return Value  
 TRUE if the specified render target properties are supported by this render target; otherwise, FALSE  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)