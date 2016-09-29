---
title: "ISource::acquire_ref Method"
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
  - "agents/concurrency::ISource::acquire_ref"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "acquire_ref method"
ms.assetid: ce82c35c-b30d-40ed-9cfd-b586b07ac293
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ISource::acquire_ref Method
When overridden in a derived class, acquires a reference count on this `ISource` block, to prevent deletion.  
  
## Syntax  
  
```  
virtual void acquire_ref(  
   _Inout_ ITarget<_Type> * _PTarget  
) = 0;  
```  
  
#### Parameters  
 `_PTarget`  
 A pointer to the target block that is calling this method.  
  
## Remarks  
 This method is called by an `ITarget` object that is being linked to this source during the `link_target` method.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ISource Class](../vs140/isource-class.md)