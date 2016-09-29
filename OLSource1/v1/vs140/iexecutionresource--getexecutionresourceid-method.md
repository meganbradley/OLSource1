---
title: "IExecutionResource::GetExecutionResourceId Method"
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
  - "concrtrm/concurrency::IExecutionResource::GetExecutionResourceId"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetExecutionResourceId method"
ms.assetid: 5f93ba8c-813b-41b3-a91b-a72d2b5fa7e2
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IExecutionResource::GetExecutionResourceId Method
Returns a unique identifier for the hardware thread that this execution resource represents.  
  
## Syntax  
  
```  
virtual unsigned int GetExecutionResourceId() const =0;  
```  
  
## Return Value  
 A unique identifier for the hardware thread underlying this execution resource.  
  
## Remarks  
 Each hardware thread is assigned a unique identifier by the Concurrency Runtime. If multiple execution resources are associated hardware thread, they will all have the same execution resource identifier.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IExecutionResource Structure](../vs140/iexecutionresource-structure.md)