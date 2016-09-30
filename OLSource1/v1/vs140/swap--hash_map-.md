---
title: "swap (hash_map)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std.swap"
  - "std::swap"
  - "hash_map/stdext::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap function"
ms.assetid: ff216afe-14d6-4f9e-a146-8bee2c3fa5d8
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# swap (hash_map)
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Exchanges the elements of two hash_maps.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The hash_map whose elements are to be exchanged with those of the map <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The hash_map whose elements are to be exchanged with those of the map <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 The template function is an algorithm specialized on the container class hash_map to execute the member function <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>[swap](../vs140/hash_map--swap.md)*(_Right*). This is an instance of the partial ordering of function templates by the compiler. When template functions are overloaded in such a way that the match of the template with the function call is not unique, then the compiler will select the most specialized version of the template function. The general version of the template function, **template \<class T> void swap(T&, T&)**, in the algorithm header file works by assignment and is a slow operation. The specialized version in each container is much faster as it can work with the internal representation of the container class.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See the example for the member function [hash_map::swap](../vs140/hash_map--swap.md)or an example of the use of the template version of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)