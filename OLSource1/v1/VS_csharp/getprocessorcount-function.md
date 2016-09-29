---
title: "GetProcessorCount Function"
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
  - "concrtrm/concurrency::GetProcessorCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetProcessorCount function"
ms.assetid: bea5a723-89bf-4597-8657-46ecff3f0fae
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetProcessorCount Function
Returns the number of hardware threads on the underlying system.  
  
## Syntax  
  
```  
unsigned int __cdecl GetProcessorCount();  
```  
  
## Return Value  
 The number of hardware threads.  
  
## Remarks  
 [unsupported_os](../VS_csharp/unsupported_os-class.md) is thrown if the operating system is not supported by the Concurrency Runtime.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../VS_csharp/concurrency-namespace.md)   
 [IResourceManager::OSVersion Enumeration](../VS_csharp/iresourcemanager--osversion-enumeration.md)