---
title: "CSimpleStringT::operator"
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
  - "ATL::CSimpleStringT::operator[]"
  - "CSimpleStringT<BaseType>::operator[]"
  - "CSimpleStringT::operator[]"
  - "ATL::CSimpleStringT<BaseType>::operator[]"
  - "CSimpleStringT.operator[]"
  - "ATL.CSimpleStringT<BaseType>.operator[]"
  - "ATL.CSimpleStringT.operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator[], strings"
  - "operator [], strings"
ms.assetid: 88c1c714-f56e-4ab4-bb5f-41bc7921ccbc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::operator
Call this function to access a single character of the character array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Zero-based index of a character in the string.  
  
## Remarks  
 The overloaded subscript (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) operator returns a single character specified by the zero-based index in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. This operator is a convenient substitute for the [GetAt](../vs140/csimplestringt--getat.md) member function.  
  
> [!NOTE]
>  You can use the subscript (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) operator to get the value of a character in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, but you cannot use it to change the value of a character in a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Example  
 The following example demonstrates the use of **CSimpleStringT::operator []**.  
  
 [!code[NVC_ATLMFC_Utilities#95](../vs140/codesnippet/CPP/csimplestringt--operator_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)   
 [CSimpleStringT::SetAt](../vs140/csimplestringt--setat.md)