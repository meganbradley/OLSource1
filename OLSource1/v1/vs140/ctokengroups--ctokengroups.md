---
title: "CTokenGroups::CTokenGroups"
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
  - ATL.CTokenGroups.CTokenGroups
  - ATL::CTokenGroups::CTokenGroups
  - CTokenGroups.CTokenGroups
  - CTokenGroups::CTokenGroups
  - CTokenGroups
dev_langs: 
  - C++
helpviewer_keywords: 
  - CTokenGroups class, constructor
  - CTokenGroups constructor
ms.assetid: dc57d868-7e21-46eb-b28b-68516803aaf3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTokenGroups::CTokenGroups
The constructor.  
  
## Syntax  
  
```  
  
      CTokenGroups( ) throw( );   
CTokenGroups(  
   const CTokenGroups & rhs   
) throw(...);  
CTokenGroups(  
   const TOKEN_GROUPS & rhs   
) throw(...);  
```  
  
#### Parameters  
 `rhs`  
 The `CTokenGroups` object or [TOKEN_GROUPS](http://msdn.microsoft.com/library/windows/desktop/aa379624) structure with which to construct the `CTokenGroups` object.  
  
## Remarks  
 The `CTokenGroups` object can optionally be created using a **TOKEN_GROUPS** structure or a previously defined `CTokenGroups` object.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CTokenGroups Class](../vs140/ctokengroups-class.md)   
 [CTokenGroups::~CTokenGroups](../vs140/ctokengroups--~ctokengroups.md)   
 [TOKEN_GROUPS](http://msdn.microsoft.com/library/windows/desktop/aa379624)