---
title: "try_receive Function"
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
  - "agents/concurrency::try_receive"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "try_receive function"
ms.assetid: c9d76668-e5cf-48de-ab79-bd7b2bc38db9
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# try_receive Function
A general try-receive implementation, allowing a context to look for data from exactly one source and filter the values that are accepted. If the data is not ready, the method will return false.  
  
## Syntax  
  
```  
template <  
   class _Type  
>  
bool try_receive(  
   _Inout_ ISource<_Type> * _Src,  
   _Type & _value  
);  
  
template <  
   class _Type  
>  
bool try_receive(  
   _Inout_ ISource<_Type> * _Src,  
   _Type & _value,  
   typename ITarget<_Type>::filter_method const& _Filter_proc  
);  
  
template <  
   class _Type  
>  
bool try_receive(  
   ISource<_Type> & _Src,  
   _Type & _value  
);  
  
template <  
   class _Type  
>  
bool try_receive(  
   ISource<_Type> & _Src,  
   _Type & _value,  
   typename ITarget<_Type>::filter_method const& _Filter_proc  
);  
```  
  
#### Parameters  
 `_Type`  
 The payload type  
  
 `_Src`  
 A pointer or reference to the source from which data is expected.  
  
 `_value`  
 A reference to a location where the result will be placed.  
  
 `_Filter_proc`  
 A filter function which determines whether messages should be accepted.  
  
## Return Value  
 A `bool` value indicating whether or not a payload was placed in `_value`.  
  
## Remarks  
 For more information, see [Message Passing Functions](../vs140/message-passing-functions.md).  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [receive Function](../vs140/receive-function.md)   
 [send Function](../vs140/send-function.md)   
 [asend Function](../vs140/asend-function.md)