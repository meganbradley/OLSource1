---
title: "IResourceManager::Release Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "concrtrm/concurrency::IResourceManager::Release"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Release method"
ms.assetid: 858784b0-f9a9-4e8f-a02e-8801d29b12c2
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IResourceManager::Release Method
Decrements the reference count on the Resource Manager instance. The Resource Manager is destroyed when its reference count goes to `0`.  
  
## Syntax  
  
```  
virtual unsigned int Release() =0;  
```  
  
## Return Value  
 The resulting reference count.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IResourceManager Structure](../vs140/iresourcemanager-structure.md)   
 [CreateResourceManager Function](../vs140/createresourcemanager-function.md)   
 [IResourceManager::Reference Method](../vs140/iresourcemanager--reference-method.md)