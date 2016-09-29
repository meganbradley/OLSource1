---
title: "send Function"
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
  - "agents/concurrency::send"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "send function"
ms.assetid: 8713fb36-066b-47de-af12-589fa74805d6
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# send Function
A synchronous send operation, which waits until the target either accepts or declines the message.  
  
## Syntax  
  
```  
template <  
   class _Type  
>  
bool send(  
   _Inout_ ITarget<_Type> * _Trg,  
   const _Type& _Data  
);  
  
template <  
   class _Type  
>  
bool send(  
   ITarget<_Type> &_Trg,  
   const _Type &_Data  
);  
```  
  
#### Parameters  
 `_Type`  
 The payload type.  
  
 `_Trg`  
 A pointer or reference to the target to which data is sent.  
  
 `_Data`  
 A reference to the data to be sent.  
  
## Return Value  
 `true` if the message was accepted, `false` otherwise.  
  
## Remarks  
 For more information, see [Message Passing Functions](../VS_csharp/message-passing-functions.md).  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../VS_csharp/concurrency-namespace.md)   
 [receive Function](../VS_csharp/receive-function.md)   
 [try_receive Function](../VS_csharp/try_receive-function.md)   
 [asend Function](../VS_csharp/asend-function.md)