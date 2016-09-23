---
title: "receive Function"
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
  - agents/concurrency::receive
dev_langs: 
  - C++
helpviewer_keywords: 
  - receive function
ms.assetid: f36bbca1-97ac-4343-bfac-ea71ca2139e9
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# receive Function
A general receive implementation, allowing a context to wait for data from exactly one source and filter the values that are accepted.  
  
## Syntax  
  
```  
template <  
   class _Type  
>  
_Type receive(  
   _Inout_ ISource<_Type> * _Src,  
   unsigned int _Timeout = COOPERATIVE_TIMEOUT_INFINITE  
);  
  
template <  
   class _Type  
>  
_Type receive(  
   _Inout_ ISource<_Type> * _Src,  
   typename ITarget<_Type>::filter_method const& _Filter_proc,  
   unsigned int _Timeout = COOPERATIVE_TIMEOUT_INFINITE  
);  
  
template <  
   class _Type  
>  
_Type receive(  
   ISource<_Type> &_Src,  
   unsigned int _Timeout = COOPERATIVE_TIMEOUT_INFINITE  
);  
  
template <  
   class _Type  
>  
_Type receive(  
   ISource<_Type> &_Src,  
   typename ITarget<_Type>::filter_method const& _Filter_proc,  
   unsigned int _Timeout = COOPERATIVE_TIMEOUT_INFINITE  
);  
```  
  
#### Parameters  
 `_Type`  
 The payload type.  
  
 `_Src`  
 A pointer or reference to the source from which data is expected.  
  
 `_Timeout`  
 The maximum time for which the method should for the data, in milliseconds.  
  
 `_Filter_proc`  
 A filter function which determines whether messages should be accepted.  
  
## Return Value  
 A value from the source, of the payload type.  
  
## Remarks  
 If the parameter `_Timeout` has a value other than the constant `COOPERATIVE_TIMEOUT_INFINITE`, the exception [operation_timed_out](../vs140/operation_timed_out-class.md) is thrown if the specified amount of time expires before a message is received. If you want a zero length timeout, you should use the [try_receive](../vs140/try_receive-function.md) function, as opposed to calling `receive` with a timeout of `0` (zero), as it is more efficient and does not throw exceptions on timeouts.  
  
 For more information, see [Message Passing Functions](../vs140/message-passing-functions.md).  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [try_receive Function](../vs140/try_receive-function.md)   
 [send Function](../vs140/send-function.md)   
 [asend Function](../vs140/asend-function.md)