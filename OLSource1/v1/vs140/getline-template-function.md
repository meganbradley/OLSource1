---
title: "getline Template Function"
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
  - "std.getline"
  - "basic_istream.getline"
  - "std::basic_istream::getline"
  - "basic_istream::getline"
  - "istream/std::basic_istream::getline"
  - "string/std::getline"
  - "std::getline"
  - "std.basic_istream.getline"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "getline method"
  - "getline"
  - "getline function"
ms.assetid: d8c3bf01-8c1d-4f40-8cca-1401e165b49e
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# getline Template Function
Extract strings from the input stream line-by-line.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The input stream from which a string is to be extracted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The string into which are read the characters from the input stream.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The line delimiter.  
  
## Return Value  
 The input stream <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 The pair of function signatures marked <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> extract characters from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> until <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is found, storing them in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The pair of function signatures marked <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> use newline as the default line delimiter and behave as **getline**(<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>('<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>')).  
  
 The second function of each pair is an analog to the first one to support [rvalue references](../vs140/lvalues-and-rvalues--visual-c---.md).  
  
 Extraction stops when one of the following occurs:  
  
-   At end-of-file, in which case the internal state flag of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
-   After the function extracts an element that compares equal to **delim**, in which case the element is neither put back nor appended to the controlled sequence.  
  
-   After the function extracts <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>[max_size](../vs140/basic_string--max_size.md) elements, in which case the internal state flag of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
-   Some other error other than those previously listed, in which case the internal state flag of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 For information about internal state flags, see [ios_base::iostate](../vs140/ios_base--iostate.md).  
  
 If the function extracts no elements, the internal state flag of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. In any case, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 If an exception is thrown, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> are left in a valid state.  
  
## Example  
 The following code demonstrates <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> in two modes: first with the default delimiter (newline) and second with a whitespace as delimiter. The end-of-file character (CTRL-Z on the keyboard) is used to control termination of the while loops. This sets the internal state flag of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, which must be cleared with [basic_ios::clear()](../vs140/basic_ios--clear.md) before the second while loop will work properly.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 **Enter a sentence, press ENTER between sentences. (Ctrl-Z to stop):This is test one.New line.^ZThe following input was stored with newline delimiter:This is test one.New line.This is test two.New line.^ZThe following input was stored with whitespace as delimiter:Thisistesttwo.Newline.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)   
 [\<string>](../vs140/-string-.md)