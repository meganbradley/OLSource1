---
title: "CSimpleStringT::operator ="
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
  - "CSimpleStringT::operator="
  - "CSimpleStringT.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator =, strings"
  - "operator=, strings"
ms.assetid: c12b2883-1673-4304-ad12-0e65571a6a8a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::operator =
Assigns a new value to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to an existing <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
## Remarks  
 If the destination string (the left side) is already large enough to store the new data, no new memory allocation is performed. Note that memory exceptions may occur whenever you use the assignment operator because new storage is often allocated to hold the resulting <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
## Example  
 The following example demonstrates the use of **CSimpleStringT::operator =**.  
  
 [!code[NVC_ATLMFC_Utilities#94](../vs140/codesnippet/CPP/csimplestringt--operator-=_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)   
 [CSimpleStringT::CSimpleStringT](../vs140/csimplestringt--csimplestringt.md)