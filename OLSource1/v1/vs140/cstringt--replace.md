---
title: "CStringT::Replace"
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
  - "ATL.CStringT.Replace"
  - "CStringT::Replace"
  - "ATL::CStringT::Replace"
  - "CStringT.Replace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Replace method"
ms.assetid: 4c6b2f1d-a4b1-4ed6-9d8f-fbc1226b3255
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::Replace
There are two versions of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.The first version replaces one or more copies of a substring by using another substring. Both substrings are null-terminated. The second version replaces one or more copies of a character by using another character. Both versions operate on the character data stored in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string to be replaced by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to a null-terminated string that replaces <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The character to be replaced by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The character replacing <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns the number of replaced instances of the character or substring, or zero if the string is not changed.  
  
## Remarks  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> can change the string length because <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> do not have to be the same length, and several copies of the old substring can be changed to the new one. The function performs a case-sensitive match.  
  
 Examples of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> instances are <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 For <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> works with ANSI or multibyte (MBCS) characters. For <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> works with wide characters.  
  
 For <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, the character data type is selected at compile time, based on whether the constants in the following table are defined.  
  
|Defined Constant|Character Data Type|  
|----------------------|-------------------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Wide characters|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Multi-byte characters|  
|Neither|Single-byte characters|  
|Both|Undefined|  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#200](../vs140/codesnippet/CPP/cstringt--replace_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)