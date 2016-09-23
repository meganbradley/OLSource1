---
title: "Trace_agents_register_name Function"
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
  - agents/concurrency::Trace_agents_register_name
dev_langs: 
  - C++
helpviewer_keywords: 
  - Trace_agents_register_name function
ms.assetid: 9bea9d3d-922d-4d1d-b075-4bc3be45dab4
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Trace_agents_register_name Function
Associates the given name to the message block or agent in the ETW trace.  
  
## Syntax  
  
```  
template <  
   class _Type  
>  
void Trace_agents_register_name(  
   _Inout_ _Type * _PObject,  
   _In_z_ const wchar_t * _Name  
);  
```  
  
#### Parameters  
 `_Type`  
 The type of the object. This is typically a message block or an agent.  
  
 `_PObject`  
 A pointer to the message block or agent that is being named in the trace.  
  
 `_Name`  
 The name for the given object.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)