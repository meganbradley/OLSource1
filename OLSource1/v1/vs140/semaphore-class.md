---
title: "Semaphore Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "corewrappers/Microsoft::WRL::Wrappers::Semaphore"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Semaphore class"
ms.assetid: ded53526-17b4-4381-9c60-ea5e77363db6
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Semaphore Class
Represents a synchronization object that controls a shared resource that can support a limited number of users.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A synonym for a class that supports synchronous locks.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[Semaphore::Semaphore Constructor](../vs140/semaphore--semaphore-constructor.md)|Initializes a new instance of the Semaphore class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[InvokeHelper::Invoke Method](../vs140/invokehelper--invoke-method.md)|Calls the event handler whose signature contains the specified number of arguments.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[Semaphore::Lock Method](../vs140/semaphore--lock-method.md)|Waits until the current object, or the object associated with the specified handle, is in the signaled state or the specified time-out interval has elapsed.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[Semaphore::operator= Operator](../vs140/semaphore--operator=-operator.md)|Moves the specified handle from a Semaphore object to the current Semaphore object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [Microsoft::WRL::Wrappers Namespace](../vs140/microsoft--wrl--wrappers-namespace.md)