---
title: "CSimpleArrayEqualHelperFalse Class"
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
  - "ATL.CSimpleArrayEqualHelperFalse<T>"
  - "ATL::CSimpleArrayEqualHelperFalse"
  - "ATL.CSimpleArrayEqualHelperFalse"
  - "ATL::CSimpleArrayEqualHelperFalse<T>"
  - "CSimpleArrayEqualHelperFalse"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSimpleArrayEqualHelperFalse class"
ms.assetid: 6918af6f-d23d-49eb-8482-c44272f5ffeb
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleArrayEqualHelperFalse Class
This class is a helper for the [CSimpleArray](../vs140/csimplearray-class.md) class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A derived class.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSimpleArrayEqualHelperFalse::IsEqual](../vs140/csimplearrayequalhelperfalse--isequal.md)|(Static) Returns false.|  
  
## Remarks  
 This traits class is a complement to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class. It always returns false, and in addition, will call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> with an argument of false if it is ever referenced. In situations where the equality test is not sufficiently defined, this class allows an array containing elements to operate correctly for most methods but fail in a well-defined manner for methods that depend on comparisons such as [CSimpleArray::Find](../vs140/csimplearray--find.md).  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
##  \<a name="csimplearrayequalhelperfalse__isequal">\</a>  CSimpleArrayEqualHelperFalse::IsEqual  
 Returns false.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 Returns false.  
  
### Remarks  
 This method always returns false, and will call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> with an argument of false if referenced. The purpose of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is to force methods using comparisons to fail in a well-defined manner when equality tests have not been adequately defined.  
  
## See Also  
 [CSimpleArrayEqualHelper Class](../vs140/csimplearrayequalhelper-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)