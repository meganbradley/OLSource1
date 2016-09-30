---
title: "&lt;chrono&gt;"
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
  - "chrono/std::chrono::nanoseconds"
  - "chrono/std::chrono::minutes"
  - "chrono/std::chrono::seconds"
  - "<chrono>"
  - "chrono/std::chrono::hours"
  - "chrono/std::chrono::milliseconds"
  - "chrono/std::chrono::microseconds"
dev_langs: 
  - "C++"
ms.assetid: 844de749-f306-482e-89bc-6f53c99c8324
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;chrono&gt;
Include the standard header \<chrono> to define classes and functions that represent and manipulate time durations and time instants.  
  
 **(Visual Studio 2015:)** The implementation of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> has changed to meet the C++ Standard requirements for steadiness and monotonicity. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is now based on QueryPerformanceCounter() and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is now a typedef for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. As a result, in Visual C++ <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is now a typedef for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; however, this is not necessarily the case for other implementations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Literals  
 Literals in the \<chrono> header are members of the literals::chrono_literals inline namespace. For more information, see [chrono literals](../vs140/-chrono--functions.md#chrono_literals).  
  
|||  
|-|-|  
|operator "" h(unsigned long long Val) operator "" h(long double Val)|Specifies that the value represents hours.|  
|operator "" min(unsigned long long Val)  operator "" min(long double Val)|Specifies that the value represents minutes.|  
|operator "" s(unsigned long long Val)operator "" s(long double Val)|Specifies that the value represents seconds.|  
|operator "" ms(unsigned long long Val)operator "" ms(long double Val)|Specifies that the value represents milliseconds.|  
|operator "" us(unsigned long long Val)operator "" us(long double Val)|Specifies that the value represents microseconds.|  
|operator "" ns(unsigned long long Val)operator "" ns(long double Val)|Specifies that the value represents nanoseconds.|  
  
### Classes  
  
|Name|Description|  
|----------|-----------------|  
|[duration Class](../vs140/duration-class.md)|Describes a type that holds a time interval.|  
|[time_point Class](../vs140/time_point-class.md)|Describes a type that represents a point in time.|  
  
### Structs  
  
|Name|Description|  
|----------|-----------------|  
|[common_type Structure](../vs140/common_type-structure.md)|Describes specializations of template class [common_type](../vs140/common_type-class.md) for instantiations of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
|[duration_values Structure](../vs140/duration_values-structure.md)|Provides specific values for the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> template parameter <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|[steady_clock Class](../vs140/steady_clock-struct.md)|Represents a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> clock.|  
|[system_clock Structure](../vs140/system_clock-structure.md)|Represents a *clock type* that is based on the real-time clock of the system.|  
|[treat_as_floating_point Structure](../vs140/treat_as_floating_point-structure.md)|Specifies whether a type can be treated as a floating-point type.|  
  
### Functions  
  
|Name|Description|  
|----------|-----------------|  
|[duration_cast Function](../vs140/-chrono--functions.md#duration_cast_function)|Casts a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object to a specified type.|  
|[time_point_cast Function](../vs140/-chrono--functions.md#time_point_cast_function)|Casts a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object to a specified type.|  
  
### Operators  
  
|Name|Description|  
|----------|-----------------|  
|[operator-](../vs140/-chrono--operators.md#operator-)|Operator for subtraction or negation of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> objects.|  
|[operator!= Operator](../vs140/-chrono--operators.md#operator_neq)|Inequality operator that is used with <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> objects.|  
|[operator% Operator](../vs140/-chrono--operators.md#operator_modulo)|Operator for modulo operations on <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> objects.|  
|[operator* Operator](../vs140/-chrono--operators.md#operator_star)|Multiplication operator for <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> objects.|  
|[operator/ Operator](../vs140/-chrono--operators.md#operator_)|Division operator for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> objects.|  
|[operator+ Operator](../vs140/-chrono--operators.md#operator_add)|Adds <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> objects.|  
|[operator< Operator](../vs140/-chrono--operators.md#operator_lt_)|Determines whether one <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object is less than another <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.|  
|[operator<= Operator](../vs140/-chrono--operators.md#operator_lt__eq)|Determines whether one <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object is less than or equal to another <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.|  
|[operator== Operator](../vs140/-chrono--operators.md#operator_eq_eq)|Determines whether two <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> objects represent time intervals that have the same length, or whether two <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> objects represent the same point in time.|  
|[operator> Operator](../vs140/-chrono--operators.md#operator_gt_)|Determines whether one <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object is greater than another <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.|  
|[operator>= Operator](../vs140/-chrono--operators.md#operator_gt__eq)|Determines whether one <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object is greater than or equal to another <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.|  
  
### Predefined Duration Types  
 For more information about ratio types that are used in the following typedefs, see [\<ratio>](../vs140/-ratio-.md).  
  
|Typedef|Description|  
|-------------|-----------------|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Synonym for a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> type that has a tick period of one nanosecond.|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|Synonym for a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> type that has a tick period of one microsecond.|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|Synonym for a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> type that has a tick period of one millisecond.|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|Synonym for a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> type that has a tick period of one second.|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|Synonym for a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> type that has a tick period of one minute.|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|Synonym for a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> type that has a tick period of one hour.|  
  
### Literals  
 **(C++11)**The \<chrono> header defines the following [user-defined literals](../vs140/user-defined-literals---c---.md) that you can use for greater convenience, type-safety and maintainability of your code. These literals are defined in the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> inline namespace and are in scope when std::chrono is in scope.  
  
|Literal|Description|  
|-------------|-----------------|  
|chrono::hours operator "" h(unsigned long long Val)|Specifies hours as an integral value.|  
|chrono::duration<double, ratio\<3600> > operator "" h(long double Val)|Specifies hours as a floating-point value.|  
|chrono::minutes (operator "" min)(unsigned long long Val)|Specifies minutes as an integral value.|  
|chrono::duration<double, ratio\<60> > (operator "" min)( long double Val)|Specifies minutes as a floating-point value.|  
|chrono::seconds operator "" s(unsigned long long Val)|Specifies minutes as an integral value.|  
|chrono::duration\<double> operator "" s(long double Val)|Specifies seconds as a floating-point value.|  
|chrono::milliseconds operator "" ms(unsigned long long Val)|Specifies milliseconds as an integral value.|  
|chrono::duration\<double, milli> operator "" ms(long double Val)|Specifies milliseconds as a floating-point value.|  
|chrono::microseconds operator "" us(unsigned long long Val)|Specifies microseconds as an integral value.|  
|chrono::duration\<double, micro> operator "" us(long double Val)|Specifies microseconds as a floating-point value.|  
|chrono::nanoseconds operator "" ns(unsigned long long Val)|Specifies nanoseconds as an integral value.|  
|chrono::duration\<double, nano> operator "" ns(long double Val)|Specifies nanoseconds as a floating-point value.|  
|||  
  
## Remarks  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)