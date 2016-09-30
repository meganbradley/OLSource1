---
title: "operator&gt;&gt; (&lt;istream&gt;)"
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
  - "std::operator>>"
  - "std::>>"
  - "std.>>"
  - "istream/std::operator>>"
  - ">>"
  - "std.operator>>"
  - "operator>>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator>>"
  - "operator>>, streams"
  - ">> operator, stream"
  - "operator >>, streams"
ms.assetid: 22be9a65-8e9c-4be0-a9cf-e4c442ef33b6
caps.latest.revision: 26
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt;&gt; (&lt;istream&gt;)
Extracts characters and strings from the stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A character.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A stream.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 A string.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A type.  
  
## Return Value  
 The stream  
  
## Remarks  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class also defines several extraction operators. For more information, see [basic_istream::operator>>](../vs140/basic_istream--operator--.md).  
  
 The template function:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 extracts up to *N* - 1 elements and stores them in the array starting at _*Str*. If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.[width](../vs140/ios_base--width.md) is greater than zero, *N* is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.**width**; otherwise, it is the size of the largest array of **Elem** that can be declared. The function always stores the value **Elem()** after any extracted elements it stores. Extraction stops early on end of file, on a character with value **Elem**(0) (which is not extracted), or on any element (which is not extracted) that would be discarded by [ws](../vs140/ws.md). If the function extracts no elements, it calls <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.[setstate](../vs140/basic_ios--setstate.md)(**failbit**). In any case, it calls <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.**width**(0) and returns <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 **Security Note** The null-terminated string being extracted from the input stream must not exceed the size of the destination buffer <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
 The template function:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 extracts an element, if it is possible, and stores it in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. Otherwise, it calls **is**.[setstate](../vs140/basic_ios--setstate.md)(**failbit**). In any case, it returns <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 The template function:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 returns <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> >> (<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> **\***)<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 The template function:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 returns <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> >> (**char&**)<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 The template function:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 returns <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> >> (**char \***)<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 The template function:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 returns <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> >> (**char&**)<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
 The template function:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 returns <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> (and converts an <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> to an <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> in the process).  
  
## Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## Input  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream::operator>>](../vs140/basic_istream--operator--.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)