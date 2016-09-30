---
title: "CSimpleStringT::operator +="
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
  - "CSimpleStringT.operator+="
  - "CSimpleStringT::operator+="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator +=, strings"
  - "operator+=, strings"
ms.assetid: c45c53e5-a4d6-45fb-a49f-9484fd61d96d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleStringT::operator +=
Joins a new string or character to the end of an existing string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to an existing <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 *ch*  
 The character to be appended.  
  
## Remarks  
 The operator accepts another <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object or a character. Note that memory exceptions may occur whenever you use this concatenation operator because new storage may be allocated for characters added to this <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
## Example  
 The following example demonstrates the use of **CSimpleStringT::operator +=**.  
  
 [!code[NVC_ATLMFC_Utilities#93](../vs140/codesnippet/CPP/csimplestringt--operator--=_1.cpp)]  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)