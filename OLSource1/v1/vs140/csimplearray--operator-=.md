---
title: "CSimpleArray::operator ="
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
  - "CSimpleArray.operator="
  - "CSimpleArray::operator="
  - "ATL::CSimpleArray::operator="
  - "ATL.CSimpleArray.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator =, arrays"
  - "operator=, arrays"
ms.assetid: 4f7013bd-7ef6-4317-87c3-a9e0d0324123
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleArray::operator =
Assignment operator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *src*  
 The array to copy.  
  
## Return Value  
 Returns a pointer to the updated <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Remarks  
 Copies all elements from the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object referenced by *src* into the current array object, replacing all existing data.  
  
## Example  
 [!code[NVC_ATL_Utilities#90](../vs140/codesnippet/CPP/csimplearray--operator-=_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## See Also  
 [CSimpleArray Class](../vs140/csimplearray-class.md)