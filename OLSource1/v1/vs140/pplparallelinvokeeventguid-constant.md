---
title: "PPLParallelInvokeEventGuid Constant"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - concrt/concurrency::PPLParallelInvokeEventGuid
dev_langs: 
  - C++
helpviewer_keywords: 
  - PPLParallelInvokeEventGuid constant
ms.assetid: 52dfc38b-44e9-435d-9207-ad9d16b6bd53
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# PPLParallelInvokeEventGuid Constant
A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to usage of the `parallel_invoke` function.  
  
## Syntax  
  
```  
const __declspec(selectany) GUID PPLParallelInvokeEventGuid = { 0xd1b5b133, 0xec3d, 0x49f4, { 0x98, 0xa3, 0x46, 0x4d, 0x1a, 0x9e, 0x46, 0x82 } };  
```  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [parallel_invoke Function](../vs140/parallel_invoke-function.md)