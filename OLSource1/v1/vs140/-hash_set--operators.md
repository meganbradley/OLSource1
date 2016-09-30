---
title: "&lt;hash_set&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 403d8e4e-0b3f-43fb-bc5a-8100c4f331c5
caps.latest.revision: 13
---
# &lt;hash_set&gt; operators
||||  
|-|-|-|  
|[operator!=](#operator_neq)|[operator!= (hash_multiset)](#operator_neq__hash_multiset_)|[operator==](#operator_eq_eq)|  
|[operator== (hash_multiset)](#operator_eq_eq__hash_multiset_)|  
  
##  \<a name="operator_neq">\</a>  operator!=  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Tests if the hash_set object on the left side of the operator is not equal to the hash_set object on the right side.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the hash_sets are not equal; **false** if hash_sets are equal.  
  
### Remarks  
 The comparison between hash_set objects is based on a pairwise comparison between their elements. Two hash_sets are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **The hash_sets hs1 and hs2 are not equal.**  
**The hash_sets hs1 and hs3 are equal.**    
##  \<a name="operator_eq_eq">\</a>  operator==  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Tests if the hash_set object on the left side of the operator is equal to the hash_set object on the right side.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the hash_set on the left side of the operator is equal to the hash_set on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between hash_set objects is based on a pairwise comparison of their elements. Two hash_sets are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The hash_sets s1 and s2 are not equal.**  
**The hash_sets s1 and s3 are equal.**    
##  \<a name="operator_neq__hash_multiset_">\</a>  operator!= (hash_multiset)  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Tests if the hash_multiset object on the left side of the operator is not equal to the hash_multiset object on the right side.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the hash_multisets are not equal; **false** if hash_multisets are equal.  
  
### Remarks  
 The comparison between hash_multiset objects is based on a pairwise comparison between their elements. Two hash_multisets are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The hash_multisets hs1 and hs2 are not equal.**  
**The hash_multisets hs1 and hs3 are equal.**    
##  \<a name="operator_eq_eq__hash_multiset_">\</a>  operator== (hash_multiset)  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Tests if the hash_multiset object on the left side of the operator is equal to the hash_multiset object on the right side.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
### Return Value  
 **true** if the hash_multiset on the left side of the operator is equal to the hash_multiset on the right side of the operator; otherwise **false**.  
  
### Remarks  
 The comparison between hash_multiset objects is based on a pairwise comparison of their elements. Two hash_multisets are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **The hash_multisets s1 and s2 are not equal.**  
**The hash_multisets s1 and s2 are equal.**    
## See Also  
 [&lt;hash_set&gt;](../vs140/-hash_set-.md)