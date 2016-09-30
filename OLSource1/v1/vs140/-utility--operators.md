---
title: "&lt;utility&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: a6617109-2cec-4a69-948f-6c87116eda5f
caps.latest.revision: 13
---
# &lt;utility&gt; operators
||||  
|-|-|-|  
|[operator!=](#operator_neq)|[operator&gt;](#operator_gt_)|[operator&gt;=](#operator_gt__eq)|  
|[operator&lt;](#operator_lt_)|[operator&lt;=](#operator_lt__eq)|[operator==](#operator_eq_eq)|  
  
##  \<a name="operator_neq">\</a>  operator!=  
 Tests if the pair object on the left side of the operator is not equal to the pair object on the right side.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 An object of type **pair.**  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the pairs are not equal; **false** if the pairs are equal.  
  
### Remarks  
 One pair is equal to another pair if each of their respective elements is equal. Two pairs are unequal if either the first or the second element of one is not equal to the corresponding element of the other pair.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **The pair p1 is: ( 10, 0.111 ).**  
**The pair p2 is: ( 1000, 0.00111 ).**  
**The pair p3 is: ( 10, 0.111 ).**  
**The pairs p1 and p2 are not equal.**  
**The pairs p1 and p3 are equal.**    
##  \<a name="operator_eq_eq">\</a>  operator==  
 Tests if the pair object on the left side of the operator is equal to the pair object on the right side.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 An object of type **pair.**  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the pairs are equal; **false** if the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>s are not equal.  
  
### Remarks  
 One pair is equal to another pair if each of their respective elements is equal. The function returns <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. **first** == <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. **first** && <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. **second** == <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. **second**. Two pairs are unequal if either the first or the second element of one is not equal to the corresponding element of the other pair.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="operator_lt_">\</a>  operator&lt;  
 Tests if the pair object on the left side of the operator is less than the pair object on the right side.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> on the left side of the operator.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> on the right side of the operator.  
  
### Return Value  
 **true** if the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> on the left side of the operator is strictly less than the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object is said to be strictly less than the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object if <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is less than and not equal <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 In a comparison of pairs, the values' first elements of the two pairs have the highest priority. If they differ, then the result of their comparison is taken as the result of the comparison of the pair. If the values of the first elements are not different, then the values of the second elements are compared and the result of their comparison is taken as the result of the comparison of the pair.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The pair p1 is: ( 10, 0.222 ).**  
**The pair p2 is: ( 100, 0.111 ).**  
**The pair p3 is: ( 10, 0.111 ).**  
**The pair p1 is less than the pair p2.**  
**The pair p1 is not less than the pair p3.**    
##  \<a name="operator_lt__eq">\</a>  operator&lt;=  
 Tests if the pair object on the left side of the operator is less than or equal to the pair object on the right side.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> on the left side of the operator.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> on the right side of the operator.  
  
### Return Value  
 **true** if the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> on the left side of the operator is less than or equal to the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> on the right side of the operator; otherwise **false**.  
  
### Remarks  
 In a comparison of pairs, the values' first elements of the two pairs have the highest priority. If they differ, then the result of their comparison is taken as the result of the comparison of the pair. If the values of the first elements are not different, then the values of the second elements are compared and the result of their comparison is taken as the result of the comparison of the pair.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **The pair p1 is: ( 10, 0.222 ).**  
**The pair p2 is: ( 100, 0.111 ).**  
**The pair p3 is: ( 10, 0.111 ).**  
**The pair p4 is: ( 10, 0.222 ).**  
**The pair p1 is less than or equal to the pair p2.**  
**The pair p1 is greater than the pair p3.**  
**The pair p1 is less than or equal to the pair p4.**    
##  \<a name="operator_gt_">\</a>  operator&gt;  
 Tests if the pair object on the left side of the operator is greater than the pair object on the right side.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> on the left side of the operator.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> on the right side of the operator.  
  
### Return Value  
 **true** if the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> on the left side of the operator is strictly greater than the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object is said to be strictly greater than the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object if <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is greater than and not equal <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
 In a comparison of pairs, the values' first elements of the two pairs have the highest priority. If they differ, then the result of their comparison is taken as the result of the comparison of the pair. If the values of the first elements are not different, then the values of the second elements are compared and the result of their comparison is taken as the result of the comparison of the pair.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The pair p1 is: ( 10, 0.222 ).**  
**The pair p2 is: ( 100, 0.111 ).**  
**The pair p3 is: ( 10, 0.111 ).**  
**The pair p4 is: ( 10, 0.222 ).**  
**The pair p1 is not greater than the pair p2.**  
**The pair p1 is greater than the pair p3.**  
**The pair p1 is not greater than the pair p4.**    
##  \<a name="operator_gt__eq">\</a>  operator&gt;=  
 Tests if the pair object on the left side of the operator is greater than or equal to the pair object on the right side.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> on the left side of the operator.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> on the right side of the operator.  
  
### Return Value  
 **true** if the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> on the left side of the operator is greater than or equal to the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> on the right side of the operator; otherwise **false**.  
  
### Remarks  
 In a comparison of pairs, the values' first elements of the two pairs have the highest priority. If they differ, then the result of their comparison is taken as the result of the comparison of the pair. If the values of the first elements are not different, then the values of the second elements are compared and the result of their comparison is taken as the result of the comparison of the pair.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **The pair p1 is: ( 10, 0.222 ).**  
**The pair p2 is: ( 100, 0.111 ).**  
**The pair p3 is: ( 10, 0.111 ).**  
**The pair p4 is: ( 10, 0.222 ).**  
**The pair p1 is less than the pair p2.**  
**Pair p1 is greater than or equal to pair p3.**  
**Pair p1 is greater than or equal to pair p4.**    
## See Also  
 [&lt;utility&gt;](../vs140/-utility-.md)