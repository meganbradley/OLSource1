---
title: "message::message Constructor"
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
  - "agents/concurrency::message::message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "message, constructor"
ms.assetid: 515d2743-1a79-479f-bd84-e3fc49faa607
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# message::message Constructor
Constructs a `message` object.  
  
## Syntax  
  
```  
message(  
   _Type const &_P  
);  
  
message(  
   _Type const &_P,  
   runtime_object_identity _Id  
);  
  
message(  
   message const & _Msg  
);  
  
message(  
   _In_ message const * _Msg  
);  
```  
  
#### Parameters  
 `_P`  
 The payload of this message.  
  
 `_Id`  
 The unique ID of this message.  
  
 `_Msg`  
 A reference or pointer to a `message` object.  
  
## Remarks  
 The constructor that takes a pointer to a `message` object as an argument throws an [invalid_argument](../VS_csharp/invalid_argument-class.md) exception if the parameter `_Msg` is `NULL`.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [message Class](../VS_csharp/message-class.md)