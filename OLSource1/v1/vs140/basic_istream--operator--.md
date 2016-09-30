---
title: "basic_istream::operator&gt;&gt;"
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
  - "std.basic_istream.operator>>"
  - "basic_istream.operator>>"
  - "basic_istream::operator>>"
  - "istream/std::basic_istream::operator>>"
  - ">>"
  - "std::basic_istream::operator>>"
  - "operator>>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator>>"
  - "operator>>, streams"
  - "operator >>"
  - ">> operator, stream"
  - "operator >>, streams"
ms.assetid: 1b995193-33a7-40fd-baa9-26f80a40f81b
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::operator&gt;&gt;
Calls a function on the input stream or reads formatted data from the input stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A function pointer.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 An object of type **stream_buf**.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The value to read from the stream.  
  
## Return Value  
 The stream (**\*this**).  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> header also defines several global extraction operators. For more information, see [operator>> (\<istream>)](../vs140/operator-----istream--.md).  
  
 The first member function ensures that an expression of the form **istr** >> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> calls [ws](../vs140/ws.md)(**istr**), and then returns **\*this**. The second and third functions ensure that other manipulators, such as [hex](../vs140/hex.md), behave similarly. The remaining functions constitute the formatted input functions.  
  
 The function:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 extracts elements, if _*Strbuf* is not a null pointer, and inserts them in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Extraction stops on end of file. It also stops without extracting the element in question, if an insertion fails or throws an exception (which is caught but not rethrown). If the function extracts no elements, it calls [setstate](../vs140/basic_ios--setstate.md)(**failbit**). In any case, the function returns **\*this**.  
  
 The function:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 extracts a field and converts it to a Boolean value by calling [use_facet](../vs140/basic_filebuf--open.md) <<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>\<**Elem**, **InIt**>([getloc](../vs140/ios_base--getloc.md)). [get](../vs140/ios_base--getloc.md)(**InIt**( [rdbuf](../vs140/basic_ios--rdbuf.md)), <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>(0), **\*this**, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>). Here, **InIt** is defined as [istreambuf_iterator](../vs140/istreambuf_iterator-class.md)\<**Elem**, **Tr**>. The function returns **\*this**.  
  
 The functions:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 each extract a field and convert it to a numeric value by calling <CodeContentPlaceHolder>18\</CodeContentPlaceHolder><<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>\<**Elem**, **InIt**>(<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>). [get](../vs140/basic_istream--get.md)(**InIt**( <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>), <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>(0), **\*this**, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>). Here, **InIt** is defined as <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>\<**Elem**, **Tr**>, and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> has type **long***,* <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>*,* or **void \*** as needed.  
  
 If the converted value cannot be represented as the type of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, the function calls [setstate](../vs140/basic_ios--setstate.md)(**failbit**). In any case, the function returns **\*this**.  
  
 The functions:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 each extract a field and convert it to a numeric value by calling <CodeContentPlaceHolder>29\</CodeContentPlaceHolder><<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>\<**Elem**, **InIt**>(<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>). **get**(**InIt**( <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>), <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>(0), **\*this**, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>). Here, **InIt** is defined as <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>\<**Elem**, **Tr**>, and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> has type **double** or <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> as needed.  
  
 If the converted value cannot be represented as the type of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, the function calls <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>(**failbit**). In any case, it returns **\*this**.  
  
## Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Input  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [operator>> (\<istream>)](../vs140/operator-----istream--.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)