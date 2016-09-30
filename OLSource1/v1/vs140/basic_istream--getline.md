---
title: "basic_istream::getline"
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
  - "GetLine"
  - "getline"
  - "basic_istream.getline"
  - "std::basic_istream::getline"
  - "basic_istream::getline"
  - "istream/std::basic_istream::getline"
  - "std.basic_istream.getline"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "getline method"
ms.assetid: 9a379be0-0786-4413-9c61-590597f56f62
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::getline
Gets a line from the input stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of characters to read from **strbuf**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The character that should terminate the read if it is encountered before <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A string in which to write.  
  
## Return Value  
 The stream (**\*this**).  
  
## Remarks  
 The first of these unformatted input functions returns **getline**(_*Str*, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>('<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>**n**')).  
  
 The second function extracts up to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> - 1 elements and stores them in the array beginning at _*Str*. It always stores the string termination character after any extracted elements it stores. In order of testing, extraction stops:  
  
-   At end of file.  
  
-   After the function extracts an element that compares equal to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, in which case the element is neither put back nor appended to the controlled sequence.  
  
-   After the function extracts <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> - 1 elements.  
  
 If the function extracts no elements or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> - 1 elements, it calls [setstate](../vs140/basic_ios--setstate.md)(**failbit**). In any case, it returns **\*this**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>1**   
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)