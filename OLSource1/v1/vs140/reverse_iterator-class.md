---
title: "reverse_iterator Class"
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
  - "reverse_iterator"
  - "std::reverse_iterator"
  - "std.reverse_iterator"
  - "xutility/std::reverse_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reverse_iterator class"
ms.assetid: c0b34d04-ae9a-4999-9aff-28b313897ffa
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reverse_iterator Class
The template class is an iterator adaptor that describes a reverse iterator object that behaves like a random-access or bidirectional iterator, only in reverse. It enables the backward traversal of a range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 RandomIterator  
 The type that represents the iterator to be adapted to operate in reverse.  
  
## Remarks  
 Existing Standard Template Library containers also define                 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> types and have member functions                 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> that return reverse iterators. These iterators have overwrite semantics. The                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> adaptor supplements this functionality as offers insert semantics and can also be used with streams.  
  
 The                 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>s that require a bidirectional iterator must not call any of the member functions                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>,                 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>,                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>,                 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, or                 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, which may only be used with random-access iterators.  
  
 If the range of an iterator is [                <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, _Last), where the square bracket on the left indicates the inclusion on \_                *First* and the parenthesis on the right indicates the inclusion of elements up to \_                *Left* but excluding \_                *Left* itself. The same elements are included in the reversed sequence [                **rev** â€“                 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>,                 **rev** â€“ \_                *Left*) so that if \_                *Left* is the one-past-the-end element in a sequence, then the first element                 **rev** â€“ \_                *First* in the reversed sequence points to \*(\_                *Left* â€“ 1 ). The identity which relates all reverse iterators to their underlying iterators is:  
  
 &\*(                **reverse_iterator** (                 *i* ) ) == &\*(                 *i* â€“ 1 ).  
  
 In practice, this means that in the reversed sequence the reverse_iterator will refer to the element one position beyond (to the right of) the element that the iterator had referred to in the original sequence. So if an iterator addressed the element 6 in the sequence (2, 4, 6, 8), then the                 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> will address the element 4 in the reversed sequence (8, 6, 4, 2).  
  
### Constructors  
  
|||  
|-|-|  
|[reverse_iterator](#reverse_iterator__reverse_iterator)|Constructs a default                                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> or a                                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> from an underlying iterator.|  
  
### Typedefs  
  
|||  
|-|-|  
|[difference_type](#reverse_iterator__difference_type)|A type that provides the difference between two                                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>s referring to elements within the same container.|  
|[iterator_type](#reverse_iterator__iterator_type)|A type that provides the underlying iterator for a                                         <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.|  
|[pointer](#reverse_iterator__pointer)|A type that provides a pointer to an element addressed by a                                         <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.|  
|[reference](#reverse_iterator__reference)|A type that provides a reference to an element addressed by a                                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[base](#reverse_iterator__base)|Recovers the underlying iterator from its                                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.|  
  
### Operators  
  
|||  
|-|-|  
|[operator_star](#reverse_iterator__operator_star)|Returns the element that a                                         <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> addresses.|  
|[operator+](#reverse_iterator__operator_add)|Adds an offset to an iterator and returns the new                                         <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> addressing the inserted element at the new offset position.|  
|[operator++](#reverse_iterator__operator_add_add)|Increments the                                         <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> to the next element.|  
|[operator+=](#reverse_iterator__operator_add_eq)|Adds a specified offset from a                                         <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.|  
|[operator-](#reverse_iterator__operator-)|Subtracts an offset from a                                         <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> and returns a                                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> addressing the element at the offset position.|  
|[operator--](#reverse_iterator__operator--)|Decrements the                                         <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> to the previous element.|  
|[operator-=](#reverse_iterator__operator-_eq)|Subtracts a specified offset from a                                         <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.|  
|[operator->](#reverse_iterator__operator-_gt_)|Returns a pointer to the element addressed by the                                         <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.|  
|[operator&#91;&#93;](#reverse_iterator__operator_at)|Returns a reference to an element offset from the element addressed by a                                         <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> by a specified number of positions.|  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
##  \<a name="reverse_iterator__base">\</a>  reverse_iterator::base  
 Recovers the underlying iterator from its                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 The iterator underlying the                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
### Remarks  
 The identity that relates all reverse iterators to their underlying iterators is:  
  
 &\*(                        <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> (                         *i* ) ) == &\*(                         *i* â€“ 1 ).  
  
 In practice, this means that in the reversed sequence the                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> will refer to the element one position beyond (to the right of) the element that the iterator had referred to in the original sequence. So if an iterator addressed the element 6 in the sequence (2, 4, 6, 8), then the                         <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> will address the element 4 in the reversed sequence (8, 6, 4, 2).  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="reverse_iterator__difference_type">\</a>  reverse_iterator::difference_type  
 A type that provides the difference between two                 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>s referring to elements within the same container.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The                         <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> difference type is the same as the iterator difference type.  
  
 The type is a synonym for the iterator trait typename                         <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>\<                        **RandomIterator**>                        **::pointer**.  
  
### Example  
  See                                 [reverse_iterator::operator&#91;&#93;](#reverse_iterator__operator_at) for an example of how to declare and use                                 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
##  \<a name="reverse_iterator__iterator_type">\</a>  reverse_iterator::iterator_type  
 A type that provides the underlying iterator for a                 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
### Example  
  See                                 [reverse_iterator::base](#reverse_iterator__base) for an example of how to declare and use                                 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
##  \<a name="reverse_iterator__operator_star">\</a>  reverse_iterator::operator*  
 Returns the element that a reverse_iterator addresses.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The value of the elements addressed by the reverse_iterator.  
  
### Remarks  
 The operator returns \*(                        **current** â€“ 1).  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="reverse_iterator__operator_add">\</a>  reverse_iterator::operator+  
 Adds an offset to an iterator and returns the new                 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> addressing the inserted element at the new offset position.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The offset to be added to the reverse iterator.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> addressing the offset element.  
  
### Remarks  
 This member function may only be used if the                         <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> satisfies the requirements for a random-access iterator.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  **The vector vec is: ( 2 4 6 8 10 ).**  
**The vector vec reversed is: ( 10 8 6 4 2 ).**  
**The iterator rVPOS1 initially points to the first element**  
 **in the reversed sequence: 10.**  
**After the +2 offset, the iterator rVPOS2 points**  
 **to the 3rd element in the reversed sequence: 6.**    
##  \<a name="reverse_iterator__operator_add_add">\</a>  reverse_iterator::operator++  
 Increments the reverse_iterator to the previous element.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The first operator returns the preincremented                         <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> and the second, the postincrement operator, returns a copy of the incremented                         <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.  
  
### Remarks  
 This member function may only be used if the                         <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> satisfies the requirements for a bidirectional iterator.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  **The vector vec is: ( 1 3 5 7 9 ).**  
**The vector vec reversed is: ( 9 7 5 3 1 ).**  
**The iterator rVPOS1 initially points to the first element**  
 **in the reversed sequence: 9.**  
**After incrementing, the iterator rVPOS1 points**  
 **to the second element in the reversed sequence: 7.**    
##  \<a name="reverse_iterator__operator_add_eq">\</a>  reverse_iterator::operator+=  
 Adds a specified offset from a reverse_iterator.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The offset by which to increment the iterator.  
  
### Return Value  
 A reference to the element addressed by the                         <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **The vector vec is: ( 2 4 6 8 10 ).**  
**The vector vec reversed is: ( 10 8 6 4 2 ).**  
**The iterator rVPOS1 initially points to the first element**  
 **in the reversed sequence: 10.**  
**After the +2 offset, the iterator rVPOS1 now points**  
 **to the third element in the reversed sequence: 6.**    
##  \<a name="reverse_iterator__operator-">\</a>  reverse_iterator::operator-  
 Subtracts an offset from a                 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> and returns a                 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> addressing the element at the offset position.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The offset to be subtracted from the reverse_iterator.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> addressing the offset element.  
  
### Remarks  
 This member function may only be used if the                         <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> satisfies the requirements for a random-access iterator.  
  
### Example  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  **The vector vec is: ( 3 6 9 12 15 ).**  
**The vector vec reversed is: ( 15 12 9 6 3 ).**  
**The iterator rVPOS1 initially points to the last element**  
 **in the reversed sequence: 3.**  
**After the -2 offset, the iterator rVPOS2 points**  
 **to the 2nd element from the last in the reversed sequence: 9.**    
##  \<a name="reverse_iterator__operator--">\</a>  reverse_iterator::operator--  
 Decrements the reverse_iterator to the previous element.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 The first operator returns the predecremented                         <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> and the second, the postdecrement operator, returns a copy of the decremented                         <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
### Remarks  
 This member function may only be used if the                         <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> satisfies the requirements for a bidirectional iterator.  
  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  **The vector vec is: ( 1 3 5 7 9 ).**  
**The vector vec reversed is: ( 9 7 5 3 1 ).**  
**The iterator rVPOS1 initially points to the last element**  
 **in the reversed sequence: 1.**  
**After the decrement, the iterator rVPOS1 points**  
 **to the next-to-last element in the reversed sequence: 3.**    
##  \<a name="reverse_iterator__operator-_eq">\</a>  reverse_iterator::operator-=  
 Subtracts a specified offset from a                 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 The offset to be subtracted from the                                 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>.  
  
### Remarks  
 This member function may only be used if the                         <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> satisfies the requirements for a random-access iterator.  
  
 The operator evaluates                         **current** + _                        *Off*. then returns                         **\*this**.  
  
### Example  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  **The vector vec is: ( 3 6 9 12 15 ).**  
**The vector vec reversed is: ( 15 12 9 6 3 ).**  
**The iterator rVPOS1 initially points to the last element**  
 **in the reversed sequence: 3.**  
**After the -2 offset, the iterator rVPOS1 now points**  
 **to the 2nd element from the last in the reversed sequence: 9.**    
##  \<a name="reverse_iterator__operator-_gt_">\</a>  reverse_iterator::operator-&gt;  
 Returns a pointer to the element addressed by the                 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the element addressed by the                         <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.  
  
### Remarks  
 The operator returns                         **&\*\*this**.  
  
### Example  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  **The vector vec of integer pairs is:**  
**( ( 1, 2) ( 3, 4) ( 5, 6) )**  
**The vector vec reversed is:**  
**( ( 5, 6) ( 3, 4) ( 1, 2) )**  
**The iterator pos points to:**  
**( 3, 4 )**  
**The reverse_iterator rpos points to:**  
**( 1, 2 )**    
##  \<a name="reverse_iterator__operator_at">\</a>  reverse_iterator::operator[]  
 Returns a reference to an element offset from the element addressed by a                 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> by a specified number of positions.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 The offset from the                                 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> address.  
  
### Return Value  
 The reference to the element offset.  
  
### Remarks  
 The operator returns                         **\***(                        **\*this** +                         <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  **The vector vec is: ( 2 4 6 8 10 ).**  
**The vector vec reversed is: ( 10 8 6 4 2 ).**  
**The iterator pos points to: 8.**  
**The iterator rpos points to: 6.**  
**The iterator rpos now points to: 2.**    
##  \<a name="reverse_iterator__pointer">\</a>  reverse_iterator::pointer  
 A type that provides a pointer to an element addressed by a                 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the iterator trait typename                         <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>\<                        *RandomIterator*>                        **::pointer**.  
  
### Example  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  **The vector vec of integer pairs is:**  
**( ( 1, 2) ( 3, 4) ( 5, 6) )**  
**The vector vec reversed is:**  
**( ( 5, 6) ( 3, 4) ( 1, 2) )**  
**The iterator pos points to:**  
**( 3, 4 )**  
**The iterator rpos points to:**  
**( 1, 2 )**    
##  \<a name="reverse_iterator__reference">\</a>  reverse_iterator::reference  
 A type that provides a reference to an element addressed by a reverse_iterator.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the iterator trait typename                         <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>\<                        *RandomIterator*>                        **::reference**.  
  
### Example  
  See                                 [reverse_iterator::operator&#91;&#93;](#reverse_iterator__operator_at) or                                 [reverse_iterator::operator*](#reverse_iterator__operator_star) for examples of how to declare and use                                 **reference**.  
  
##  \<a name="reverse_iterator__reverse_iterator">\</a>  reverse_iterator::reverse_iterator  
 Constructs a default                 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> or a                 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> from an underlying iterator.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 The iterator that is to be adapted to a                                 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.  
  
### Return Value  
 A default                         <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> or a                         <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> adapting an underlying iterator.  
  
### Remarks  
 The identity which relates all reverse iterators to their underlying iterators is:  
  
 &\*(                        <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> (                         *i* ) ) == &\*(                         *i* â€“ 1 ).  
  
 In practice, this means that in the reversed sequence the reverse_iterator will refer to the element one position beyond (to the right of) the element that the iterator had referred to in the original sequence. So if an iterator addressed the element 6 in the sequence (2, 4, 6, 8), then the                         <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> will address the element 4 in the reversed sequence (8, 6, 4, 2).  
  
### Example  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
## See Also  
 [\<iterator>](../vs140/-iterator-.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)