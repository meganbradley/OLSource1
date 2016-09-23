---
title: "CRenderTarget::GetTags"
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
  - afxrendertarget/CRenderTarget::GetTags
  - GetTags
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetTags method
ms.assetid: e173e057-30ea-4ef8-abaa-bbed151bc8de
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRenderTarget::GetTags
Gets the label for subsequent drawing operations.  
  
## Syntax  
  
```  
void GetTags(  
   D2D1_TAG *tag1 = NULL,  
   D2D1_TAG *tag2 = NULL  
) const;  
```  
  
#### Parameters  
 `tag1`  
 Contains the first label for subsequent drawing operations. This parameter is passed uninitialized. If NULL is specified, no value is retrieved for this parameter.  
  
 `tag2`  
 Contains the second label for subsequent drawing operations. This parameter is passed uninitialized. If NULL is specified, no value is retrieved for this parameter.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)