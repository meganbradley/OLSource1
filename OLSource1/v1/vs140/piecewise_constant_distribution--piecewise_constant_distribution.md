---
title: "piecewise_constant_distribution::piecewise_constant_distribution"
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
  - "piecewise_constant_distribution::piecewise_constant_distribution"
  - "std.tr1.piecewise_constant_distribution.piecewise_constant_distribution"
  - "tr1::piecewise_constant_distribution::piecewise_constant_distribution"
  - "piecewise_constant_distribution.piecewise_constant_distribution"
  - "std::tr1::piecewise_constant_distribution::piecewise_constant_distribution"
  - "random/std::tr1::piecewise_constant_distribution::piecewise_constant_distribution"
  - "tr1.piecewise_constant_distribution.piecewise_constant_distribution"
  - "piecewise_constant_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "piecewise_constant_distribution method"
ms.assetid: f0cb946b-c10b-479e-886e-30b8fb33c033
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# piecewise_constant_distribution::piecewise_constant_distribution
Constructs the distribution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An input iterator of the first element in the distribution range.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An input iterator of the last element in the distribution range.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 An input iterator of the first element in the weights range.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 An [initializer_list](../vs140/initializers.md) with the intervals of the distribution.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The number of elements in the distribution range.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The lowest value in the distribution range.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The highest value in the distribution range. Must be greater than <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The object representing the probability function for the distribution. Both the parameter and the return value must be convertible to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The parameter structure used to construct the distribution.  
  
## Remarks  
 The default constructor sets the stored parameters such that there is one interval, 0 to 1, with a probability density of 1.  
  
 The iterator range constructor  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 constructs a distribution object with itnervals from iterators over the sequence [<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>) and a matching weight sequence starting at <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 The initializer list constructor  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 constructs a distribution object with intervals from the intializer list <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and weights generated from the function <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 The constructor defined as  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 constructs a distribution object with <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> intervals distributed uniformly over [<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>], assigning each interval weights according to the function <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> must accept one parameter and have a return value, both of which are convertible to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. **Precondition:**<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
 The constructor defined as  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 constructs a distribution object using <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> as the stored parameter structure.  
  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
## See Also  
 [\<random>](../vs140/-random-.md)   
 [piecewise_constant_distribution Class](../vs140/piecewise_constant_distribution-class.md)