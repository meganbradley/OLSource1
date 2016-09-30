---
title: "swap test"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: cae0a300-19e4-4f30-8143-9fd7dd86de1d
caps.latest.revision: 10
---
# swap test
|||  
|-|-|  
|[swap](#swap)|[swap (hash_map)](#swap__hash_map_)|  
  
##  \<a name="swap__hash_map_">\</a>  swap (hash_map)  
  
> [!NOTE]
>  This API is obsolete. The alternative is                     [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Exchanges the elements of two hash_maps.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The hash_map whose elements are to be exchanged with those of the map                                 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The hash_map whose elements are to be exchanged with those of the map                                 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
### Remarks  
 The template function is an algorithm specialized on the container class hash_map to execute the member function                         <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>[swap](../vs140/hash_map-class.md#hash_map__swap)*(_Right*). This is an instance of the partial ordering of function templates by the compiler. When template functions are overloaded in such a way that the match of the template with the function call is not unique, then the compiler will select the most specialized version of the template function. The general version of the template function,                         **template \<class T> void swap(T&, T&)**, in the algorithm header file works by assignment and is a slow operation. The specialized version in each container is much faster as it can work with the internal representation of the container class.  
  
 In Visual C++ .NET 2003, members of the                         [\<hash_map>](../vs140/-hash_map-.md) and                         [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See                         [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
 See the example for the member function                                 [hash_map::swap](../vs140/hash_map-class.md#hash_map__swap)or an example of the use of the template version of                                 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
##  \<a name="swap">\</a>  swap  
  
> [!NOTE]
>  This API is obsolete. The alternative is                     [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Exchanges the elements of two hash_multimaps.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The hash_multimap whose elements are to be exchanged with those of the map                                 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The hash_multimap whose elements are to be exchanged with those of the map                                 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
### Remarks  
 The template function is an algorithm specialized on the container class hash_multimap to execute the member function                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>[swap](../vs140/hash_multimap-class.md#hash_multimap__swap)*(_Right*<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. This is an instance of the partial ordering of function templates by the compiler. When template functions are overloaded in such a way that the match of the template with the function call is not unique, then the compiler will select the most specialized version of the template function. The general version of the template function,                         **template \<class T> void swap(T&, T&)**, in the algorithm header file works by assignment and is a slow operation. The specialized version in each container is much faster as it can work with the internal representation of the container class.  
  
 In Visual C++ .NET 2003, members of the                         [\<hash_map>](../vs140/-hash_map-.md) and                         [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See                         [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
### Example  
 See the example for the member function                                 [hash_multimap::swap](../vs140/hash_multimap-class.md#hash_multimap__swap) for an example of the use of the template version of                                 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## See Also  
 [&lt;hash_map&gt;](../vs140/-hash_map-.md)