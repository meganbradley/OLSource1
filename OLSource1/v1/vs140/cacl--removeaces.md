---
title: "CAcl::RemoveAces"
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
  - RemoveAces
  - CAcl.RemoveAces
  - CAcl::RemoveAces
dev_langs: 
  - C++
helpviewer_keywords: 
  - RemoveAces method
ms.assetid: 3584ffbd-08b6-4dd1-9081-3093ff0de12e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAcl::RemoveAces
Removes alls ACEs (access-control entries) from the `CAcl` that apply to the given `CSid`.  
  
## Syntax  
  
```  
  
      bool RemoveAces(   
   const CSid & rSid   
) throw(...)  
```  
  
#### Parameters  
 `rSid`  
 A reference to a `CSid` object.  
  
## Returns  
 Returns true if successful, false if no ACEs are removed or the `CAcl` or `CSid` objects are invalid.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAcl Class](../vs140/cacl-class.md)   
 [CAcl::RemoveAce](../vs140/cacl--removeace.md)