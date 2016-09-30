---
title: "basic_istream::read"
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
  - "istream/std::basic_istream::read"
  - "std::basic_istream::read"
  - "basic_istream.read"
  - "read"
  - "basic_istream::read"
  - "std.basic_istream.read"
  - "Read"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "read method"
ms.assetid: c74acbf9-da14-424d-a2a6-bb05a6a1bc0c
caps.latest.revision: 26
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::read
Reads a specified number of characters from the stream and stores them in an array.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The array in which to read the characters.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of characters to read.  
  
## Return Value  
 The stream (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
## Remarks  
 The unformatted input function extracts up to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> elements and stores them in the array beginning at _<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Extraction stops early on end of file, in which case the function calls [setstate](../vs140/basic_ios--setstate.md)(<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>). In any case, it returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>Type 'abcde': abcde**  
**abcde**   
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)