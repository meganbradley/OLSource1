---
title: "&lt;map&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 7df02b9f-701c-44ed-834a-a819badc5bd0
caps.latest.revision: 9
---
# &lt;map&gt; operators
||||  
|-|-|-|  
|[operator!= (map)](#operator_neq)|[operator&gt; (map)](#operator_gt_)|[operator&gt;= (map)](#operator_gt__eq)|  
|[operator&lt; (map)](#operator_lt_)|[operator&lt;= (map)](#operator_lt__eq)|[operator== (map)](#operator_eq_eq)|  
|[operator!= (multimap)](#operator_neq_multimap)|[operator&gt; (multimap)](#operator_gt_multimap)|[operator&gt;= (multimap)](#operator_gt__eq_multimap)|  
|[operator&lt; (multimap)](#operator_lt_multimap)|[operator&lt;= (multimap)](#operator_lt__eq_multimap)|[operator== (multimap)](#operator_eq_eq_multimap)|  
  
##  \<a name="operator_neq">\</a>  operator!=  
 Tests if the map object on the left side of the operator is not equal to the map object on the right side.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 An object of type **map**.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 An object of type **map**.  
  
### Return Value  
 **true** if the maps are not equal; **false** if maps are equal.  
  
### Remarks  
 The comparison between map objects is based on a pairwise comparison of their elements. Two maps are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="operator_lt_">\</a>  operator&lt;  
 Tests if the map object on the left side of the operator is less than the map object on the right side.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 An object of type **map**.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 An object of type **map**.  
  
### Return Value  
 **true** if the map on the left side of the operator is strictly less than the map on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between map objects is based on a pairwise comparison of their elements. The less-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="operator_lt__eq">\</a>  operator&lt;=  
 Tests if the map object on the left side of the operator is less than or equal to the map object on the right side.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 An object of type **map**.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 An object of type **map**.  
  
### Return Value  
 **true** if the map on the left side of the operator is less than or equal to the map on the right side of the operator; otherwise **false**.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="operator_eq_eq">\</a>  operator==  
 Tests if the map object on the left side of the operator is equal to the map object on the right side.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 An object of type **map**.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 An object of type **map**.  
  
### Return Value  
 **true** if the map on the left side of the operator is equal to the map on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between map objects is based on a pairwise comparison of their elements. Two maps are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="operator_gt_">\</a>  operator&gt;  
 Tests if the map object on the left side of the operator is greater than the map object on the right side.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 An object of type **map**.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 An object of type **map**.  
  
### Return Value  
 **true** if the map on the left side of the operator is greater than the map on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between map objects is based on a pairwise comparison of their elements. The greater-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="operator_gt__eq">\</a>  operator&gt;=  
 Tests if the map object on the left side of the operator is greater than or equal to the map object on the right side.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 An object of type **map**.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 An object of type **map**.  
  
### Return Value  
 **true** if the map on the left side of the operator is greater than or equal to the map on the right side of the list; otherwise **false**.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="operator_neq_multimap">\</a>  operator!= (multimap)  
 Tests if the multimap object on the left side of the operator is not equal to the multimap object on the right side.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the multimaps are not equal; **false** if multimaps are equal.  
  
### Remarks  
 The comparison between multimap objects is based on a pairwise comparison of their elements. Two multimaps are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="operator_lt_multimap">\</a>  operator&lt;  
 Tests if the multimap object on the left side of the operator is less than the multimap object on the right side.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the multimap on the left side of the operator is strictly less than the multimap on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between multimap objects is based on a pairwise comparison of their elements. The less-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="operator_lt__eq_multimap">\</a>  operator&lt;=  
 Tests if the multimap object on the left side of the operator is less than or equal to the multimap object on the right side.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the multimap on the left side of the operator is less than or equal to the multimap on the right side of the operator; otherwise **false**.  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="operator_eq_eq_multimap">\</a>  operator==  
 Tests if the multimap object on the left side of the operator is equal to the multimap object on the right side.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the multimap on the left side of the operator is equal to the multimap on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between multimap objects is based on a pairwise comparison of their elements. Two multimaps are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
##  \<a name="operator_gt_multimap">\</a>  operator&gt;  
 Tests if the multimap object on the left side of the operator is greater than the multimap object on the right side.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the multimap on the left side of the operator is greater than the multimap on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between multimap objects is based on a pairwise comparison of their elements. The greater-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
### Example  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
##  \<a name="operator_gt__eq_multimap">\</a>  operator&gt;=  
 Tests if the multimap object on the left side of the operator is greater than or equal to the multimap object on the right side.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the multimap on the left side of the operator is greater than or equal to the multimap on the right side of the list; otherwise **false**.  
  
### Example  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
## See Also  
 [&lt;map&gt;](../vs140/-map-.md)