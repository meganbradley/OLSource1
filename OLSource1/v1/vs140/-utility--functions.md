---
title: "&lt;utility&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: b1df38cd-3a59-4098-9c81-83342eb719a4
caps.latest.revision: 9
---
# &lt;utility&gt; functions
||||  
|-|-|-|  
|[exchange Function](#exchange_function)|[forward](#forward)|[get Function &lt;utility&gt;](#get_function__lt_utility_gt_)|  
|[make_pair](#make_pair)|[move](#move)|[swap](#swap)|  
  
##  \<a name="exchange_function">\</a>  exchange Function  
 **(C++14)** Assigns a new value to an object and returns its old value.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The object that will receive the value of new_val.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The object whose value is copied or moved into val.  
  
### Remarks  
 For complex types, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> avoids copying the old value when a move constructor is available, avoids copying the new value if it’s a temporary object or is moved, and accepts any type as the new value, using any available converting assignment operator. The exchange function is different from [std::swap](../vs140/-algorithm--functions.md#swap) in that the left argument is not moved or copied to the right argument.  
  
### Example  
  The following example shows how to use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. In the real world, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is most useful with large objects that are expensive to copy:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="forward">\</a>  forward  
 Conditionally casts its argument to an rvalue reference if the argument is an rvalue or rvalue reference. This restores the rvalue-ness of an argument to the forwarding function in support of perfect forwarding.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The type of the value passed in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, which might be different than the type of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Typically determined by a template argument of the forwarding function.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|The argument to cast.|  
  
### Return Value  
 Returns an rvalue reference to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> if the value passed in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> was originally an rvalue or a reference to an rvalue; otherwise, returns <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> without modifying its type.  
  
### Remarks  
 You must specify an explicit template argument to call <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> does not forward its argument. Instead, by conditionally casting its argument to an rvalue reference if it was originally an rvalue or rvalue reference, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> enables the compiler to perform overload resolution with knowledge of the forwarded argument's original type. The apparent type of an argument to a forwarding function might be different than its original type—for example, when an rvalue is used as an argument to a function and is bound to a parameter name; having a name makes it an lvalue, regardless of whether the value actually exists as an rvalue— <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> restores the rvalue-ness of the argument.  
  
 Restoring the rvalue-ness of an argument's original value in order to perform overload resolution is known as *perfect forwarding*. Perfect forwarding enables a template function to accept an argument of either reference type and to restore its rvalue-ness when it's necessary for correct overload resolution. By using perfect forwarding, you can preserve move semantics for rvalues and avoid having to provide overloads for functions that vary only by the reference type of their arguments.  
  
##  \<a name="get_function__lt_utility_gt_">\</a>  get Function &lt;utility&gt;  
 Gets an element from a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object by index position, or by type.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The 0-based index of the designated element.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The type of the first pair element.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The type of the second pair element.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The pair to select from.  
  
### Remarks  
 The template functions each return a reference to an element of its <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> argument.  
  
 For the indexed overloads, if the value of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is 0 the functions return <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and if the value of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is 1 the functions return <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. The type <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is the type of the returned element.  
  
 For the overloads that do not have an Index parameter, the element to return is deduced by the type argument. Calling <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> will produce a compiler error if <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> contains more or less than one element of type T.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="make_pair">\</a>  make_pair  
 A template function that you can use to construct objects of type <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, where the component types are automatically chosen based on the data types that are passed as parameters.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Value that initializes the first element of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Value that initializes the second element of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
### Return Value  
 The pair object that's constructed: <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>>( <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>).  
  
### Remarks  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> converts object of type [reference_wrapper](../vs140/reference_wrapper-class.md) to reference types and converts decaying arrays and functions to pointers.  
  
 In the returned <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is determined as follows:  
  
-   If the input type <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, the returned type <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
-   Otherwise, the returned type <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>. If [decay](../vs140/decay-class.md) is not supported, the returned type <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is the same as the input type <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
 The returned type <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is similarly determined from the input type <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
 One advantage of <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is that the types of objects that are being stored are determined automatically by the compiler and do not have to be explicitly specified. Don't use explicit template arguments such as <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> when you use <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> because it is unnecessarily verbose and adds complex rvalue reference problems that might cause compilation failure. For this example, the correct syntax would be <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  
 The <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> helper function also makes it possible to pass two values to a function that requires a pair as an input parameter.  
  
### Example  
  For an example about how to use the helper function <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> to declare and initialize a pair, see [pair](../vs140/pair-structure.md).  
  
##  \<a name="move">\</a>  move  
 Unconditionally casts its argument to an rvalue reference, and thereby signals that it can be moved if its type is move-enabled.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|A type deduced from the type of the argument passed in <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, together with the reference collapsing rules.|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|The argument to cast. Although the type of <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> appears to be specified as an rvalue reference, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> also accepts lvalue arguments because lvalue references can bind to rvalue references.|  
  
### Return Value  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> as an rvalue reference, whether or not its type is a reference type.  
  
### Remarks  
 The template argument <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> is not intended to be specified explicitly, but to be deduced from the type of the value passed in <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>. The type of <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> is further adjusted according to the reference collapsing rules.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> does not move its argument. Instead, by unconditionally casting its argument—which might be an lvalue—to an rvalue reference, it enables the compiler to subsequently move, rather than copy, the value passed in <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> if its type is move-enabled. If its type is not move-enabled, it is copied instead.  
  
 If the value passed in <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> is an lvalue—that is, it has a name or its address can be taken—it's invalidated when the move occurs. Do not refer to the value passed in <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> by its name or address after it's been moved.  
  
##  \<a name="swap">\</a>  swap  
 Exchanges the elements of two [pair](../vs140/pair-structure.md) objects.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|An object of type <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|An object of type <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.|  
  
### Remarks  
 One advantage of <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> is that the types of objects that are being stored are determined automatically by the compiler and do not have to be explicitly specified. Don't use explicit template arguments such as <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> when you use <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> because it is unnecessarily verbose and adds complex rvalue reference problems that might cause compilation failure.  
  
## See Also  
 [&lt;utility&gt;](../vs140/-utility-.md)