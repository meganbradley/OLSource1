---
title: "CComAutoDeleteCriticalSection Class"
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
  - "ATL.CComAutoDeleteCriticalSection"
  - "CComAutoDeleteCriticalSection"
  - "ATL::CComAutoDeleteCriticalSection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComAutoDeleteCriticalSection class"
ms.assetid: 2396dbea-1c60-4841-b50e-c4e18af311a3
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAutoDeleteCriticalSection Class
This class provides methods for obtaining and releasing ownership of a critical section object.  
  
## Syntax  
  
```  
  
class CComAutoDeleteCriticalSection : public CComSafeDeleteCriticalSection  
  
```  
  
## Remarks  
 `CComAutoDeleteCriticalSection` derives from the class [CComSafeDeleteCriticalSection](../vs140/ccomsafedeletecriticalsection-class.md). However, `CComAutoDeleteCriticalSection` overrides the [Term](../vs140/ccomsafedeletecriticalsection--term.md) method to `private` access, which forces internal memory cleanup to occur only when instances of this class go out of scope or are explicitly deleted from memory.  
  
 This class introduces no additional methods over its base class. See [CComSafeDeleteCriticalSection](../vs140/ccomsafedeletecriticalsection-class.md) and [CComCriticalSection](../vs140/ccomcriticalsection-class.md) for more information on critical section helper classes.  
  
## Inheritance Hierarchy  
 [CComCriticalSection](../vs140/ccomcriticalsection-class.md)  
  
 [CComSafeDeleteCriticalSection](../vs140/ccomsafedeletecriticalsection-class.md)  
  
 `CComAutoDeleteCriticalSection`  
  
## Requirements  
 **Header:** atlcore.h  
  
## See Also  
 [CComSafeDeleteCriticalSection Class](../vs140/ccomsafedeletecriticalsection-class.md)   
 [CComCriticalSection Class](../vs140/ccomcriticalsection-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)