---
title: "ctype::tolower"
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
  - "tolower"
  - "ctype.tolower"
  - "std.ctype.tolower"
  - "std::ctype::tolower"
  - "xlocale/std::ctype::tolower"
  - "ctype::tolower"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tolower method"
ms.assetid: 364c6bd3-b65a-45d0-9dcc-3fd05d08ed6f
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::tolower
Converts a character or a range of characters to lower case.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The character to be converted to lower case.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the first character in the range of characters whose cases are to be converted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range of characters whose cases are to be converted.  
  
## Return Value  
 The first member function returns the lowercase form of the parameter <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If no lowercase form exists, it returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 The second member function returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 The first member function returns [do_tolower](../vs140/ctype--do_tolower.md)(<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>). The second member function returns [do_tolower](../vs140/ctype--do_tolower.md)(<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The lowercase string is: hello, my name is john**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)