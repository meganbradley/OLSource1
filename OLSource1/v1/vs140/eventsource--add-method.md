---
title: "EventSource::Add Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - event/Microsoft::WRL::EventSource::Add
dev_langs: 
  - C++
helpviewer_keywords: 
  - Add method
ms.assetid: 8bded85b-929e-4425-a464-e5de67bb774c
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# EventSource::Add Method
Appends the event handler represented by the specified delegate interface to the set of event handlers for the current EventSource object.  
  
## Syntax  
  
```  
HRESULT Add(  
   _In_ TDelegateInterface* delegateInterface,  
   _Out_ EventRegistrationToken* token  
);  
```  
  
#### Parameters  
 `delegateInterface`  
 The interface to a delegate object, which represents an event handler.  
  
 `token`  
 When this operation completes, a handle that represents the event. Use this token as the parameter to the [Remove()](../vs140/eventsource--remove-method.md) method to discard the event handler.  
  
## Return Value  
 S_OK if successful; otherwise, an HRESULT that indicates the error.  
  
## Requirements  
 **Header:** event.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [EventSource Class](../vs140/eventsource-class.md)