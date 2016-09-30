---
title: "&lt;iterator&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: b7c664f0-49d4-4993-b5d1-9ac4859fdddc
caps.latest.revision: 10
---
# &lt;iterator&gt; operators
||||  
|-|-|-|  
|[operator!=](#operator_neq)|[operator&gt;](#operator_gt_)|[operator&gt;=](#operator_gt__eq)|  
|[operator&lt;](#operator_lt_)|[operator&lt;=](#operator_lt__eq)|[operator+](#operator_add)|  
|[operator-](#operator-)|[operator==](#operator_eq_eq)|  
  
##  \<a name="operator_neq">\</a>  operator!=  
 Tests if the iterator object on the left side of the operator is not equal to the iterator object on the right side.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 An object of type **iterator**.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 An object of type **iterator**.  
  
### Return Value  
 **true** if the iterator objects are not equal; **false** if the iterator objects are equal.  
  
### Remarks  
 One iterator object is equal to another if they address the same elements in a container. If two iterators point to different elements in a container, then they are not equal.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **The vector vec is: ( 1 2 3 4 5 6 7 8 ).**  
**The iterator rVPOS1 initially points to the first element**  
 **in the reversed sequence: 8.**  
**The iterators are equal.**  
**The iterator rVPOS1 now points to the second element**  
 **in the reversed sequence: 7.**  
**The iterators are not equal.**    
##  \<a name="operator_eq_eq">\</a>  operator==  
 Tests if the iterator object on the left side of the operator is equal to the iterator object on the right side.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 An object of type iterator.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 An object of type iterator.  
  
### Return Value  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> if the iterator objects are equal; <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> if the iterator objects are not equal.  
  
### Remarks  
 One iterator object is equal to another if they address the same elements in a container. If two iterators point to different elements in a container, then they are not equal.  
  
 The first two template operators return true only if both <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> store the same iterator. The third template operator returns true only if both <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> store the same stream pointer. The fourth template operator returns <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The vector vec is: ( 2 4 6 8 10 ).**  
**The iterator rVPOS1 initially points to the first element**  
 **in the reversed sequence: 10.**  
**The iterators are equal.**  
**The iterator rVPOS1 now points to the second element**  
 **in the reversed sequence: 8.**  
**The iterators are not equal.**    
##  \<a name="operator_lt_">\</a>  operator&lt;  
 Tests if the iterator object on the left side of the operator is less than the iterator object on the right side.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 An object of type **iterator**.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 An object of type **iterator**.  
  
### Return Value  
 **true** if the iterator on the left side of the expression is less than the iterator on the right side of the expression; **false** if it is greater than or equal to the iterator on the right.  
  
### Remarks  
 One iterator object is less than another if it addresses an element that occurs earlier in the container than the element addressed by the other iterator object. One iterator object is not less than another if it addresses either the same element as the other iterator object or an element that occurs later in the container than the element addressed by the other iterator object.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The initial vector vec is: ( 0 2 4 6 8 10 ).**  
**The iterators rVPOS1& rVPOS2 initially point to the first element**  
 **in the reversed sequence: 10.**  
**The iterator rVPOS1 is not less than the iterator rVPOS2.**  
**The iterator rVPOS2 now points to the second element**  
 **in the reversed sequence: 8.**  
**The iterator rVPOS1 is less than the iterator rVPOS2.**    
##  \<a name="operator_lt__eq">\</a>  operator&lt;=  
 Tests if the iterator object on the left side of the operator is less than or equal to the iterator object on the right side.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 An object of type iterator.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 An object of type iterator.  
  
### Return Value  
 **true** if the iterator on the left side of the expression is less than or equal to the iterator on the right side of the expression; **false** if it is greater than the iterator on the right.  
  
### Remarks  
 One iterator object is less than or equal to another if it addresses the same element or an element that occurs earlier in the container than the element addressed by the other iterator object. One iterator object is greater than another if it addresses an element that occurs later in the container than the element addressed by the other iterator object.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **The initial vector vec is: ( 0 2 4 6 8 10 ).**  
**The iterator rVPOS1 initially points to the second element**  
 **in the reversed sequence: 8.**  
**The iterator rVPOS2 initially points to the first element**  
 **in the reversed sequence: 10.**  
**The iterator rVPOS1 is greater than the iterator rVPOS2.**  
**The iterator rVPOS2 now points to the second element**  
 **in the reversed sequence: 8.**  
**The iterator rVPOS1 is less than or equal to the iterator rVPOS2.**    
##  \<a name="operator_gt_">\</a>  operator&gt;  
 Tests if the iterator object on the left side of the operator is greater than the iterator object on the right side.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 An object of type iterator.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 An object of type iterator.  
  
### Return Value  
 **true** if the iterator on the left side of the expression is greater than the iterator on the right side of the expression; **false** if it is less than or equal to the iterator on the right.  
  
### Remarks  
 One iterator object is greater than another if it addresses an element that occurs later in the container than the element addressed by the other iterator object. One iterator object is not greater than another if it addresses either the same element as the other iterator object or an element that occurs earlier in the container than the element addressed by the other iterator object.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The initial vector vec is: ( 0 2 4 6 8 10 ).**  
**The iterators rVPOS1 & rVPOS2 initially point to the first element**  
 **in the reversed sequence: 10.**  
**The iterator rVPOS1 is less than or equal to the iterator rVPOS2.**  
**The iterator rVPOS1 now points to the second element**  
 **in the reversed sequence: 8.**  
**The iterator rVPOS1 is greater than the iterator rVPOS2.**    
##  \<a name="operator_gt__eq">\</a>  operator&gt;=  
 Tests if the iterator object on the left side of the operator is greater than or equal to the iterator object on the right side.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 An object of type iterator.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 An object of type iterator.  
  
### Return Value  
 **true** if the iterator on the left side of the expression is greater than or equal to the iterator on the right side of the expression; **false** if it is less than the iterator on the right.  
  
### Remarks  
 One iterator object is greater than or equal to another if it addresses the same element or an element that occurs later in the container than the element addressed by the other iterator object. One iterator object is less than another if it addresses an element that occurs earlier in the container than the element addressed by the other iterator object.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **The initial vector vec is: ( 0 2 4 6 8 10 ).**  
**The iterator rVPOS1 initially points to the first element**  
 **in the reversed sequence: 10.**  
**The iterator rVPOS2 initially points to the second element**  
 **in the reversed sequence: 8.**  
**The iterator rVPOS1 is less than the iterator rVPOS2.**  
**The iterator rVPOS1 now points to the second element**  
 **in the reversed sequence: 8.**  
**The iterator rVPOS1 is greater than or equal to the iterator rVPOS2.**    
##  \<a name="operator_add">\</a>  operator+  
 Adds an offset to an iterator and returns a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> addressing the inserted element at the new offset position.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The number of positions the const move_iterator or const reverse_iterator is to be offset.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The iterator to be offset.  
  
### Return Value  
 Returns the sum <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> + <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  **The initial vector vec is: ( 0 2 4 6 8 10 ).**  
**The iterator rVPOS1 initially points to the first element**  
 **in the reversed sequence: 10.**  
**The iterator rVPOS1 now points to the fifth element**  
 **in the reversed sequence: 2.**    
##  \<a name="operator-">\</a>  operator-  
 Subtracts one iterator from another and returns the difference.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 An iterator.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 An iterator.  
  
### Return Value  
 The difference between two iterators <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
### Remarks  
 The first template operator returns <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
 The second template operator returns <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is determined by the type of the returned expression. Otherwise, it is <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  **The initial vector vec is: ( 0 2 4 6 8 10 ).**  
**The iterators rVPOS1 & rVPOS2 initially point to the first element**  
 **in the reversed sequence: 10.**  
**The iterator rVPOS2 now points to the fifth element**  
 **in the reversed sequence: 2.**  
**The difference: rVPOS2 - rVPOS1= 4.**    
## See Also  
 [&lt;iterator&gt;](../vs140/-iterator-.md)