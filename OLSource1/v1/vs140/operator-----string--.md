---
title: "operator&gt;&gt; (&lt;string&gt;)"
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
  - "string/std::operator>>"
  - ">>"
  - "std.operator>>"
  - "operator>>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - ">> operator, strings"
  - "operator>>"
  - "operator >>, strings"
  - "operator>>, strings"
ms.assetid: 68aefbcf-65c1-4800-bbf7-ba47314e58a4
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt;&gt; (&lt;string&gt;)
A template function that reads a string from an input stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The input stream used to extract the sequence  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The string that is being extracted from the input stream.  
  
## Return Value  
 Reads the value of the specified string from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and returns it into <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
## Remarks  
 The operator skips the leading white spaces unless the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> flag is set. It reads all the following characters until the next character is a white space or the end of the file is reached.  
  
 The template function overloads **operator>>** to replace the sequence controlled by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> with a sequence of elements extracted from the stream <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Extraction stops:  
  
-   At end of file.  
  
-   After the function extracts <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.**width** elements, if that value is nonzero.  
  
 After the function extracts <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.[max_size](../vs140/basic_string--max_size.md) elements.  
  
-   After the function extracts an element *ch* for which [use_facet](../vs140/basic_filebuf--open.md)<**ctype**\<**CharType**> >( <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>). **is**( **ctype**\<**CharType**>::**space**, *ch*) is true, in which case the character is put back.  
  
 If the function extracts no elements, it calls [setstate](../vs140/basic_ios--setstate.md)(<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>). In any case, it calls **istr**.**width**(0) and returns ***this**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [string::operator>>](../vs140/string--operator--.md)