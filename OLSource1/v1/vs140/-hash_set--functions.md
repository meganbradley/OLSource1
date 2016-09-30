---
title: "&lt;hash_set&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 557a0162-3728-4537-97dc-f9f6cc7ece94
caps.latest.revision: 9
---
# &lt;hash_set&gt; functions
|||  
|-|-|  
|[swap](#swap)|[swap (hash_multiset)](#swap__hash_multiset_)|  
  
##  \<a name="swap">\</a>  swap  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Exchanges the elements of two hash_sets.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The hash_set providing the elements to be swapped, or the hash_set whose elements are to be exchanged with those of the hash_set <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The hash_set whose elements are to be exchanged with those of the hash_set <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> template function is an algorithm specialized on the container class hash_set to execute the member function <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>[swap](../vs140/hash_set-class.md#hash_set__swap)( <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>). This is an instance of the partial ordering of function templates by the compiler. When template functions are overloaded in such a way that the match of the template with the function call is not unique, then the compiler will select the most specialized version of the template function. The general version of the template function  
  
 **template \<class T> void swap(T&, T&),**  
  
 in the algorithm class works by assignment and is a slow operation. The specialized version in each container is much faster as it can work with the internal representation of the container class.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the code example for the member class [hash_set::swap](../vs140/hash_set-class.md#hash_set__swap) for an example that uses the template version of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
##  \<a name="swap__hash_multiset_">\</a>  swap (hash_multiset)  
  
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Exchanges the elements of two hash_multisets.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The hash_multiset providing the elements to be swapped, or the hash_multiset whose elements are to be exchanged with those of the hash_multiset <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The hash_multiset whose elements are to be exchanged with those of the hash_multiset <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> template function is an algorithm specialized on the container class hash_multiset to execute the member function <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>[swap](../vs140/hash_multiset-class.md#hash_multiset__swap)( <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>). This is an instance of the partial ordering of function templates by the compiler. When template functions are overloaded in such a way that the match of the template with the function call is not unique, then the compiler will select the most specialized version of the template function. The general version of the template function  
  
 **template \<class T> void swap(T&, T&),**  
  
 in the algorithm class works by assignment and is a slow operation. The specialized version in each container is much faster as it can work with the internal representation of the container class.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
  See the code example for the member class [hash_multiset::swap](../vs140/hash_multiset-class.md#hash_multiset__swap) for an example that uses the template version of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## See Also  
 [&lt;hash_set&gt;](../vs140/-hash_set-.md)