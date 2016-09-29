---
title: "PPLParallelForeachEventGuid Constant"
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
  - "concrt/concurrency::PPLParallelForeachEventGuid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PPLParallelForeachEventGuid constant"
ms.assetid: 3b00d409-83ea-4836-bec6-af40cf1a5902
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PPLParallelForeachEventGuid Constant
A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to usage of the `parallel_for_each` function.  
  
## Syntax  
  
```  
const __declspec(selectany) GUID PPLParallelForeachEventGuid = { 0x5cb7d785, 0x9d66, 0x465d, { 0xba, 0xe1, 0x46, 0x11, 0x6, 0x1b, 0x54, 0x34 } };  
```  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [parallel_for_each Function](../vs140/parallel_for_each-function.md)