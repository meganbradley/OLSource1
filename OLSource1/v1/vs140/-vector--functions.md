---
title: "&lt;vector&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 6cdcf043-eef6-4330-83f0-4596fb9f968a
caps.latest.revision: 11
---
# &lt;vector&gt; functions
||  
|-|  
|[swap](#swap)|  
  
##  \<a name="swap">\</a>  swap  
 Exchanges the elements of two vectors.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The vector providing the elements to be swapped, or the vector whose elements are to be exchanged with those of the vector <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The vector whose elements are to be exchanged with those of the vector <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
### Remarks  
 The template function is an algorithm specialized on the container class vector to execute the member function <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>[vector::swap](../vs140/vector-class.md#vector__swap)*(_Right*). These are instances of the partial ordering of function templates by the compiler. When template functions are overloaded in such a way that the match of the template with the function call is not unique, then the compiler will select the most specialized version of the template function. The general version of the template function, **template** \< **class T**>  **void swap**( **T&**, **T&**), in the algorithm class works by assignment and is a slow operation. The specialized version in each container is much faster as it can work with the internal representation of the container class.  
  
### Example  
  See the code example for member function [vector::swap](../vs140/vector-class.md#vector__swap) for an example that uses the template version of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## See Also  
 [&lt;vector&gt;](../vs140/-vector-.md)