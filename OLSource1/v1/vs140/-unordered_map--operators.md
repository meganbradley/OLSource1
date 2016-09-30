---
title: "&lt;unordered_map&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 9d5add0b-84bd-4a79-bd82-3f58b55145ed
caps.latest.revision: 9
---
# &lt;unordered_map&gt; operators
|||||  
|-|-|-|-|  
|[operator!= (map)](#operator_neq)|[operator== (map)](#operator_eq_eq)|[operator!= (multimap)](#operator_neq_multimap)|[operator== (multimap)](#operator_eq_eq_multimap)|  
  
##  \<a name="operator_neq">\</a>  operator!=  
 Tests whether the [unordered_map](../vs140/unordered_map-class.md) object on the left side of the operator is not equal to the unordered_map object on the right side.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the unordered_maps are not equal; <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> if they are equal.  
  
### Remarks  
 The comparison between unordered_map objects is not affected by the arbitrary order in which they store their elements. Two unordered_maps are equal if they have the same number of elements and the elements in one container are a permutation of the elements in the other container. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **Output:**  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
##  \<a name="operator_eq_eq">\</a>  operator==  
 Tests whether the [unordered_map](../vs140/unordered_map-class.md) object on the left side of the operator is equal to the unordered_map object on the right side.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> if the unordered_maps are equal; <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> if they are not equal.  
  
### Remarks  
 The comparison between unordered_map objects is not affected by the arbitrary order in which they store their elements. Two unordered_maps are equal if they have the same number of elements and the elements in one container are a permutation of the elements in the other container. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **Output:**  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
##  \<a name="operator_neq_multimap">\</a>  operator!=  
 Tests whether the [unordered_multimap](../vs140/unordered_multimap-class.md) object on the left side of the operator is not equal to the unordered_multimap object on the right side.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> if the unordered_multimaps are not equal; <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> if they are equal.  
  
### Remarks  
 The comparison between unordered_multimap objects is not affected by the arbitrary order in which they store their elements. Two unordered_multimaps are equal if they have the same number of elements and the elements in one container are a permutation of the elements in the other container. Otherwise, they are not equal.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **Output:**  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
##  \<a name="operator_eq_eq_multimap">\</a>  operator==  
 Tests whether the [unordered_multimap](../vs140/unordered_multimap-class.md) object on the left side of the operator is equal to the unordered_multimap object on the right side.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> if the unordered_multimaps are equal; <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> if they are not equal.  
  
### Remarks  
 The comparison between unordered_multimap objects is not affected by the arbitrary order in which they store their elements. Two unordered_multimaps are equal if they have the same number of elements and the elements in one container are a permutation of the elements in the other container. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **Output:**  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
## See Also  
 [&lt;unordered_map&gt;](../vs140/-unordered_map-.md)