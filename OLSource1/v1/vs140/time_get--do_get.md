---
title: "time_get::do_get"
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
  - "std::time_get::do_get"
  - "time_get::do_get"
  - "time_get.do_get"
  - "std.time_get.do_get"
  - "do_get"
  - "xloctime/std::time_get::do_get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_get method"
ms.assetid: abf8b0d4-7d8e-42be-b47f-a8d715cbc280
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_get::do_get
Reads and converts character data to a time value. Accepts one conversion specifier and modifier.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An Input iterator that indicates the start of the sequence to convert.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An Input iterator that indicates the end of the sequence.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A stream object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A field in _Iosbase where appropriate bitmask elements are set to indicate errors.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to the time structure where the time is to be stored.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A conversion specifier character.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 An optional modifier character.  
  
## Return Value  
 Returns an iterator that designates the first unconverted element. A conversion failure sets <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 The virtual member function converts and skips one or more input elements in the range <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to determine the values stored in one or more members of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. A conversion failure sets <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. Otherwise, the function returns an iterator designating the first unconverted element.  
  
 The conversion specifiers are:  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> -- behaves the same as [get_weekday](../vs140/time_get--get_weekday.md).  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> -- behaves the same as [get_monthname](../vs140/time_get--get_monthname.md).  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> -- behaves the same as <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 99] to the value <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and stores <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> -- converts a decimal input field in the range [1, 31] and stores its value in <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> -- behaves the same as <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 23] and stores its value in <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 11] and stores its value in <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> -- converts a decimal input field in the range [1, 366] and stores its value in <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> -- converts a decimal input field in the range [1, 12] to the value <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and stores <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> in and stores its value in <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 59] and stores its value in <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> -- behaves the same as <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> -- converts "AM" or "am" to zero and "PM" or "PM" to 12 and adds this value to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> -- behaves the same as <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> -- behaves the same as <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 59] and stores its value in <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> -- behaves the same as <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 53] and stores its value in <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 6] and stores its value in <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 53] and stores its value in <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> -- behaves the same as <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> -- converts a decimal input field in the range [0, 99] to the value <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> and stores <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> -- behaves the same as [get_year](../vs140/time_get--get_year.md).  
  
 Any other conversion specifier sets <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> and returns. In this implementation, any modifier has no effect.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [time_get Class](../vs140/time_get-class.md)   
 [\<locale>](../vs140/-locale-.md)