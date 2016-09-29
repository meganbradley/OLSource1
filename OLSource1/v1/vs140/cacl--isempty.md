---
title: "CAcl::IsEmpty"
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
  - "CAcl::IsEmpty"
  - "CAcl.IsEmpty"
  - "ATL::CAcl::IsEmpty"
  - "ATL.CAcl.IsEmpty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsEmpty method"
ms.assetid: d9ca4e0e-9000-4786-856b-a2c28f3c6fc8
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAcl::IsEmpty
Tests the `CAcl` object for entries.  
  
## Syntax  
  
```  
  
bool IsEmpty( ) const throw( );  
  
```  
  
## Remarks  
 Returns **true** if the `CAcl` object is not NULL, and contains no entries. Returns **false** if the `CAcl` object is either NULL, or contains at least one entry.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAcl Class](../vs140/cacl-class.md)   
 [CAcl::SetEmpty](../vs140/cacl--setempty.md)