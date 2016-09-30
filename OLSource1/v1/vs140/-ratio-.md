---
title: "&lt;ratio&gt;"
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
  - "ratio/std::mega"
  - "ratio/std::peta"
  - "ratio/std::ratio_greater"
  - "ratio/std::micro"
  - "ratio/std::ratio_add"
  - "ratio/std::ratio_not_equal"
  - "ratio/std::hecto"
  - "ratio/std::nano"
  - "ratio/std::ratio_less_equal"
  - "ratio/std::ratio_less"
  - "ratio/std::centi"
  - "ratio/std::ratio_greater_equal"
  - "ratio/std::ratio_subtract"
  - "<ratio>"
  - "ratio/std::atto"
  - "ratio/std::tera"
  - "ratio/std::milli"
  - "ratio/std::ratio_multiply"
  - "ratio/std::kilo"
  - "ratio/std::ratio_divide"
  - "ratio/std::giga"
  - "ratio/std::pico"
  - "ratio/std::femto"
  - "ratio/std::ratio_equal"
  - "ratio/std::ratio"
  - "ratio/std::exa"
  - "ratio/std::deci"
  - "ratio/std::deca"
dev_langs: 
  - "C++"
ms.assetid: 8543e912-2d84-45ea-b3c0-bd7bfacee405
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;ratio&gt;
Include the standard header \<ratio> to define constants and templates that are used to store and manipulate rational numbers at compile time.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### ratio Structure  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The [ratio Structure](assetId:///3f7961f4-802b-4251-b3c3-090ef91c0dba) defines the static constants <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> such that <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> / <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> == N / D and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> have no common factors. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> / <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that is represented by the template class. Therefore, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> designates the instantiation <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> for which <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> == N0 and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> == D0.  
  
### Specializations  
 \<ratio> also defines specializations of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> that have the following form.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 Each specialization takes two template parameters that must also be specializations of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. The value of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is determined by an associated logical operation.  
  
|Name|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder> Value|  
|----------|------------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|  
  
### typedefs  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)