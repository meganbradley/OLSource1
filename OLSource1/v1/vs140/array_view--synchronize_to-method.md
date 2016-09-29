---
title: "array_view::synchronize_to Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: f6ef8a8d-623e-4f6c-adb0-021d73fc815f
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array_view::synchronize_to Method
Synchronizes any modifications made to this array_view to the specified accelerator_view.  
  
## Syntax  
  
```  
void synchronize_to(  
   const accelerator_view& _Accl_view,  
   access_type _Access_type = access_type_read  
) const restrict(cpu);  
  
void synchronize_to(  
   const accelerator_view& _Accl_view  
) const restrict(cpu);  
```  
  
#### Parameters  
 `_Accl_view`  
 The target accelerator_view to synchronize to.  
  
 `_Access_type`  
 The desired access_type on the target accelerator_view. This parameter has a default value of access_type_read.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [array_view Class](../vs140/array_view-class.md)