---
title: "CStringT::operator ="
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
  - "ATL::CStringT::operator="
  - "CStringT.operator="
  - "CStringT::operator="
  - "ATL.CStringT.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator =, strings"
  - "operator=, strings"
  - "= operator, with specific MFC objects"
ms.assetid: 190f699b-9e52-4c5a-b9b2-9ed58febc1c6
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::operator =
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> assignment (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) operator reinitializes an existing <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object with new data.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A variant-type object to be copied into this <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A single character.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A null-terminated string to be copied into this <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to be copied into this <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>object.  
  
## Remarks  
 If the destination string (that is, the left side) is already large enough to store the new data, no new memory allocation is performed. You should be aware that memory exceptions can occur whenever you use the assignment operator because new storage is often allocated to hold the resulting <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#139](../vs140/codesnippet/CPP/cstringt--operator-=_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)