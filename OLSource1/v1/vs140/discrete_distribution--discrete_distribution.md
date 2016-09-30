---
title: "discrete_distribution::discrete_distribution"
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
  - "random/std::tr1::discrete_distribution::discrete_distribution"
  - "discrete_distribution.discrete_distribution"
  - "tr1::discrete_distribution::discrete_distribution"
  - "std.tr1.discrete_distribution.discrete_distribution"
  - "discrete_distribution::discrete_distribution"
  - "std::tr1::discrete_distribution::discrete_distribution"
  - "discrete_distribution"
  - "tr1.discrete_distribution.discrete_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "discrete_distribution method"
ms.assetid: 263a48f8-5049-44e8-894f-3c80b9cfdc1d
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# discrete_distribution::discrete_distribution
Constructs the distribution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The first iterator in the list from which to construct the distribution.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The last iterator in the list from which to construct the distribution (non-inclusive because iterators use an empty element for the end).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The [initializer_list](../vs140/initializers.md) from which to construct the distribution.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The number of elements in the distribution range. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, equivalent to the default constructor (always generates zero).  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The lowest value in the distribution range.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The highest value in the distribution range.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The object representing the probability function for the distribution. Both the parameter and the return value must be convertible to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The parameter structure used to construct the distribution.  
  
## Remarks  
 The default constructor constructs an object whose stored probability value has one element with value 1. This will result in a distribution that always generates a zero.  
  
 The iterator range constructor,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 constructs a distribution object with weights from iterators over the interval sequence [<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>).  
  
 The initializer list constructor  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 constructs a distribution object with weights from the intializer list <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 The constructor defined as  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 constructs a distribution object whose stored probability value is initialized based on the following rules. If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and as such is equivalent to the default constructor, always generating zero. If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. Provided <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> < <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> = (<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>)/<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, using <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> uniform subranges each weight is assigned as follows: <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>k = <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> + <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> * <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> + <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, for <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, ..., <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
 The constructor defined as  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 constructs a distribution object using <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> as the stored parameter structure.  
  
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
## See Also  
 [\<random>](../vs140/-random-.md)   
 [discrete_distribution Class](../vs140/discrete_distribution-class.md)