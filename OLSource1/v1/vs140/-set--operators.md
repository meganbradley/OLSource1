---
title: "&lt;set&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: b4256ebc-c449-4688-95db-fced42d20d4d
caps.latest.revision: 10
---
# &lt;set&gt; operators
||||  
|-|-|-|  
|[operator!= (set)](#operator_neq)|[operator&gt; (set)](#operator_gt_)|[operator&gt;= (set)](#operator_gt__eq)|  
|[operator&lt; (set)](#operator_lt_)|[operator&lt;= (set)](#operator_lt__eq)|[operator== (set)](#operator_eq_eq)|  
|[operator!= (multiset)](#operator_neq_multiset)|[operator&gt; (multiset)](#operator_gt_multiset)|[operator&gt;= (multiset)](#operator_gt__eq_multiset)|  
|[operator&lt; (multiset)](#operator_lt_multiset)|[operator&lt;= (multiset)](#operator_lt__eq_multiset)|[operator== (multiset)](#operator_eq_eq_multiset)|  
  
##  \<a name="operator_neq">\</a>  operator!= (set)  
 Tests if the set object on the left side of the operator is not equal to the set object on the right side.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 An object of type **set**.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 An object of type **set**.  
  
### Return Value  
 **true** if the sets are not equal; **false** if sets are equal.  
  
### Remarks  
 The comparison between set objects is based on a pairwise comparison between their elements. Two sets are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="operator_lt_">\</a>  operator&lt; (set)  
 Tests if the set object on the left side of the operator is less than the set object on the right side.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 An object of type **set**.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 An object of type **set**.  
  
### Return Value  
 **true** if the set on the left side of the operator is strictly less than the set on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between set objects is based on a pairwise comparison of their elements. The less-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="operator_lt__eq">\</a>  operator&lt;= (set)  
 Tests if the set object on the left side of the operator is less than or equal to the set object on the right side.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 An object of type **set**.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 An object of type **set**.  
  
### Return Value  
 **true** if the set on the left side of the operator is less than or equal to the set on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between set objects is based on a pairwise comparison of their elements. The less than or equal to relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="operator_eq_eq">\</a>  operator== (set)  
 Tests if the set object on the left side of the operator is equal to the set object on the right side.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 An object of type **set**.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 An object of type **set**.  
  
### Return Value  
 **true** if the set on the left side of the operator is equal to the set on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between set objects is based on a pairwise comparison of their elements. Two sets are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="operator_gt_">\</a>  operator&gt; (set)  
 Tests if the set object on the left side of the operator is greater than the set object on the right side.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 An object of type **set**.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 An object of type **set**.  
  
### Return Value  
 **true** if the set on the left side of the operator is greater than the set on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between set objects is based on a pairwise comparison of their elements. The greater-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="operator_gt__eq">\</a>  operator&gt;= (set)  
 Tests if the set object on the left side of the operator is greater than or equal to the set object on the right side.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 An object of type **set**.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 An object of type **set**.  
  
### Return Value  
 **true** if the set on the left side of the operator is greater than or equal to the set on the right side of the list; otherwise **false**.  
  
### Remarks  
 The comparison between set objects is based on a pairwise comparison of their elements. The greater than or equal to relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="operator_neq_multiset">\</a>  operator!= (multiset)  
 Tests if the multiset object on the left side of the operator is not equal to the multiset object on the right side.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the sets or multisets are not equal; **false** if sets or multisets are equal.  
  
### Remarks  
 The comparison between multiset objects is based on a pairwise comparison between their elements. Two sets or multisets are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="operator_lt_multiset">\</a>  operator&lt; (multiset)  
 Tests if the multiset object on the left side of the operator is less than the multiset object on the right side.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the multiset on the left side of the operator is strictly less than the multiset on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between multiset objects is based on a pairwise comparison of their elements. The less-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="operator_lt__eq_multiset">\</a>  operator&lt;= (multiset)  
 Tests if the multiset object on the left side of the operator is less than or equal to the multiset object on the right side.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the multiset on the left side of the operator is less than or equal to the multiset on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between multiset objects is based on a pairwise comparison of their elements. The less than or equal to relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="operator_eq_eq_multiset">\</a>  operator== (multiset)  
 Tests if the multiset object on the left side of the operator is equal to the multiset object on the right side.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the multiset on the left side of the operator is equal to the multiset on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between multiset objects is based on a pairwise comparison of their elements. Two sets or multisets are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
##  \<a name="operator_gt_multiset">\</a>  operator&gt; (multiset)  
 Tests if the multiset object on the left side of the operator is greater than the multiset object on the right side.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the multiset on the left side of the operator is greater than the multiset on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between multiset objects is based on a pairwise comparison of their elements. The greater-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
##  \<a name="operator_gt__eq_multiset">\</a>  operator&gt;= (multiset)  
 Tests if the multiset object on the left side of the operator is greater than or equal to the multiset object on the right side.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the multiset on the left side of the operator is greater than or equal to the multiset on the right side of the list; otherwise **false**.  
  
### Remarks  
 The comparison between multiset objects is based on a pairwise comparison of their elements. The greater than or equal to relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
## See Also  
 [&lt;set&gt;](../vs140/-set-.md)