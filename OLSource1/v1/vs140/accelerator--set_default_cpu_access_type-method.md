---
title: "accelerator::set_default_cpu_access_type Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
ms.assetid: bee89989-1a00-4319-9961-3efecf1b9c8d
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# accelerator::set_default_cpu_access_type Method
Set the default cpu access_type for arrays created on this accelerator or for implicit memory allocations as part of array_views accessed on this this accelerator. This method only succeeds if the default_cpu_access_type for the accelerator has not already been overriden by a previous call to this method and the runtime selected default_cpu_access_type for this accelerator has not yet been used for allocating an array or for an implicit memory allocation backing an array_view accessed on this accelerator.  
  
## Syntax  
  
```  
bool set_default_cpu_access_type(  
   access_type _Default_cpu_access_type  
);  
```  
  
#### Parameters  
 `_Default_cpu_access_type`  
 The default cpu access_type to be used for array/array_view memory allocations on this accelerator.  
  
## Return Value  
 A boolean value indicating if the default cpu access_type for the accelerator was successfully set.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [accelerator Class](../vs140/accelerator-class.md)