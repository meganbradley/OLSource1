---
title: "&lt;unordered_set&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 8653eea6-12f2-4dd7-aa2f-db38a71599a0
caps.latest.revision: 9
---
# &lt;unordered_set&gt; operators
|||||  
|-|-|-|-|  
|[operator!= (unordered_set)](#operator_neq)|[operator== (unordered_set)](#operator_eq_eq)|[operator!= (unordered_multiset)](#operator_neq_unordered_multiset)|[operator== (unordered_multiset)](#operator_eq_eq_unordered_multiset)|  
  
##  \<a name="operator_neq">\</a>  operator!=  
 Tests whether the [unordered_set](../vs140/unordered_set-class.md) object on the left side of the operator is not equal to the unordered_set object on the right side.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the unordered_sets are not equal; <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> if they are equal.  
  
### Remarks  
 The comparison between unordered_set objects is not affected by the arbitrary order in which they store their elements. Two unordered_sets are equal if they have the same number of elements and the elements in one container are a permutation of the elements in the other container. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **Output:**  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
##  \<a name="operator_eq_eq">\</a>  operator==  
 Tests whether the [unordered_set](../vs140/unordered_set-class.md) object on the left side of the operator is equal to the unordered_set object on the right side.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> if the unordered_sets are equal; <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> if they are not equal.  
  
### Remarks  
 The comparison between unordered_set objects is not affected by the arbitrary order in which they store their elements. Two unordered_sets are equal if they have the same number of elements and the elements in one container are a permutation of the elements in the other container. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **Output:**  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
##  \<a name="operator_neq_unordered_multiset">\</a>  operator!=  
 Tests whether the [unordered_multiset](../vs140/unordered_multiset-class.md) object on the left side of the operator is not equal to the unordered_multiset object on the right side.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> if the unordered_multisets are not equal; <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> if they are equal.  
  
### Remarks  
 The comparison between unordered_multiset objects is not affected by the arbitrary order in which they store their elements. Two unordered_multisets are equal if they have the same number of elements and the elements in one container are a permutation of the elements in the other container. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **Output:**  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
##  \<a name="operator_eq_eq_unordered_multiset">\</a>  operator==  
 Tests whether the [unordered_multiset](../vs140/unordered_multiset-class.md) object on the left side of the operator is equal to the unordered_multiset object on the right side.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> if the unordered_multisets are equal; <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> if they are not equal.  
  
### Remarks  
 The comparison between unordered_multiset objects is not affected by the arbitrary order in which they store their elements. Two unordered_multisets are equal if they have the same number of elements and the elements in one container are a permutation of the elements in the other container. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **Output:**  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
## See Also  
 [&lt;unordered_set&gt;](../vs140/-unordered_set-.md)