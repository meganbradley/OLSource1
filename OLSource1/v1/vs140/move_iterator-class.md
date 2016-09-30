---
title: "move_iterator Class"
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
  - "std.move_iterator"
  - "move_iterator"
  - "iterator/std::move_iterator"
  - "std::move_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "move_iterator class"
ms.assetid: a5e5cdd8-a264-4c6b-9f9c-68b0e8edaab7
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# move_iterator Class
Class template <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a wrapper for an iterator. The move_iterator provides the same behavior as the iterator it wraps (stores), except it turns the stored iterator’s dereference operator into an rvalue reference, turning a copy into a move. For more information about rvalues, see [Rvalue Reference Declarator: &&](../vs140/rvalue-reference-declarator----.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The template class describes an object that behaves like an iterator except when dereferenced. It stores a random-access iterator of type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, accessed by way of the member function <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. All operations on a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> are performed directly on the stored iterator, except that the result of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is implicitly cast to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to make an rvalue reference.  
  
 A <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> might be capable of operations that are not defined by the wrapped iterator. These operations should not be used.  
  
### Constructors  
  
|||  
|-|-|  
|[move_iterator](#move_iterator__move_iterator)|The constructor for objects of type <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|[iterator_type](#move_iterator__iterator_type)|A synonym for the template parameter <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
|[iterator_category](#move_iterator__iterator_category)|A synonym for a longer <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> expression of the same name, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> identifies the general abilities of the iterator.|  
|[value_type](#move_iterator__value_type)|A synonym for a longer <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> expression of the same name, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> describes what type the iterator elements are.|  
|[difference_type](#move_iterator__difference_type)|A synonym for a longer <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> expression of the same name, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> describes the integral type required to express difference values between elements.|  
|[pointer](#move_iterator__pointer)|A synonym for template parameter <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.|  
|[reference](#move_iterator__reference)|A synonym for the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> reference <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[base](#move_iterator__base)|The member function returns the stored iterator wrapped by this <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.|  
  
### Operators  
  
|||  
|-|-|  
|[operator*](#move_iterator__operator_star)|Returns <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
|[operator++](#move_iterator__operator_add_add)|Increments the stored iterator. Exact behavior depends on whether it is a preincrement or a postincrement operation.|  
|[move_iterator::operator--](#move_iterator__operator--)|Decrements the stored iterator. Exact behavior depends on whether it is a predecrement or a postdecrement operation.|  
|[move_iterator::operator-&gt;](#move_iterator__operator-_gt_)|Returns <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.|  
|[move_iterator::operator-](#move_iterator__operator-)|Returns <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> by first subtracting the right-hand value from the current position.|  
|[operator&#91;&#93;](#move_iterator__operator_at)|Returns <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. Allows you to specify an offset from the current base to obtain the value at that location.|  
|[operator+](#move_iterator__operator_add)|Returns <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> the value. Allows you to add an offset to the base to obtain the value at that location.|  
|[operator+=](#move_iterator__operator_add_eq)|Adds the right-hand value to the stored iterator, and returns <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.|  
|[move_iterator::operator-=](#move_iterator__operator-_eq)|Subtracts the right-hand value from the stored iterator, and returns <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
##  \<a name="move_iterator__base">\</a>  move_iterator::base  
 Returns the stored iterator for this <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the stored iterator.  
  
##  \<a name="move_iterator__difference_type">\</a>  move_iterator::difference_type  
 The type <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> based on the iterator trait <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, and can be used interchangeably with it.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the iterator trait <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
##  \<a name="move_iterator__iterator_category">\</a>  move_iterator::iterator_category  
 The type <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> based on the iterator trait <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, and can be used interchangeably with it.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the iterator trait <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
##  \<a name="move_iterator__iterator_type">\</a>  move_iterator::iterator_type  
 The type <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is based on the template parameter <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> for the class template <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, and can be used interchangeably in its place.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
##  \<a name="move_iterator__move_iterator">\</a>  move_iterator::move_iterator  
 Constructs a move iterator. Uses the parameter as the stored iterator.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The iterator to use as the stored iterator.  
  
### Remarks  
 The first constructor initializes the stored iterator with its default constructor. The remaining constructors initialize the stored iterator with <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
##  \<a name="move_iterator__operator_add_eq">\</a>  move_iterator::operator+=  
 Adds an offset to the stored iterator, so that the stored iterator points to the element at the new current location. The operator then moves the new current element.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 An offset to add to the current position to determine the new current position.  
  
### Return Value  
 Returns the new current element.  
  
### Remarks  
 The operator adds <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> to the stored iterator. Then returns <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
##  \<a name="move_iterator__operator-_eq">\</a>  move_iterator::operator-=  
 Moves across a specified number of previous elements. This operator subtracts an offset from the stored iterator.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
  
### Remarks  
 The operator evaluates <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>. Then returns <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
##  \<a name="move_iterator__operator_add_add">\</a>  move_iterator::operator++  
 Increments the stored iterator that belongs to this <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> The current element is accessed by the postincrement operator. The next element is accessed by the preincrement operator.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
  
### Remarks  
 The first (preincrement) operator increments the stored iterator. Then returns <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
 The second (postincrement) operator makes a copy of <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, evaluates <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>. Then returns the copy.  
  
##  \<a name="move_iterator__operator_add">\</a>  move_iterator::operator+  
 Returns the iterator position advanced by any number of elements.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
  
### Remarks  
 The operator returns <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
##  \<a name="move_iterator__operator_at">\</a>  move_iterator::operator[]  
 Allows array index access to elements across the range of the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
  
### Remarks  
 The operator returns <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.  
  
##  \<a name="move_iterator__operator--">\</a>  move_iterator::operator--  
 Pre- and postdecrement member operators perform a decrement on the stored iterator.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
  
### Remarks  
 The first member operator (predecrement) decrements the stored iterator. Then returns <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.  
  
 The second (postdecrement) operator makes a copy of <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, evaluates <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>. Then returns the copy.  
  
##  \<a name="move_iterator__operator-">\</a>  move_iterator::operator-  
 Decrements the stored iterator and returns the indicated value.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
  
### Remarks  
 The operator returns <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>.  
  
##  \<a name="move_iterator__operator_star">\</a>  move_iterator::operator*  
 Dereferences the stored iterator and returns the value. This behaves like an <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> and performs a move assignment. The operator transfers the current element out of the base iterator. The element that follows becomes the new current element.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 The operator returns <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
##  \<a name="move_iterator__operator-_gt_">\</a>  move_iterator::operator-&gt;  
 Like a normal <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, it provides access to the fields that belong to the current element.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 The operator returns <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
##  \<a name="move_iterator__pointer">\</a>  move_iterator::pointer  
 The type <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> based on the random iterator <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, and can be used interchangeably.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
##  \<a name="move_iterator__reference">\</a>  move_iterator::reference  
 The type <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> based on <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, and can be used interchangeably with <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, which is an rvalue reference.  
  
##  \<a name="move_iterator__value_type">\</a>  move_iterator::value_type  
 The type <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> based on the iterator trait <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>, and can be used interchangeably with it.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the iterator trait <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
## See Also  
 [\<iterator>](../vs140/-iterator-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [How to: Write a Move Constructor](../vs140/move-constructors-and-move-assignment-operators--c---.md)   
 [Standard Template Library](../vs140/standard-template-library.md)