---
title: "basic_istream::get"
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
  - "get"
  - "std.basic_istream.get"
  - "basic_istream.get"
  - "istream/std::basic_istream::get"
  - "std::basic_istream::get"
  - "basic_istream::get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get method"
ms.assetid: 15bcbad1-1754-410e-b248-c18e2e097331
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::get
Reads one or more characters from the input stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of characters to read from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The character that should terminate the read if it is encountered before <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A string in which to write.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A character to get.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A buffer in which to write.  
  
## Return Value  
 The parameterless form of get returns the element read as an integer or end of file. The remaining forms return the stream (*<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).  
  
## Remarks  
 The first of these unformatted input functions extracts an element, if possible, as if by returning <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>-><CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Otherwise, it returns **traits_type::**[eof](../vs140/char_traits--eof.md). If the function extracts no element, it calls [setstate](../vs140/basic_ios--setstate.md)(**failbit**).  
  
 The second function extracts the [int_type](../vs140/basic_ios--int_type.md) element <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> the same way. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> compares equal to **traits_type::eof**, the function calls <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>(**failbit**). Otherwise, it stores **traits_type::**[to_char_type](../vs140/char_traits--to_char_type.md)(<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>) in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The function returns **\*this**.  
  
 The third function returns **get**(_*Str*, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>('\\**n**')).  
  
 The fourth function extracts up to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> - 1 elements and stores them in the array beginning at _*Str*. It always stores <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> after any extracted elements it stores. In order of testing, extraction stops:  
  
-   At end of file.  
  
-   After the function extracts an element that compares equal to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, in which case the element is put back to the controlled sequence.  
  
-   After the function extracts <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> - 1 elements.  
  
 If the function extracts no elements, it calls <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>(**failbit**). In any case, it returns **\*this**.  
  
 The fifth function returns **get**(**strbuf**, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>('\\**n**')).  
  
 The sixth function extracts elements and inserts them in **strbuf**. Extraction stops on end-of-file or on an element that compares equal to _*Delim,* which is not extracted. It also stops, without extracting the element in question, if an insertion fails or throws an exception (which is caught but not rethrown). If the function extracts no elements, it calls <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>(**failbit**). In any case, the function returns **\*this**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>11**   
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)