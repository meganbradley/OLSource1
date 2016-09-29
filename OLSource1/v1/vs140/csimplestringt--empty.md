---
title: "CSimpleStringT::Empty"
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
  - "ATL.CSimpleStringT<BaseType>.Empty"
  - "CSimpleStringT<BaseType>::Empty"
  - "ATL::CSimpleStringT::Empty"
  - "ATL::CSimpleStringT<BaseType>::Empty"
  - "CSimpleStringT.Empty"
  - "ATL.CSimpleStringT.Empty"
  - "CSimpleStringT::Empty"
  - "CSimpleStringT<BaseType>.Empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Empty method"
ms.assetid: 8e6547f3-7ef5-4def-9052-2d14a8182f7b
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::Empty
Makes this `CSimpleStringT` object an empty string and frees memory as appropriate.  
  
## Syntax  
  
```  
  
void Empty( ) throw( );  
  
```  
  
## Remarks  
 For more information, see [Strings: CString Exception Cleanup](../vs140/cstring-exception-cleanup.md).  
  
## Example  
 The following example demonstrates the use of `CSimpleStringT::Empty`.  
  
 [!code[NVC_ATLMFC_Utilities#78](../vs140/codesnippet/CPP/csimplestringt--empty_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)   
 [CSimpleStringT::IsEmpty](../vs140/csimplestringt--isempty.md)