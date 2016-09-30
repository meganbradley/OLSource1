---
title: "CriticalSectionTraits Structure"
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
  - "corewrappers/Microsoft::WRL::Wrappers::HandleTraits::CriticalSectionTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CriticalSectionTraits structure"
ms.assetid: c515a1b5-4eb0-40bc-9035-c4d9352c9de7
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CriticalSectionTraits Structure
Specializes a CriticalSection object to support either an invalid critical section or a function to release a critical section.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that defines a pointer to a critical section. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is defined as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CriticalSectionTraits::GetInvalidValue Method](../vs140/criticalsectiontraits--getinvalidvalue-method.md)|Specializes a CriticalSection template so that the template is always invalid.|  
|[CriticalSectionTraits::Unlock Method](../vs140/criticalsectiontraits--unlock-method.md)|Specializes a CriticalSection template so that it supports releasing ownership of the specified critical section object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers::HandleTraits  
  
## See Also  
 [HandleTraits Namespace](../vs140/microsoft--wrl--wrappers--handletraits-namespace.md)