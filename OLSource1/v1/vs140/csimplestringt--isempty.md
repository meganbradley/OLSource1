---
title: "CSimpleStringT::IsEmpty"
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
  - CSimpleStringT::IsEmpty
  - CSimpleStringT.IsEmpty
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsEmpty method
ms.assetid: 2792c6a4-fb52-4941-b9f8-3993d3979973
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSimpleStringT::IsEmpty
Tests a `CSimpleStringT` object for the empty condition.  
  
## Syntax  
  
```  
  
bool IsEmpty( ) const throw( );  
  
```  
  
## Return Value  
 Returns **true** if the `CSimpleStringT` object has 0 length; otherwise **false**.  
  
## Remarks  
 Call this method to determine if the object contains an empty string.  
  
## Example  
 The following example demonstrates the use of `CSimpleStringT::IsEmpty`.  
  
 [!code[NVC_ATLMFC_Utilities#84](../vs140/codesnippet/CPP/csimplestringt--isempty_1.cpp)]
  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)   
 [CSimpleStringT::GetLength](../vs140/csimplestringt--getlength.md)