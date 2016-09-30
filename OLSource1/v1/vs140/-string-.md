---
title: "&lt;string&gt;"
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
  - "std::<string>"
  - "string/std::<string>"
  - "std.<string>"
  - "<string>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "string header"
ms.assetid: a2fb9d00-d7ae-4170-bfea-2dc337aa37cf
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;string&gt;
Defines the container template class <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and various supporting templates.  
  
 For more information about <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, see [basic_string Class.](../vs140/basic_string-class.md)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The C++ language and the Standard C++ Library support two types of strings:  
  
-   Null-terminated character arrays often referred to as C strings.  
  
-   Template class objects, of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, that handle all <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>-like template arguments.  
  
### Typedefs  
  
|||  
|-|-|  
|[string](../vs140/-string--typedefs.md#string)|A type that describes a specialization of the template class <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> with elements of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> as a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|[wstring](../vs140/-string--typedefs.md#wstring)|A type that describes a specialization of the template class <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> with elements of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> as a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|[u16string](../vs140/-string--typedefs.md#u16string)|A type that describes a specialization of the template class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> based on elements of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
|[u32string](../vs140/-string--typedefs.md#u32string)|A type that describes a specialization of the template class <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> based on elements of type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.|  
  
### Operators  
  
|||  
|-|-|  
|[operator+](../vs140/-string--operators.md#operator_add)|Concatenates two string objects.|  
|[operator!=](../vs140/-string--operators.md#operator_neq)|Tests if the string object on the left side of the operator is not equal to the string object on the right side.|  
|[operator==](../vs140/-string--operators.md#operator_eq_eq)|Tests if the string object on the left side of the operator is equal to the string object on the right side.|  
|[operator<](../vs140/-string--operators.md#operator_lt_)|Tests if the string object on the left side of the operator is less than to the string object on the right side.|  
|[operator<=](../vs140/-string--operators.md#operator_lt__eq)|Tests if the string object on the left side of the operator is less than or equal to the string object on the right side.|  
|[operator<\<](../vs140/-string--operators.md#operator_lt__lt_)|A template function that inserts a string into the output stream.|  
|[operator>](../vs140/-string--operators.md#operator_gt_)|Tests if the string object on the left side of the operator is greater than to the string object on the right side.|  
|[operator>=](../vs140/-string--operators.md#operator_gt__eq)|Tests if the string object on the left side of the operator is greater than or equal to the string object on the right side.|  
|[operator>>](../vs140/-string--operators.md#operator_gt__gt_)|A template function that extracts a string from the input stream.|  
  
### Specialized Template Functions  
  
|||  
|-|-|  
|[swap](../vs140/-string--functions.md#swap)|Exchanges the arrays of characters of two strings.|  
|[stod](../vs140/-string--functions.md#stod)|Converts a character sequence to a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|[stof](../vs140/-string--functions.md#stof)|Converts a character sequence to a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.|  
|[stoi](../vs140/-string--functions.md#stoi)|Converts a character sequence to an integer.|  
|[stold](../vs140/-string--functions.md#stold)|Converts a character sequence to a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.|  
|[stoll](../vs140/-string--functions.md#stoll)|Converts a character sequence to a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.|  
|[stoul](../vs140/-string--functions.md#stoul)|Converts a character sequence to an <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
|[stoull](../vs140/-string--functions.md#stoull)|Converts a character sequence to an <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
|[to_string](../vs140/-string--functions.md#to_string)|Converts a value to a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
|[to_wstring](../vs140/-string--functions.md#to_wstring)|Converts a value to a wide <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.|  
  
### Functions  
  
|||  
|-|-|  
|[getline](../vs140/-string--functions.md#getline_template_function)|Extract strings from the input stream line by line.|  
  
### Classes  
  
|||  
|-|-|  
|[basic_string Class](../vs140/basic_string-class.md)|A template class that describes objects that can store a sequence of arbitrary character-like objects.|  
|[char_traits struct](../vs140/char_traits-struct.md)|A template class that describes attributes associated with a character of type CharType|  
  
### Specializations  
  
|||  
|-|-|  
|[char_traits\<char> struct](../vs140/char_traits-char--struct.md)|A struct that is a specialization of the template struct <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>\<CharType> to an element of type <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.|  
|[char_traits\<wchar_t> struct](../vs140/char_traits-wchar_t--struct.md)|A struct that is a specialization of the template struct <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>\<CharType> to an element of type <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
|[char_traits\<char16_t> struct](../vs140/char_traits-char16_t--struct.md)|A struct that is a specialization of the template struct <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>\<CharType> to an element of type <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.|  
|[char_traits\<char32_t> struct](../vs140/char_traits-char32_t--struct.md)|A struct that is a specialization of the template struct <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>\<CharType> to an element of type <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.|  
  
## Requirements  
  
-   **Header:** \<string>  
  
-   **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)