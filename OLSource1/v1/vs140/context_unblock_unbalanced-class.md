---
title: "context_unblock_unbalanced Class"
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
  - "concrt/concurrency::context_unblock_unbalanced"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "context_unblock_unbalanced class"
ms.assetid: a76066c8-19dd-44fa-959a-6941ec1b0d2d
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# context_unblock_unbalanced Class
This class describes an exception thrown when calls to the             `Block` and             `Unblock` methods of a             `Context` object are not properly paired.  
  
## Syntax  
  
```  
class context_unblock_unbalanced : public std::exception;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[context_unblock_unbalanced::context_unblock_unbalanced Constructor](#context_unblock_unbalanced__context_unblock_unbalanced_constructor)|Overloaded. Constructs a                                         `context_unblock_unbalanced` object.|  
  
## Remarks  
 Calls to the                 `Block` and                 `Unblock` methods of a                 `Context` object must always be properly paired. The Concurrency Runtime allows the operations to happen in either order. For example, a call to                 `Block` can be followed by a call to                 `Unblock`, or vice-versa. This exception would be thrown if, for instance, two calls to the                 `Unblock` method were made in a row, on a                 `Context` object which was not blocked.  
  
## Inheritance Hierarchy  
 `exception`  
  
 `context_unblock_unbalanced`  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  <a name="context_unblock_unbalanced__context_unblock_unbalanced_constructor"></a>  context_unblock_unbalanced::context_unblock_unbalanced Constructor  
 Constructs a                 `context_unblock_unbalanced` object.  
  
```  
explicit _CRTIMP context_unblock_unbalanced(  
   _In_z_ const char *                 _Message  
) throw();  
  
context_unblock_unbalanced() throw();  
```  
  
### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Context Class](../vs140/context-class.md)   
 [Context::Unblock Method](../vs140/context-class.md#context__unblock_method)   
 [Context::Block Method](../vs140/context-class.md#context__block_method)