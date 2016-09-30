---
title: "time_put::put"
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
  - "xloctime/std::time_put::put"
  - "put"
  - "time_put::put"
  - "time_put.put"
  - "std.time_put.put"
  - "std::time_put::put"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put method"
ms.assetid: dc87bd4a-ea57-4ce8-923b-10f6bab71849
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_put::put
Outputs time and date information as a sequence of **CharType**s.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An output iterator where the sequence of characters representing time and date are to be inserted.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Unused.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The character of type **CharType** used for spacing.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The time and date information being output.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The format of the output. See [strftime, wcsftime, _strftime_l, _wcsftime_l](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md) for valid values.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A modifier for the format. See [strftime, wcsftime, _strftime_l, _wcsftime_l](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md) for valid values.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The beginning of the formatting string for the output. See [strftime, wcsftime, _strftime_l, _wcsftime_l](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md) for valid values.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The end of the formatting string for the output. See [strftime, wcsftime, _strftime_l, _wcsftime_l](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md) for valid values.  
  
## Return Value  
 An iterator to the first position after the last element inserted.  
  
## Remarks  
 The first member function returns [do_put](../vs140/time_put--do_put.md)(<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>). The second member function copies to \*<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> ++ any element in the interval [<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>) other than a percent (%). For a percent followed by a character *C* in the interval [<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>), the function instead evaluates <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, *C*, 0) and skips past *C*. If, however, *C* is a qualifier character from the set EOQ#, followed by a character <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> in the interval [<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>), the function instead evaluates <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, *C*) and skips past <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **num_put( ) = x: 05:30:40 07/04/00**  
**strftime( ) = x: 05:30:40 07/04/00**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [time_put Class](../vs140/time_put-class.md)