---
title: "time_point Class"
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
  - "chrono/std::chrono::time_point"
dev_langs: 
  - "C++"
ms.assetid: 18be1e52-57b9-489a-8a9b-f58894f0aaad
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_point Class
A <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> describes a type that represents a point in time. It holds an object of type [duration](../vs140/duration-class.md) that stores the elapsed time since the epoch that is represented by the template argument <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Synonym for the template parameter <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Synonym for the template parameter <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Synonym for the nested type name <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Synonym for the nested type name <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[time_point::time_point Constructor](#time_point__time_point_constructor)|Constructs a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[time_point::max Method](#time_point__max_method)|Specifies the upper limit for <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.|  
|[time_point::min Method](#time_point__min_method)|Specifies the lower limit for <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
|[time_point::time_since_epoch Method](#time_point__time_since_epoch_method)|Returns the stored <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> value.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[time_point::operator+= Operator](#time_point__operator_add_eq)|Adds a specified value to the stored duration.|  
|[time_point::operator-=](#time_point__operator-_eq)|Subtracts a specified value from the stored duration.|  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
##  \<a name="time_point__max_method">\</a>  time_point::max Method  
 Static method that returns the upper bound for values of type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 In effect, returns <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
##  \<a name="time_point__min_method">\</a>  time_point::min Method  
 Static method that returns the lower bound for values of type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 In effect, returns <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
##  \<a name="time_point__operator_add_eq">\</a>  time_point::operator+=  
 Adds a specified value to the stored [duration](../vs140/duration-class.md) value.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object after the addition is performed.  
  
##  \<a name="time_point__operator-_eq">\</a>  time_point::operator-=  
 Subtracts a specified value from the stored [duration](../vs140/duration-class.md) value.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object after the subtraction is performed.  
  
##  \<a name="time_point__time_point_constructor">\</a>  time_point::time_point Constructor  
 Constructs a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A [duration](../vs140/duration-class.md) object.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The first constructor constructs an object whose stored <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> value is equal to [duration::zero](../vs140/duration-class.md#duration__zero_method).  
  
 The second constructor constructs an object whose stored duration value is equal to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. Unless <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>*holds true*, the second constructor does not participate in overload resolution. For more information, see [\<type_traits>](../vs140/-type_traits-.md).  
  
 The third constructor initializes its <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> value by using <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
##  \<a name="time_point__time_since_epoch_method">\</a>  time_point::time_since_epoch Method  
 Retrieves the stored [duration](../vs140/duration-class.md) value.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<chrono>](../vs140/-chrono-.md)