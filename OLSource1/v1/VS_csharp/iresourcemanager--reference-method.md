---
title: "IResourceManager::Reference Method"
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
  - "concrtrm/concurrency::IResourceManager::Reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Reference method"
ms.assetid: 72cb0253-476a-4e0b-8999-2dfb4f384ee3
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IResourceManager::Reference Method
Increments the reference count on the Resource Manager instance.  
  
## Syntax  
  
```  
virtual unsigned int Reference() =0;  
```  
  
## Return Value  
 The resulting reference count.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IResourceManager Structure](../VS_csharp/iresourcemanager-structure.md)   
 [IResourceManager::Release Method](../VS_csharp/iresourcemanager--release-method.md)