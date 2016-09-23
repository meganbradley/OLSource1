---
title: "CRenderTarget::Flush"
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
  - afxrendertarget/CRenderTarget::Flush
  - Flush
dev_langs: 
  - C++
helpviewer_keywords: 
  - Flush method
ms.assetid: e4972623-776c-4a4c-bbc9-f06158fc7b83
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRenderTarget::Flush
Executes all pending drawing commands.  
  
## Syntax  
  
```  
void Flush(  
   D2D1_TAG* tag1 = NULL,  
   D2D1_TAG* tag2 = NULL  
);  
```  
  
#### Parameters  
 `tag1`  
 Contains the tag for drawing operations that caused errors or 0 if there were no errors. This parameter is passed uninitialized.  
  
 `tag2`  
 Contains the tag for drawing operations that caused errors or 0 if there were no errors. This parameter is passed uninitialized.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)