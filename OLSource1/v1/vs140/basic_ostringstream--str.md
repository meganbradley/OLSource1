---
title: "basic_ostringstream::str"
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
  - "sstream/std::basic_ostringstream::str"
  - "basic_ostringstream.str"
  - "Str"
  - "str"
  - "std.basic_ostringstream.str"
  - "std::basic_ostringstream::str"
  - "basic_ostringstream::str"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "str method"
ms.assetid: d89d1d76-3c57-47c0-bad8-d1849f9bd0cf
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ostringstream::str
Sets or gets the text in a string buffer without changing the write position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The new string.  
  
## Return Value  
 Returns an object of class [basic_string](../vs140/basic_string-class.md)<**Elem**, **Tr**, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>>, whose controlled sequence is a copy of the sequence controlled by **\*this**.  
  
## Remarks  
 The first member function returns [rdbuf](../vs140/basic_ostringstream--rdbuf.md) -> [str](../vs140/basic_stringbuf--str.md). The second member function calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> -> **str**(<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
## Example  
 See [basic_stringbuf::str](../vs140/basic_stringbuf--str.md) for an example that uses **str**.  
  
## Requirements  
 **Header:** \<sstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ostringstream Class](../vs140/basic_ostringstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)