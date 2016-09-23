---
title: "uninitialized_object::uninitialized_object Constructor"
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
  - amprt/Concurrency::uninitialized_object::uninitialized_object
dev_langs: 
  - C++
helpviewer_keywords: 
  - uninitialized_object, constructor
ms.assetid: bef90a88-1796-4bc0-bf44-1e656f012e34
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# uninitialized_object::uninitialized_object Constructor
Initializes a new instance of the [uninitialized_object Class](../vs140/uninitialized_object-class.md).  
  
## Syntax  
  
```  
explicit uninitialized_object(  
   const char * _Message                       
) throw();  
  
uninitialized_object() throw();  
```  
  
#### Parameters  
 `_Message`  
 A description of the error.  
  
## Return Value  
 The `uninitialized_object` object.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [uninitialized_object Class](../vs140/uninitialized_object-class.md)