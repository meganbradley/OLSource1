---
title: "CSimpleStringT::StringLength"
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
  - CSimpleStringT<BaseType>::StringLength
  - CSimpleStringT.StringLength
  - CSimpleStringT::StringLength
  - ATL::CSimpleStringT::StringLength
  - ATL.CSimpleStringT.StringLength
  - ATL::CSimpleStringT<BaseType>::StringLength
  - StringLength
dev_langs: 
  - C++
helpviewer_keywords: 
  - StringLength method
  - string length, StringLength method
ms.assetid: d5f17ebe-f4a4-4795-8928-86e94ea0996c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSimpleStringT::StringLength
Returns the number of characters in the specified string.  
  
## Syntax  
  
```  
  
      ATL_NOINLINE static int StringLength(  
   PCXSTR psz  
) throw( );  
```  
  
#### Parameters  
 `psz`  
 A pointer to a null-terminated string.  
  
## Return Value  
 The number of characters in `psz`; not counting a null terminator.  
  
## Remarks  
 Call this method to retrieve the number of characters in the string pointed to by `psz`.  
  
## Example  
 The following example demonstrates the use of `CSimpleStringT::StringLength`.  
  
 [!code[NVC_ATLMFC_Utilities#91](../vs140/codesnippet/CPP/csimplestringt--stringlength_1.cpp)]
  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)