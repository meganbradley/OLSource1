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
Returns one character from a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Zero-based index of the character in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter must be greater than or equal to 0 and less than the value returned by [GetLength](../vs140/csimplestringt--getlength.md). Otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> will generate an exception.  
  
## Return Value  
 An <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that contains the character at the specified position in the string.  
  
## Remarks  
 Call this method to return the one character specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The overloaded subscript (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) operator is a convenient alias for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The null terminator is addressable without generating an exception by using <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. However, it is not counted by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and the value returned is 0.  
  
## Example  
 The following example demonstrates how to use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 [!code[NVC_ATLMFC_Utilities#80](../vs140/codesnippet/CPP/csimplestringt--getat_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)   
 [CSimpleStringT::GetLength](../vs140/csimplestringt--getlength.md)   
 [CSimpleStringT::operator](../vs140/csimplestringt--operator.md)