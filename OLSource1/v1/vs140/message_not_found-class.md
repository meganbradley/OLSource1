---
title: "message_not_found Class"
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
  - "concrt/concurrency::message_not_found"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "message_not_found class"
ms.assetid: a96b9995-5ad7-4600-83c8-c15e329ff10e
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# message_not_found Class
This class describes an exception thrown when a messaging block is unable to find a requested message.  
  
## Syntax  
  
```  
class message_not_found : public std::exception;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[message_not_found::message_not_found Constructor](#message_not_found__message_not_found_constructor)|Overloaded. Constructs a                                         `message_not_found` object.|  
  
## Inheritance Hierarchy  
 `exception`  
  
 `message_not_found`  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  <a name="message_not_found__message_not_found_constructor"></a>  message_not_found::message_not_found Constructor  
 Constructs a                 `message_not_found` object.  
  
```  
explicit _CRTIMP message_not_found(  
   _In_z_ const char *                 _Message  
) throw();  
  
message_not_found() throw();  
```  
  
### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Asynchronous Message Blocks](../vs140/asynchronous-message-blocks.md)