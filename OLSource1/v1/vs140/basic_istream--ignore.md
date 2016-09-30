---
title: "basic_istream::ignore"
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
  - "std::basic_istream::ignore"
  - "ignore"
  - "std.basic_istream.ignore"
  - "Ignore"
  - "basic_istream::ignore"
  - "basic_istream.ignore"
  - "istream/std::basic_istream::ignore"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ignore method"
ms.assetid: 24c9497d-50f8-4450-91d0-c14d97dc23fb
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::ignore
Causes a number of elements to be skipped from the current read position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of elements to skip from the current read position.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The element that, if encountered before count, causes **ignore** to return and allowing all elements after <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to be read.  
  
## Return Value  
 The stream (**\*this**).  
  
## Remarks  
 The unformatted input function extracts up to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> elements and discards them. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> equals **numeric_limits\<int>::max**, however, it is taken as arbitrarily large. Extraction stops early on end of file or on an element <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> such that **traits_type::**[to_int_type](../vs140/char_traits--to_int_type.md)(<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) compares equal to _*Delim* (which is also extracted). The function returns **\*this**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>def**   
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)