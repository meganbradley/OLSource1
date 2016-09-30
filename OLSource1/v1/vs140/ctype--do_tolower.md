---
title: "ctype::do_tolower"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std::ctype::do_tolower"
  - "ctype.do_tolower"
  - "ctype::do_tolower"
  - "std.ctype.do_tolower"
  - "xlocale/std::ctype::do_tolower"
  - "do_tolower"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_tolower method"
ms.assetid: 593cec79-c7c8-4b15-8068-8780f4f80581
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::do_tolower
A virtual function called to convert a character or a range of characters to lower case.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The character to be converted to lower case.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the first character in the range of characters whose cases are to be converted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range of characters whose cases are to be converted.  
  
## Return Value  
 The first protected member function returns the lowercase form of the parameter <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If no lowercase form exists, it returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The second protected member function returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 The second protected member template function replaces each element <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> [<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>], for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in the interval [0, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>), with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> [<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>]).  
  
## Example  
 See the example for [tolower](../vs140/ctype--tolower.md), which calls <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)