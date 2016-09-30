---
title: "CSimpleStringT::CSimpleStringT"
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
  - "CSimpleStringT<BaseType>::CSimpleStringT"
  - "CSimpleStringT::CSimpleStringT"
  - "ATL::CSimpleStringT::CSimpleStringT"
  - "ATL.CSimpleStringT.CSimpleStringT"
  - "ATL::CSimpleStringT<BaseType>::CSimpleStringT"
  - "CSimpleStringT.CSimpleStringT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSimpleStringT class, constructor"
ms.assetid: 97999818-a7ec-42f4-b8b5-946eff498559
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::CSimpleStringT
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object to be copied into this <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to an array of characters of length <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, not null terminated.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A null-terminated string to be copied into this <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A count of the number of characters in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A pointer to the memory manager of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object. For more information about <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and memory management for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, see [Memory Management and CStringT](../vs140/memory-management-with-cstringt.md).  
  
## Remarks  
 Construct a new <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object. Because the constructors copy the input data into new allocated storage, memory exceptions may result.  
  
## Example  
 The following example demonstrates the use of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> by using the ATL <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a commonly used specialization of the class template <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 A specialization defines a class by putting specific type parameters into a class template. For more information, see [Class Template Instantiation](../vs140/class-template-instantiation.md).  
  
 [!code[NVC_ATLMFC_Utilities#77](../vs140/codesnippet/CPP/csimplestringt--csimplestringt_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)