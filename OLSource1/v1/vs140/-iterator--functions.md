---
title: "&lt;iterator&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 4a57c9a3-7e36-411f-8655-e0be2eec88e7
caps.latest.revision: 14
---
# &lt;iterator&gt; functions
||||  
|-|-|-|  
|[advance](#advance)|[back_inserter](#back_inserter)|[begin](#begin)|  
|[cbegin](#cbegin)|[cend](#cend)|[distance](#distance)|  
|[end](#end)|[front_inserter](#front_inserter)|[inserter](#inserter)|  
|[make_checked_array_iterator](#make_checked_array_iterator)|[make_move_iterator](#make_move_iterator)|[make_unchecked_array_iterator](#make_unchecked_array_iterator)|  
|[next](#next)|[prev](#prev)|  
  
##  \<a name="advance">\</a>  advance  
 Increments an iterator by a specified number of positions.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The iterator that is to be incremented and that must satisfy the requirements for an input iterator.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 An integral type that is convertible to the iterator's difference type and that specifies the number of increments the position of the iterator is to be advanced.  
  
### Remarks  
 The range advanced through must be nonsingular, where the iterators must be dereferenceable or past the end.  
  
 If the **InputIterator** satisfies the requirements for a bidirectional iterator type, then <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> may be negative. If **InputIterator** is an input or forward iterator type, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> must be nonnegative.  
  
 The advance function has constant complexity when **InputIterator** satisfies the requirements for a random-access iterator; otherwise, it has linear complexity and so is potentially expensive.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **The list L is: ( 1 2 3 4 5 6 7 8 ).**  
**The iterator LPOS initially points to the first element: 1.**  
**LPOS is advanced 4 steps forward to point to the fifth element: 5.**  
**LPOS is moved 3 steps back to point to the 2nd element: 2.**    
##  \<a name="back_inserter">\</a>  back_inserter  
 Creates an iterator that can insert elements at the back of a specified container.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The container into which the back insertion is to be executed.  
  
### Return Value  
 A <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> associated with the container object <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
### Remarks  
 Within the Standard Template Library, the argument must refer to one of the three sequence containers that have the member function <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>: [deque Class](../vs140/deque-class.md), [list Class](../vs140/list-class.md), or [vector Class](../vs140/vector-class.md).  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The initial vector vec is: ( 0 1 2 ).**  
**After the insertions, the vector vec is: ( 0 1 2 30 40 500 600 ).**    
##  \<a name="begin">\</a>  begin  
 Retrieves an iterator to the first element in a specified container.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 A container.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 An array of objects of type <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
### Return Value  
 The first two template functions return <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. The first function is non-constant; the second one is constant.  
  
 The third template function returns <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
### Example  
  We recommend that you use this template function in place of container member <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> when more generic behavior is required.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  The function <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> supports containers of any kind, in addition to regular arrays, because it calls the non-member version of <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> were coded to use the container member <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Then sending an array to it would cause this compiler error:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="cbegin">\</a>  cbegin  
 Retrieves a const iterator to the first element in a specified container.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A container or initializer_list.  
  
### Return Value  
 A constant <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
### Remarks  
 This function works with all STL containers and with [initializer_list](../vs140/initializer_list-class.md).  
  
 You can use this member function in place of the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> template function to guarantee that the return value is <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>) container or <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> of any kind that supports <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="cend">\</a>  cend  
 Retrieves a const iterator to the element that follows the last element in the specified container.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A container or initializer_list.  
  
### Return Value  
 A constant <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
### Remarks  
 This function works with all STL containers and with [initializer_list](../vs140/initializer_list-class.md).  
  
 You can use this member function in place of the [end()](../vs140/-iterator--functions.md#end) template function to guarantee that the return value is <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. Typically, it's used in conjunction with the [auto](../vs140/auto--c---.md) type deduction keyword, as shown in the following example. In the example, consider <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> to be a modifiable (non- <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>) container or <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> of any kind that supports <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="distance">\</a>  distance  
 Determines the number of increments between the positions addressed by two iterators.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The first iterator whose distance from the second is to be determined.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The second iterator whose distance from the first is to be determined.  
  
### Return Value  
 The number of times that <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> must be incremented until it equal <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
### Remarks  
 The distance function has constant complexity when **InputIterator** satisfies the requirements for a random-access iterator; otherwise, it has linear complexity and so is potentially expensive.  
  
### Example  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  **The list L is: ( -2 0 2 4 6 8 10 12 14 16 ).**  
**The iterator LPOS initially points to the first element: -2.**  
**LPOS is advanced 7 steps forward to point  to the eighth element: 12.**  
**The distance from L.begin( ) to LPOS is: 7.**    
##  \<a name="end">\</a>  end  
 Retrieves an iterator to the element that follows the last element in the specified container.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 A container.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 An array of objects of type <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
### Return Value  
 The first two template functions return <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> (the first is non-constant and the second is constant).  
  
 The third template function returns <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
### Remarks  
 For a code example, see [begin](../vs140/-iterator--functions.md#begin).  
  
##  \<a name="front_inserter">\</a>  front_inserter  
 Creates an iterator that can insert elements at the front of a specified container.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The container object whose front is having an element inserted.  
  
### Return Value  
 A <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> associated with the container object <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
### Remarks  
 The member function [front_insert_iterator](../vs140/front_insert_iterator-class.md#front_insert_iterator__front_insert_iterator) of the front_insert_iterator class may also be used.  
  
 Within the Standard Template Library, the argument must refer to one of the two sequence containers that have the member function <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>: [deque Class](../vs140/deque-class.md) or [list Class](../vs140/list-class.md).  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  **The list L is:**  
 **( -1 0 1 2 3 4 5 6 7 8 ).**  
**After the front insertions, the list L is:**  
 **( 200 100 -1 0 1 2 3 4 5 6 7 8 ).**    
##  \<a name="inserter">\</a>  inserter  
 A helper template function that lets you use <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The container to which new elements are to be added.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 An iterator locating the point of insertion.  
  
### Remarks  
 The template function returns [insert_iterator](../vs140/insert_iterator-class.md#insert_iterator__insert_iterator)<CodeContentPlaceHolder>80\</CodeContentPlaceHolder> <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  **The list L is:**  
 **( 20 30 40 ).**  
**After the insertions, the list L is:**  
 **( 1 20 30 40 500 ).**    
##  \<a name="make_checked_array_iterator">\</a>  make_checked_array_iterator  
 Creates a [checked_array_iterator](../vs140/checked_array_iterator-class.md) that can be used by other algorithms.  
  
> [!NOTE]
>  This function is a Microsoft extension of the Standard C++ Library. Code implemented by using this function is not portable to C++ Standard build environments that do not support this Microsoft extension.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 A pointer to the destination array.  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 The size of the destination array.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 Optional index into the array.  
  
### Return Value  
 An instance of <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> function is defined in the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> namespace.  
  
 This function takes a raw pointer—which would ordinarily cause concern about bounds overrun—and wraps it in a [checked_array_iterator](../vs140/checked_array_iterator-class.md) class that does checking. Because that class is marked as checked, the STL doesn't warn about it. For more information and code examples, see [Checked Iterators](../vs140/checked-iterators.md).  
  
### Example  
  In the following example, a [vector](../vs140/vector-class.md) is created and populated with 10 items. The contents of the vector are copied into an array by using the copy algorithm, and then <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> is used to specify the destination. This is followed by an intentional violation of the bounds checking so that a debug assertion failure is triggered.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
##  \<a name="make_move_iterator">\</a>  make_move_iterator  
 Creates a <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> that contains the provided iterator as the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> iterator.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 The iterator stored in the new move iterator.  
  
### Remarks  
 The template function returns <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>.  
  
##  \<a name="make_unchecked_array_iterator">\</a>  make_unchecked_array_iterator  
 Creates an [unchecked_array_iterator](../vs140/unchecked_array_iterator-class.md) that can be used by other algorithms.  
  
> [!NOTE]
>  This function is a Microsoft extension of the Standard C++ Library. Code implemented by using this function is not portable to C++ Standard build environments that do not support this Microsoft extension.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 A pointer to the destination array.  
  
### Return Value  
 An instance of <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> function is defined in the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> namespace.  
  
 This function takes a raw pointer and wraps it in a class that performs no checking and therefore optimizes away to nothing, but it also silences compiler warnings such as [C4996](../vs140/compiler-warning--level-3--c4996.md). Therefore, this is a targeted way to deal with unchecked-pointer warnings without globally silencing them or incurring the cost of checking. For more information and code examples, see [Checked Iterators](../vs140/checked-iterators.md).  
  
### Example  
  In the following example, a [vector](../vs140/vector-class.md) is created and populated with 10 items. The contents of the vector are copied into an array by using the copy algorithm, and then <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> is used to specify the destination.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
##  \<a name="next">\</a>  next  
 Iterates a specified number of times and returns the new iterator position.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 The current position.  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 The number of times to iterate.  
  
### Return Value  
 Returns the new iterator position after iterating <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> times.  
  
### Remarks  
 The template function returns <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> incremented <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> times  
  
##  \<a name="prev">\</a>  prev  
 Iterates in reverse a specified number of times and returns the new iterator position.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 The current position.  
  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 The number of times to iterate.  
  
### Remarks  
 The template function returns <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> decremented <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> times.  
  
## See Also  
 [&lt;iterator&gt;](../vs140/-iterator-.md)