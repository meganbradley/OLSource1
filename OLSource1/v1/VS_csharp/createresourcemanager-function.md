---
title: "CreateResourceManager Function"
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
  - "concrtrm/concurrency::CreateResourceManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateResourceManager function"
ms.assetid: 8fced60c-65f0-4298-9dc8-cf02ea8b107a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CreateResourceManager Function
Returns an interface that represents the singleton instance of the Concurrency Runtime's Resource Manager. The Resource Manager is responsible for assigning resources to schedulers that want to cooperate with each other.  
  
## Syntax  
  
```  
IResourceManager* __cdecl CreateResourceManager();  
```  
  
## Return Value  
 An `IResourceManager` interface.  
  
## Remarks  
 Multiple subsequent calls to this method will return the same instance of the Resource Manager. Each call to the method increments a reference count on the Resource Manager, and must be matched with a call to the [IResourceManager::Release](assetId:///5d1356ec-fbd3-4284-a361-1e9e20bbb522) method when your scheduler is done communicating with the Resource Manager.  
  
 [unsupported_os](../VS_csharp/unsupported_os-class.md) is thrown if the operating system is not supported by the Concurrency Runtime.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../VS_csharp/concurrency-namespace.md)   
 [IResourceManager::OSVersion Enumeration](../VS_csharp/iresourcemanager--osversion-enumeration.md)