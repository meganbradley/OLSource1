---
title: "time_get::get"
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
  - "time_get.get"
  - "get"
  - "std.time_get.get"
  - "std::time_get::get"
  - "xloctime/std::time_get::get"
  - "time_get::get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get method"
ms.assetid: 260b29b1-77e0-49f0-aea1-0a6978b02bfb
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_get::get
Reads from a source of character data and converts that data to a time that is stored in a time struct. The first function accepts one conversion specifier and modifier, the second accepts several.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Input iterator that indicates where the sequence to be converted starts.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Input iterator that indicates the end of the sequence to be converted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The stream.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The appropriate bitmask elements are set for the stream state to indicate errors.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to the time structure where the time is to be stored.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A conversion specifier character.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 An optional modifier character.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Points to where the format directives start.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Points to the end of the format directives.  
  
## Return Value  
 Returns an iterator to the first character after the data that was used to assign the time struct *_Pt.  
  
## Remarks  
 The first member function returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 The second member function calls <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> under the control of the format delimited by <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. It treats the format as a sequence of fields, each of which determines the conversion of zero or more input elements delimited by <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. It returns an iterator designating the first unconverted element. There are three kinds of fields:  
  
 A per cent (%) in the format, followed by an optional modifier <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> in the set [EOQ#], followed by a conversion specifier <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, replaces <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> with the value returned by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. A conversion failure sets <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and returns.  
  
 A whitespace element in the format skips past zero or more input whitespace elements.  
  
 Any other element in the format must match the next input element, which is skipped. A match failure sets <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and returns.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [Time_get::do_get](../vs140/time_get--do_get.md)   
 [time_get Class](../vs140/time_get-class.md)   
 [\<locale>](../vs140/-locale-.md)