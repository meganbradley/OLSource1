---
title: "array Class (STL)"
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
  - "array/std::tr1::array"
  - "std.tr1.array"
  - "array"
  - "std::tr1::array"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "array class [TR1]"
ms.assetid: fdfd43a5-b2b5-4b9e-991f-93bf10fb4293
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array Class (STL)
Describes an object that controls a sequence of length <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> of elements of type <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>. The sequence is stored as an array of <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, contained in the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|The type of an element.|  
|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|The number of elements.|  
  
## Members  
  
|||  
|-|-|  
|Type Definition|Description|  
|[const_iterator](#array__const_iterator)|The type of a constant iterator for the controlled sequence.|  
|[const_pointer](#array__const_pointer)|The type of a constant pointer to an element.|  
|[const_reference](#array__const_reference)|The type of a constant reference to an element.|  
|[const_reverse_iterator](#array__const_reverse_iterator)|The type of a constant reverse iterator for the controlled sequence.|  
|[difference_type](#array__difference_type)|The type of a signed distance between two elements.|  
|[iterator](#array__iterator)|The type of an iterator for the controlled sequence.|  
|[pointer](#array__pointer)|The type of a pointer to an element.|  
|[reference](#array__reference)|The type of a reference to an element.|  
|[reverse_iterator](#array__reverse_iterator)|The type of a reverse iterator for the controlled sequence.|  
|[size_type](#array__size_type)|The type of an unsigned distance between two elements.|  
|[value_type](#array__value_type)|The type of an element.|  
  
|||  
|-|-|  
|Member Function|Description|  
|[array](#array__array)|Constructs an array object.|  
|[assign](#array__assign)|Replaces all elements.|  
|[at](#array__at)|Accesses an element at a specified position.|  
|[back](#array__back)|Accesses the last element.|  
|[begin](#array__begin)|Designates the beginning of the controlled sequence.|  
|[cbegin](#array__cbegin)|Returns a random-access const iterator to the first element in the array.|  
|[cend](#array__cend)|Returns a random-access const iterator that points just beyond the end of the array.|  
|[crbegin](#array__crbegin)|Returns a const iterator to the first element in a reversed array.|  
|[crend](#array__crend)|Returns a const iterator to the end of a reversed array.|  
|[data](#array__data)|Gets the address of the first element.|  
|[empty](#array__empty)|Tests whether elements are present.|  
|[end](#array__end)|Designates the end of the controlled sequence.|  
|[fill](#array__fill)|Replaces all elements with a specified value.|  
|[front](#array__front)|Accesses the first element.|  
|[max_size](#array__max_size)|Counts the number of elements.|  
|[rbegin](#array__rbegin)|Designates the beginning of the reversed controlled sequence.|  
|[rend](#array__rend)|Designates the end of the reversed controlled sequence.|  
|[size](#array__size)|Counts the number of elements.|  
|[swap](#array__swap)|Swaps the contents of two containers.|  
  
|||  
|-|-|  
|Operator|Description|  
|[operator=](#array__operator_eq)|Replaces the controlled sequence.|  
|[operator&#91;&#93;](#array__operator_at)|Accesses an element at a specified position.|  
  
## Remarks  
 The type has a default constructor <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> and a default assignment operator <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, and satisfies the requirements for an <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>. Therefore, objects of type <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> can be initialized by using an aggregate initializer. For example,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 creates the object <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> that holds four integer values, initializes the first three elements to the values 1, 2, and 3, respectively, and initializes the fourth element to 0.  
  
## Requirements  
 **Header:** \<array>  
  
 **Namespace:** std  
  
##  \<a name="array__array">\</a>  array::array  
 Constructs an array object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Object or range to insert.  
  
### Remarks  
 The constructor:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 leaves the controlled sequence uninitialized (or default initialized). You use it to specify an uninitialized controlled sequence.  
  
 The constructor:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 initializes the controlled sequence with the sequence <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>[begin](#array__begin)<CodeContentPlaceHolder>81\</CodeContentPlaceHolder> <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>[end](#array__end)<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>. You use it to specify an initial controlled sequence that is a copy of the sequence controlled by the array object <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0 1 2 3**    
##  \<a name="array__assign">\</a>  array::assign  
 Replaces all elements.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The value to assign.  
  
### Remarks  
 The member function replaces the sequence controlled by <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> with a repetition of <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> elements of value <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **4 4 4 4**    
##  \<a name="array__at">\</a>  array::at  
 Accesses an element at a specified position.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 Position of element to access.  
  
### Remarks  
 The member functions return a reference to the element of the controlled sequence at position <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>. If that position is invalid, the function throws an object of class <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="array__back">\</a>  array::back  
 Accesses the last element.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 The member functions return a reference to the last element of the controlled sequence, which must be non-empty.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **3**    
##  \<a name="array__begin">\</a>  array::begin  
 Designates the beginning of the controlled sequence.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 The member functions return a random-access iterator that points at the first element of the sequence (or just beyond the end of an empty sequence).  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0**    
##  \<a name="array__cbegin">\</a>  array::cbegin  
 Returns a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> iterator that addresses the first element in the range.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> random-access iterator that points at the first element of the range, or the location just beyond the end of an empty range (for an empty range, <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>).  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>, the elements in the range cannot be modified.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="array__cend">\</a>  array::cend  
 Returns a <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> iterator that addresses the location just beyond the last element in a range.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 A random-access iterator that points just beyond the end of the range.  
  
### Remarks  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> is used to test whether an iterator has passed the end of its range.  
  
 You can use this member function in place of the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> member function to guarantee that the return value is <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>) container of any kind that supports <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The value returned by <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> should not be dereferenced.  
  
##  \<a name="array__const_iterator">\</a>  array::const_iterator  
 The type of a constant iterator for the controlled sequence.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant random-access iterator for the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  **it1: 0 1 2 3**   
 **it2: 0**     
##  \<a name="array__const_pointer">\</a>  array::const_pointer  
 The type of a constant pointer to an element.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant pointer to elements of the sequence.  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0**    
##  \<a name="array__const_reference">\</a>  array::const_reference  
 The type of a constant reference to an element.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant reference to an element of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0**    
##  \<a name="array__const_reverse_iterator">\</a>  array::const_reverse_iterator  
 The type of a constant reverse iterator for the controlled sequence.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a constant reverse iterator for the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **3**    
##  \<a name="array__crbegin">\</a>  array::crbegin  
 Returns a const iterator to the first element in a reversed array.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse random-access iterator addressing the first element in a reversed array or addressing what had been the last element in the unreversed array.  
  
### Remarks  
 With the return value of <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>, the array object cannot be modified.  
  
### Example  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  **The first element of array is 1.**  
**The first element of the reversed array is 2.**    
##  \<a name="array__crend">\</a>  array::crend  
 Returns a const iterator that addresses the location succeeding the last element in a reversed array.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 A const reverse random-access iterator that addresses the location succeeding the last element in a reversed array (the location that had preceded the first element in the unreversed array).  
  
### Remarks  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> is used with a reversed array just as [cend](#array__cend) is used with a array.  
  
 With the return value of <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> (suitably decremented), the array object cannot be modified.  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its array.  
  
 The value returned by <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> should not be dereferenced.  
  
### Example  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  **2**  
**1**    
##  \<a name="array__data">\</a>  array::data  
 Gets the address of the first element.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Remarks  
 The member functions return the address of the first element in the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0**    
##  \<a name="array__difference_type">\</a>  array::difference_type  
 The type of a signed distance between two elements.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Remarks  
 The signed integer type describes an object that can represent the difference between the addresses of any two elements in the controlled sequence. It is a synonym for the type <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **-4**    
##  \<a name="array__empty">\</a>  array::empty  
 Tests whether no elements are present.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns true only if <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **false**  
 **true**    
##  \<a name="array__end">\</a>  array::end  
 Designates the end of the controlled sequence.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Remarks  
 The member functions return a random-access iterator that points just beyond the end of the sequence.  
  
### Example  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **3**    
##  \<a name="array__fill">\</a>  array::fill  
 Erases a array and copies the specified elements to the empty array.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>118\</CodeContentPlaceHolder>|The value of the element being inserted into the array.|  
  
### Remarks  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> replaces each element of the array with the specified value.  
  
### Example  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
##  \<a name="array__front">\</a>  array::front  
 Accesses the first element.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Remarks  
 The member functions return a reference to the first element of the controlled sequence, which must be non-empty.  
  
### Example  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0**    
##  \<a name="array__iterator">\</a>  array::iterator  
 The type of an iterator for the controlled sequence.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a random-access iterator for the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  **it1: 0 1 2 3**   
 **it2: 0**     
##  \<a name="array__max_size">\</a>  array::max_size  
 Counts the number of elements.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **4**    
##  \<a name="array__operator_at">\</a>  array::operator[]  
 Accesses an element at a specified position.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 Position of element to access.  
  
### Remarks  
 The member functions return a reference to the element of the controlled sequence at position <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>. If that position is invalid, the behavior is undefined.  
  
### Example  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **1 3**    
##  \<a name="array__operator_eq">\</a>  array::operator=  
 Replaces the controlled sequence.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 right  
 Container to copy.  
  
### Remarks  
 The member operator assigns each element of <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> to the corresponding element of the controlled sequence, then returns <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>. You use it to replace the controlled sequence with a copy of the controlled sequence in <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0 1 2 3**    
##  \<a name="array__pointer">\</a>  array::pointer  
 The type of a pointer to an element.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a pointer to elements of the sequence.  
  
### Example  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0**    
##  \<a name="array__rbegin">\</a>  array::rbegin  
 Designates the beginning of the reversed controlled sequence.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Remarks  
 The member functions return a reverse iterator that points just beyond the end of the controlled sequence. Hence, it designates the beginning of the reverse sequence.  
  
### Example  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **3**    
##  \<a name="array__reference">\</a>  array::reference  
 The type of a reference to an element.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a reference to an element of the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0**    
##  \<a name="array__rend">\</a>  array::rend  
 Designates the end of the reversed controlled sequence.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Remarks  
 The member functions return a reverse iterator that points at the first element of the sequence (or just beyond the end of an empty sequence)). Hence, it designates the end of the reverse sequence.  
  
### Example  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0**    
##  \<a name="array__reverse_iterator">\</a>  array::reverse_iterator  
 The type of a reverse iterator for the controlled sequence.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Remarks  
 The type describes an object that can serve as a reverse iterator for the controlled sequence.  
  
### Example  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **3**    
##  \<a name="array__size">\</a>  array::size  
 Counts the number of elements.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **4**    
##  \<a name="array__size_type">\</a>  array::size_type  
 The type of an unsigned distance between two element.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Remarks  
 The unsigned integer type describes an object that can represent the length of any controlled sequence. It is a synonym for the type <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **4**    
##  \<a name="array__swap">\</a>  array::swap  
 Swaps the contents of two arrays.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 Array to swap contents with.  
  
### Remarks  
 The member function swaps the controlled sequences between <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>. It performs a number of element assignments and constructor calls proportional to <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **4 5 6 7**  
 **0 1 2 3**    
##  \<a name="array__value_type">\</a>  array::value_type  
 The type of an element.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0 1 2 3**    
## See Also  
 [\<array>](../vs140/-array-.md)