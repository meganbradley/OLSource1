---
title: "&lt;numeric&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: a4b0449a-c80c-4a1d-8d9f-d7fcd0058f8b
caps.latest.revision: 13
---
# &lt;numeric&gt; functions
||||  
|-|-|-|  
|[accumulate](#accumulate)|[adjacent_difference](#adjacent_difference)|[inner_product](#inner_product)|  
|[iota](#iota)|[partial_sum](#partial_sum)|  
  
##  \<a name="accumulate">\</a>  accumulate  
 Computes the sum of all the elements in a specified range including some initial value by computing successive partial sums or computes the result of successive partial results similarly obtained from using a specified binary operation other than the sum.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 An input iterator addressing the first element in the range to be summed or combined according to a specified binary operation.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 An input iterator addressing the last element in the range to be summed or combined according to a specified binary operation that is one position beyond the final element actually included in the iterated accumulation.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 An initial value to which each element is in turn added or combined with according to a specified binary operation.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The binary operation that is to be applied to the each element in the specified range and the result of its previous applications.  
  
### Return Value  
 The sum of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and all the elements in the specified range for the first template function, or, for the second template function, the result of applying the binary operation specified, instead of the sum operation, to (                        *PartialResult, \*Iter*), where                         *PartialResult* is the result of previous applications of the operation and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is an iterator pointing to an element in the range.  
  
### Remarks  
 The initial value insures that there will be a well-defined result when the range is empty, in which case <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is returned. The binary operation does not need to be associative or commutative. The result is initialized to the initial value <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and then                         *result* = <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> (                        *result*, **\***<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>) is calculated iteratively through the range, where <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is an iterator pointing to successive element in the range. The range must be valid and the complexity is linear with the size of the range. The return type of the binary operator must be convertible to **Type** to ensure closure during the iteration.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **The original vector v1 is:**  
 **( 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 ).**  
**The sum of the integers from 1 to 20 is: 210.**  
**The vector of partial sums is:**  
 **( 1 3 6 10 15 21 28 36 45 55 66 78 91 105 120 136 153 171 190 210 ).**  
**The original vector v3 is:**  
 **( 1 2 3 4 5 6 7 8 9 10 ).**  
**The product of the integers from 1 to 10 is: 3628800.**  
**The vector of partial products is:**  
 **( 1 2 6 24 120 720 5040 40320 362880 3628800 ).**    
##  \<a name="adjacent_difference">\</a>  adjacent_difference  
 Computes the successive differences between each element and its predecessor in an input range and outputs the results to a destination range or computes the result of a generalized procedure where the difference operation is replaced by another, specified binary operation.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 An input iterator addressing the first element in the input range whose elements are to be differenced with their respective predecessors or where the pair of values is to be operated on by another specified binary operation.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 An input iterator addressing the last element in the input range whose elements are to be differenced with their respective predecessors or where the pair of values is to be operated on by another specified binary operation.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 An output iterator addressing the first element a destination range where the series of differences or the results of the specified operation is to be stored.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The binary operation that is to be applied in the generalized operation replacing the operation of subtraction in the differencing procedure.  
  
### Return Value  
 An output iterator addressing the end of the destination range: <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> + ( <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> - <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>).  
  
### Remarks  
 The output iterator _                        *Result* is allowed to be the same iterator as the input iterator  *_First,* so that <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>s may be computed in place.  
  
 For a sequence of values                         *a*1,                         *a*2,                         *a*3, in an input range, the first template function stores successive **partial_difference**s                         *a*1,                         *a*2 -                         *a*1, a3 –                         *a*2, in the destination range.  
  
 For a sequence of values                         *a*1,                         *a*2,                         *a*3, in an input range, the second template function stores successive **partial_difference**s                         *a*1,                         *a*2 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> *a*1,                         *a*3 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> *a*2, in the destination range.  
  
 The binary operation <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is not required to be either associative or commutative, because the order of operations applies is completely specified.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="inner_product">\</a>  inner_product  
 Computes the sum of the element-wise product of two ranges and adds it to a specified initial value or computes the result of a generalized procedure where the sum and product binary operations are replaced by other specified binary operations.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 An input iterator addressing the first element in the first range whose inner product or generalized inner product with the second range is to be computed.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 An input iterator addressing the last element in the first range whose inner product or generalized inner product with the second range is to be computed.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 An input iterator addressing the first element in the second range whose inner product or generalized inner product with the first range is to be computed.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 An initial value to which the inner product or generalized inner product between the ranges is to be added.  
  
 *_Binary_op1*  
 The binary operation that replaces the inner product operation of sum applied to the element-wise products in the generalization of the inner product.  
  
 *_Binary_op2*  
 The binary operation that replaces the inner product element-wise operation of multiply in the generalization of the inner product.  
  
### Return Value  
 The first member function returns the sum of the element-wise products and adds to it the specified initial value. So for ranges of values                         *a*i and                         *b*i, it returns:  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> + (                         *a*1 \*                         *b*1 ) + (                         *a*2 \*                         *b*2 ) +  
  
 by iteratively replacing <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> + (\*                        *a*i \* \*                        *b*i ).  
  
 The second member function returns:  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> _                        *Binary_op1* (                         *a*1 \_                        *Binary_op2* *b*1 ) \_                        *Binary_op1* (                         *a*2 \_                        *Binary_op2* *b*2 ) \_                        *Binary_op1*  
  
 by iteratively replacing <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> _                        *Binary_op1* (\*                        *a*i \_                        *Binary_op2* \*                        *b*i ).  
  
### Remarks  
 The initial value ensures that there will be a well-defined result when the range is empty, in which case <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is returned. The binary operations do not need to be associative or commutative. The range must be valid and the complexity is linear with the size of the range. The return type of the binary operator must be convertible to **Type** to ensure closure during the iteration.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="iota">\</a>  iota  
 Stores a starting value, beginning with the first element and filling with successive increments of that value ( <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>) in each of the elements in the interval <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 An input iterator that addresses the first element in the range to be filled.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 An input iterator that addresses the last element in the range to be filled.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The starting value to store in the first element and to successively increment for subsequent elements.  
  
### Remarks  
  
### Example  
  The following example demonstrates some uses for the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> function by filling a [list](../vs140/-list-.md) of integers and then filling a [vector](../vs140/-vector-.md) with the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> so that the [random_shuffle](../vs140/-algorithm--functions.md#random_shuffle) function can be used.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="partial_sum">\</a>  partial_sum  
 Computes a series of sums in an input range from the first element through the                 *i*th element and stores the result of each such sum in the                 *i*th element of a destination range or computes the result of a generalized procedure where the sum operation is replaced by another specified binary operation.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 An input iterator addressing the first element in the range to be partially summed or combined according to a specified binary operation.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 An input iterator addressing the last element in the range to be partially summed or combined according to a specified binary operation that is one position beyond the final element actually included in the iterated accumulation.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 An output iterator addressing the first element a destination range where the series of partial sums or the results of the specified operation is to be stored.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The binary operation that is to be applied in the generalized operation replacing the operation of sum in the partial sum procedure.  
  
### Return Value  
 An output iterator addressing the end of the destination range: <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> + ( <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> - <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>),  
  
### Remarks  
 The output iterator <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> is allowed to be the same iterator as the input iterator <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, so that partial sums may be computed in place.  
  
 For a sequence of values                         *a*1,                         *a*2,                         *a*3,  in an input range, the first template function stores successive partial sums in the destination range, where the                         *i*th element is given by (  ( (                        *a*1 +                         *a*2) +                         *a*3)                          *a*i).  
  
 For a sequence of values                         *a*1,                         *a*2,                         *a*3,  in an input range, the second template function stores successive partial sums in the destination range, where the ith element is given by (  ( (                         *a*1<CodeContentPlaceHolder>59\</CodeContentPlaceHolder> *a*2 ) <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> *a*3 )                          *a*i).  
  
 The binary operation <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> is not required to be either associative or commutative, because the order of operations applies is completely specified.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## See Also  
 [&lt;numeric&gt;](../vs140/-numeric-.md)