---
title: "duration Class"
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
  - "chrono/std::chrono::duration"
dev_langs: 
  - "C++"
ms.assetid: 06b863b3-65be-4ded-a72e-6e1eb1531077
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# duration Class
Describes a type that holds a *time interval*, which is an elapsed time between two time points.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The template argument <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> describes the type that is used to hold the number of clock ticks in the interval. The template argument <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is an instantiation of [ratio](../vs140/-ratio-.md) that describes the size of the interval that each tick represents.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|duration::period Typedef|Represents a synonym for the template parameter <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.|  
|duration::rep Typedef|Represents a synonym for the template parameter <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[duration::duration Constructor](#duration__duration_constructor)|Constructs a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[duration::count Method](#duration__count_method)|Returns the number of clock ticks in the time interval.|  
|[duration::max Method](#duration__max_method)|Static. Returns the maximum allowable value of template parameter <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
|[duration::min Method](#duration__min_method)|Static. Returns the lowest allowable value of template parameter <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.|  
|[duration::zero Method](#duration__zero_method)|Static. In effect, returns <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>(0).|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[duration::operator-](#duration__operator-)|Returns a copy of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object together with a negated tick count.|  
|[duration::operator--](#duration__operator--)|Decrements the stored tick count.|  
|[duration::operator%= Operator](#duration__operator_eq)|Reduces the stored tick count modulo a specified value.|  
|[duration::operator*= Operator](#duration__operator_star_eq)|Multiplies the stored tick count by a specified value.|  
|[duration::operator/= Operator](#duration__operator__eq)|Divides the stored tick count by the tick count of a specified <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.|  
|[duration::operator+ Operator](#duration__operator_add)|Returns <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
|[duration::operator++ Operator](#duration__operator_add_add)|Increments the stored tick count.|  
|[duration::operator+= Operator](#duration__operator_add_eq)|Adds the tick count of a specified <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object to the stored tick count.|  
|[duration::operator-=](#duration__operator-_eq)|Subtracts the tick count of a specified <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object from the stored tick count.|  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
##  \<a name="duration__count_method">\</a>  duration::count Method  
 Retrieves the number of clock ticks in the time interval.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 The number of clock ticks in the time interval.  
  
##  \<a name="duration__duration_constructor">\</a>  duration::duration Constructor  
 Constructs a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 An arithmetic type to represent the number of ticks.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> template specialization to represent the tick period in units of seconds.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The number of ticks of default period.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The number of ticks of period specified by <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
### Remarks  
 The default constructor constructs an object that is uninitialized. Value initialization by using empty braces initializes an object that represents a time interval of zero clock ticks.  
  
 The second, one template argument constructor constructs an object that represents a time interval of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> clock ticks using a default period of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. To avoid round-off of tick counts, it is an error to construct a duration object from a representation type <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> that can be treated as a floating-point type when <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> cannot be treated as a floating-point type.  
  
 The third, two template argument constructor constructs an object that represents a time interval whose length is the time interval that is specified by <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. To avoid truncation of tick counts, it is an error to construct a duration object from another duration object whose type is *incommensurable* with the target type.  
  
 A duration type <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is *incommensurable* with another duration type <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> cannot be treated as a floating-point type and [ratio_divide\<D1::period, D2::period>::type::den](../vs140/-ratio-.md) is not 1.  
  
 Unless <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is implicitly convertible to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and either <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>*holds true* or <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>*holds false*, the second constructor does not participate in overload resolution. For more information, see [\<type_traits>](../vs140/-type_traits-.md).  
  
 Unless no overflow is induced in the conversion and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>*holds true*,  or both <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> equals 1 and <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>*holds false*, the third constructor does not participate in overload resolution. For more information, see [\<type_traits>](../vs140/-type_traits-.md).  
  
##  \<a name="duration__max_method">\</a>  duration::max Method  
 Static method that returns the upper bound for values of template parameter type <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 In effect, returns <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
##  \<a name="duration__min_method">\</a>  duration::min Method  
 Static method that returns the lower bound for values of template parameter type <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 In effect, returns <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
##  \<a name="duration__operator-">\</a>  duration::operator-  
 Returns a copy of the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object together with a negated tick count.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="duration__operator--">\</a>  duration::operator--  
 Decrements the stored tick count.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The first method returns <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
 The second method returns a copy of <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> that is made before the decrement.  
  
##  \<a name="duration__operator_eq">\</a>  duration::operator=  
 Reduces the stored tick count modulo a specified value.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 For the first method, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> represents a tick count. For the second method, <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object that contains a tick count.  
  
### Return Value  
 The <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object after the modulo operation is performed.  
  
##  \<a name="duration__operator_star_eq">\</a>  duration::operator*=  
 Multiplies the stored tick count by a specified value.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 A value of the type that is specified by <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.  
  
### Return Value  
 The <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object after the multiplication is performed.  
  
##  \<a name="duration__operator__eq">\</a>  duration::operator/=  
 Divides the stored tick count by a specified value.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 A value of the type that is specified by <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
### Return Value  
 The <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object after the division is performed.  
  
##  \<a name="duration__operator_add">\</a>  duration::operator+  
 Returns <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="duration__operator_add_add">\</a>  duration::operator++  
 Increments the stored tick count.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The first method returns <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
 The second method returns a copy of <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> that is made before the increment.  
  
##  \<a name="duration__operator_add_eq">\</a>  duration::operator+=  
 Adds the tick count of a specified <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> object to the stored tick count.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object after the addition is performed.  
  
##  \<a name="duration__operator-_eq">\</a>  duration::operator-=  
 Subtracts the tick count of a specified <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object from the stored tick count.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object after the subtraction is performed.  
  
##  \<a name="duration__zero_method">\</a>  duration::zero Method  
 Returns <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
##  \<a name="duration__operator_mod_eq">\</a>  duration::operator mod=  
 Reduces the stored tick count modulo Div or Div.count().  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 The divisor, which is either a duration object or a value that represents tick counts.  
  
### Remarks  
 The first member function reduces the stored tick count modulo Div and returns *this. The second member function reduces the stored tick count modulo Div.count() and returns \*this.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<chrono>](../vs140/-chrono-.md)   
 [duration_values Structure](../vs140/duration_values-structure.md)