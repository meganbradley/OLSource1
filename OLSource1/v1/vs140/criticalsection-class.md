---
title: "CriticalSection Class"
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
  - "corewrappers/Microsoft::WRL::Wrappers::CriticalSection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CriticalSection class"
ms.assetid: f2e0a024-71a3-4f6b-99ea-d93a4a608ac4
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CriticalSection Class
Represents a critical section object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Constructor  
  
|Name|Description|  
|----------|-----------------|  
|[CriticalSection::CriticalSection Constructor](../vs140/criticalsection--criticalsection-constructor.md)|Initializes a synchronization object that is similar to a mutex object, but can be used by only the threads of a single process.|  
|[CriticalSection::~CriticalSection Destructor](../vs140/criticalsection--~criticalsection-destructor.md)|Deinitializes and destroys the current CriticalSection object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CriticalSection::TryLock Method](../vs140/criticalsection--trylock-method.md)|Attempts to enter a critical section without blocking. If the call is successful, the calling thread takes ownership of the critical section.|  
|[CriticalSection::Lock Method](../vs140/criticalsection--lock-method.md)|Waits for ownership of the specified critical section object. The function returns when the calling thread is granted ownership.|  
|[CriticalSection::IsValid Method](../vs140/criticalsection--isvalid-method.md)|Indicates whether the current critical section is valid.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CriticalSection::cs_ Data Member](../vs140/criticalsection--cs_-data-member.md)|Declares a critical section data member.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [Microsoft::WRL::Wrappers Namespace](../vs140/microsoft--wrl--wrappers-namespace.md)