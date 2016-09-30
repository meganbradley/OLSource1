---
title: "GetProcessorNodeCount Function"
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
  - "concrtrm/concurrency::GetProcessorNodeCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetProcessorNodeCount function"
ms.assetid: ffbc9395-d79c-4cb4-bbb3-8511820f5c62
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetProcessorNodeCount Function
Returns the number of NUMA nodes or processor packages on the underlying system.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The number of NUMA nodes or processor packages.  
  
## Remarks  
 If the system contains more NUMA nodes than processor packages, the number of NUMA nodes is returned, otherwise, the number of processor packages is returned.  
  
 [unsupported_os](../vs140/unsupported_os-class.md) is thrown if the operating system is not supported by the Concurrency Runtime.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [IResourceManager::OSVersion Enumeration](../vs140/iresourcemanager--osversion-enumeration.md)