---
title: "CSimpleStringT::GetAt"
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
  - "ATL.CSimpleStringT<BaseType>.GetAt"
  - "ATL::CSimpleStringT::GetAt"
  - "ATL::CSimpleStringT<BaseType>::GetAt"
  - "CSimpleStringT::GetAt"
  - "ATL.CSimpleStringT.GetAt"
  - "CSimpleStringT<BaseType>::GetAt"
  - "CSimpleStringT.GetAt"
  - "CSimpleStringT<BaseType>.GetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAt method"
ms.assetid: 528beb4b-c115-487a-bac5-e51621d55eb6
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::GetAt
Returns one character from a `CSimpleStringT` object.  
  
## Syntax  
  
```  
  
      XCHAR GetAt(  
   int iChar  
) const;  
```  
  
#### Parameters  
 `iChar`  
 Zero-based index of the character in the `CSimpleStringT` object. The `iChar` parameter must be greater than or equal to 0 and less than the value returned by [GetLength](../vs140/csimplestringt--getlength.md). Otherwise, `GetAt` will generate an exception.  
  
## Return Value  
 An `XCHAR` that contains the character at the specified position in the string.  
  
## Remarks  
 Call this method to return the one character specified by `iChar`. The overloaded subscript (`[]`) operator is a convenient alias for `GetAt`. The null terminator is addressable without generating an exception by using `GetAt`. However, it is not counted by `GetLength`, and the value returned is 0.  
  
## Example  
 The following example demonstrates how to use `CSimpleStringT::GetAt`.  
  
 [!code[NVC_ATLMFC_Utilities#80](../vs140/codesnippet/CPP/csimplestringt--getat_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)   
 [CSimpleStringT::GetLength](../vs140/csimplestringt--getlength.md)   
 [CSimpleStringT::operator](../vs140/csimplestringt--operator.md)