---
title: "&lt;set&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: d1277d14-8502-46c0-b820-bcda820f9406
caps.latest.revision: 9
---
# &lt;set&gt; functions
|||  
|-|-|  
|[swap (set)](#swap)|[swap (multiset)](#swap_multiset)|  
  
##  \<a name="swap">\</a>  swap  
 Exchanges the elements of two sets.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The set providing the elements to be swapped, or the set whose elements are to be exchanged with those of the set <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The set whose elements are to be exchanged with those of the set <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
### Remarks  
 The template function is an algorithm specialized on the container class set to execute the member function <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>[swap](../vs140/set-class.md#set__swap)( <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>). This is an instance of the partial ordering of function templates by the compiler. When template functions are overloaded in such a way that the match of the template with the function call is not unique, then the compiler will select the most specialized version of the template function. The general version of the template function  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> \< **classT**> **void swap**( **T&**, **T&**)  
  
 in the algorithm class works by assignment and is a slow operation. The specialized version in each container is much faster as it can work with the internal representation of the container class.  
  
### Example  
  See the code example for the member class [set::swap](../vs140/set-class.md#set__swap) for an example of the use of the template version of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
##  \<a name="swap_multiset">\</a>  swap  
 Exchanges the elements of two multisets.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The multiset providing the elements to be swapped, or the multiset whose elements are to be exchanged with those of the multiset <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The multiset whose elements are to be exchanged with those of the multiset <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
### Remarks  
 The template function is an algorithm specialized on the container class multiset to execute the member function <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>[swap](../vs140/multiset-class.md#multiset__swap)( <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>). This is an instance of the partial ordering of function templates by the compiler. When template functions are overloaded in such a way that the match of the template with the function call is not unique, then the compiler will select the most specialized version of the template function. The general version of the template function  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> \< **classT**> **void swap**( **T&**, **T&**)  
  
 in the algorithm class works by assignment and is a slow operation. The specialized version in each container is much faster as it can work with the internal representation of the container class.  
  
### Example  
  See the code example for the member class [multiset::swap](../vs140/multiset-class.md#multiset__swap)for an example of the use of the template version of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
## See Also  
 [&lt;set&gt;](../vs140/-set-.md)