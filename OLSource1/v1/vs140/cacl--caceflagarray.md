---
title: "CAcl::CAceFlagArray"
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
  - "CAceFlagArray"
  - "ATL::CAcl::CAceFlagArray"
  - "CAcl.CAceFlagArray"
  - "CAcl::CAceFlagArray"
  - "ATL.CAcl.CAceFlagArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAceFlagArray method"
ms.assetid: 6e15409f-e8b7-40a9-95a2-c0d8748a7348
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAcl::CAceFlagArray
An array of BYTEs.  
  
## Syntax  
  
```  
  
typedef CAtlArray<BYTE> CAceFlagArray;  
  
```  
  
## Remarks  
 This typedef specifies the array type used to define the access-control entry (ACE) type-specific control flags. See the [ACE_HEADER](http://msdn.microsoft.com/library/windows/desktop/aa374919) definition for the complete list of possible flags.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAcl Class](../vs140/cacl-class.md)   
 [ACE_HEADER](http://msdn.microsoft.com/library/windows/desktop/aa374919)