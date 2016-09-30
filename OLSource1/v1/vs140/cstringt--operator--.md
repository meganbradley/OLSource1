---
title: "CStringT::operator +"
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
  - "ATL::CStringT::operator+"
  - "CStringT::operator+"
  - "CStringT.operator+"
  - "ATL.CStringT.operator+"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "+ operator, with specific objects"
ms.assetid: 39569564-290e-4b6f-a829-2919556bee32
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::operator +
Concatenates two strings or a character and a string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An ANSI or Unicode character to concatenate with a string.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An ANSI or Unicode character to concatenate with a string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to concatenate with a string or character.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to concatenate with a string or character.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string to concatenate with a string or character.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A pointer to a string to concatenate with a string or character.  
  
## Remarks  
 There are seven overload forms of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function. The first version concatenates two existing <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> objects. The next two concatenate a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object and a null-terminated string. The next two concatenate a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object and an ANSI character. The last two concatenate a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object and a Unicode character.  
  
> [!NOTE]
>  Although it is possible to create <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> instances that contain embedded null characters, we recommend against it. Calling methods and operators on <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> objects that contain embedded null characters can produce unintended results.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#140](../vs140/codesnippet/CPP/cstringt--operator--_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)