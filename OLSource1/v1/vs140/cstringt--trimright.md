---
title: "CStringT::TrimRight"
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
  - "ATL.CStringT.TrimRight"
  - "TrimRight"
  - "CStringT::TrimRight"
  - "ATL::CStringT::TrimRight"
  - "CStringT.TrimRight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TrimRight method"
ms.assetid: e301c416-c9c4-4896-9cb3-336b056b2019
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::TrimRight
Trims trailing characters from the string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The target character to be trimmed.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a string containing the target characters to be trimmed. All trailing occurrences of characters in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> will be trimmed from the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
## Return Value  
 Returns the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that contains the trimmed string.  
  
## Remarks  
 Removes trailing occurrences of one of the following:  
  
-   The character specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
-   All characters found in the string specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
-   Whitespace.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> version accepts one character parameter and removes all copies of that character from the end of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> string data. It starts from the end of the string and works toward the front. It stops when it finds a different character or when <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> runs out of character data.  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> version accepts a null-terminated string that contains all the different characters to search for. It removes all copies of those characters in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object. It starts at the end of the string and works toward the front. It stops when it finds a character that is not in the target string, or when <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> runs out of character data. It does not try to match the whole target string to a substring at the end of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> version requires no parameters. It trims any trailing whitespace characters from the end of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> string. Whitespace characters can be line breaks, spaces, or tabs.  
  
-  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#138](../vs140/codesnippet/CPP/cstringt--trimright_1.cpp)]  
  
## Output  
 The output from this example is as follows:  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)   
 [CStringT::Trim](../vs140/cstringt--trim.md)   
 [CStringT::TrimLeft](../vs140/cstringt--trimleft.md)