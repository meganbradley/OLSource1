---
title: "ctype::toupper"
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
  - "std.ctype.toupper"
  - "xlocale/std::ctype::toupper"
  - "std::ctype::toupper"
  - "ctype::toupper"
  - "ctype.toupper"
  - "toupper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "toupper method"
ms.assetid: 4f7668d5-0e58-4db4-8f73-05fecb67d140
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::toupper
Converts a character or a range of characters to upper case.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The character to be converted to uppercase.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the first character in the range of characters whose cases are to be converted.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range of characters whose cases are to be converted.  
  
## Return Value  
 The first member function returns the uppercase form of the parameter <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If no uppercase form exists, it returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 The second member function returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 The first member function returns [do_toupper](../vs140/ctype--do_toupper.md)(<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>). The second member function returns [do_toupper](../vs140/ctype--do_toupper.md)(<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The uppercase string is: HELLO, MY NAME IS JOHN**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)