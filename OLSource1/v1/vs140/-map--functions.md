---
title: "&lt;map&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 7cb3d1a5-7add-4726-a73f-61927eafd466
caps.latest.revision: 9
---
# &lt;map&gt; functions
|||  
|-|-|  
|[swap (map)](#swap)|[swap (multimap)](#swap_multimap)|  
  
##  \<a name="swap_multimap">\</a>  swap  
 Exchanges the elements of two maps.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The map providing the elements to be swapped, or the map whose elements are to be exchanged with those of the map <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The map whose elements are to be exchanged with those of the map <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
### Remarks  
 The template function is an algorithm specialized on the container class map to execute the member function <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>[swap](../vs140/map-class.md#map__swap)*(_Right*). This is an instance of the partial ordering of function templates by the compiler. When template functions are overloaded in such a way that the match of the template with the function call is not unique, then the compiler will select the most specialized version of the template function. The general version of the template function, **template** \< **class T**>  **void swap**( **T&**, **T&**), in the algorithm class works by assignment and is a slow operation. The specialized version in each container is much faster as it can work with the internal representation of the container class.  
  
### Example  
  See the code example for member function [map::swap](../vs140/map-class.md#map__swap) for an example that uses the template version of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
##  \<a name="swap">\</a>  swap  
 Exchanges the elements of two multimaps.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The multimap providing the elements to be swapped, or the multimap whose elements are to be exchanged with those of the multimap <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The multimap whose elements are to be exchanged with those of the multimap <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
### Remarks  
 The template function is an algorithm specialized on the container class map to execute on the container class multimap to execute the member function <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>[swap](multi7876f4c9-ebb4-4878-af1e-09364c43af0a) ( <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>). This is an instance of the partial ordering of function templates by the compiler. When template functions are overloaded in such a way that the match of the template with the function call is not unique, then the compiler will select the most specialized version of the template function. The general version of the template function, **template** \< **class T**>  **void swap**( **T&**, **T&**), in the algorithm class works by assignment and is a slow operation. The specialized version in each container is much faster as it can work with the internal representation of the container class.  
  
### Example  
  See the code example for member function [multimap::swap](multi7876f4c9-ebb4-4878-af1e-09364c43af0a) for an example that uses the template version of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## See Also  
 [&lt;map&gt;](../vs140/-map-.md)