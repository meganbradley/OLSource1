---
title: "piecewise_constant_distribution Class"
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
  - "std.tr1.piecewise_constant_distribution"
  - "tr1.piecewise_constant_distribution"
  - "tr1::piecewise_constant_distribution"
  - "std::tr1::piecewise_constant_distribution"
  - "random/std::tr1::piecewise_constant_distribution"
  - "piecewise_constant_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "piecewise_constant_distribution class"
ms.assetid: 2c9a21fa-623e-4d63-b827-3f1556b6dedb
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# piecewise_constant_distribution Class
Generates a piecewise constant distribution that has varying-width intervals with uniform probability in each interval.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The floating point result type, defaults to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For possible types, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 This sampling distribution has varying-width intervals with uniform probability in each interval. For information about other sampling distributions, see [piecewise_linear_distribution](../vs140/piecewise_linear_distribution-class.md) and [discrete_distribution](../vs140/discrete_distribution-class.md).  
  
 The following table links to articles about individual members:  
  
||||  
|-|-|-|  
|[piecewise_constant_distribution::piecewise_constant_distribution](#piecewise_constant_distribution__piecewise_constant_distribution)|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|[piecewise_constant_distribution::param_type](#piecewise_constant_distribution__param_type)|  
  
 The property function <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> returns a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> with the set of stored intervals of the distribution.  
  
 The property function <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> returns a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> with the stored densities for each interval set, which are calculated according to the weights provided in the constructor parameters.  
  
 For more information about distribution classes and their members, see [\<random>](../vs140/-random-.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 **Use CTRL-Z to bypass data entry and run using default values.Enter an integer value for the sample count: 100min() == 0max() == 15intervals (index: interval):          0:   0.0000000000          1:   1.0000000000          2:   6.0000000000          3:  15.0000000000densities (index: density):          0:   0.0625000000          1:   0.0625000000          2:   0.0694444444Distribution for 100 samples:    0-1 :::::::    1-2 ::::::    2-3 :::::    3-4 ::::::    4-5 :::::::    5-6 ::::::    6-7 :::    7-8 ::::::::::    8-9 ::::::    9-10 ::::::::::::   10-11 :::::   11-12 ::::::   12-13 :::::::::   13-14 ::::   14-15 ::::::::**   
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
##  \<a name="piecewise_constant_distribution__piecewise_constant_distribution">\</a>  piecewise_constant_distribution::piecewise_constant_distribution  
 Constructs the distribution.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 An input iterator of the first element in the distribution range.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 An input iterator of the last element in the distribution range.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 An input iterator of the first element in the weights range.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 An [initializer_list](../vs140/initializers.md) with the intervals of the distribution.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The number of elements in the distribution range.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The lowest value in the distribution range.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The highest value in the distribution range. Must be greater than <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The object representing the probability function for the distribution. Both the parameter and the return value must be convertible to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The parameter structure used to construct the distribution.  
  
### Remarks  
 The default constructor sets the stored parameters such that there is one interval, 0 to 1, with a probability density of 1.  
  
 The iterator range constructor  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 constructs a distribution object with itnervals from iterators over the sequence [ <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>) and a matching weight sequence starting at <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 The initializer list constructor  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 constructs a distribution object with intervals from the intializer list <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and weights generated from the function <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
 The constructor defined as  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 constructs a distribution object with <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> intervals distributed uniformly over [ <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>], assigning each interval weights according to the function <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> must accept one parameter and have a return value, both of which are convertible to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.                         **Precondition:**<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
 The constructor defined as  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 constructs a distribution object using <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> as the stored parameter structure.  
  
##  \<a name="piecewise_constant_distribution__param_type">\</a>  piecewise_constant_distribution::param_type  
 Stores all the parameters of the distribution.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 See parent topic [piecewise_constant_distribution Class](../vs140/piecewise_constant_distribution-class.md).  
  
### Remarks  
 **Precondition:** <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
 This structure can be passed to the distribution's class constructor at instantiation, to the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> member function to set the stored parameters of an existing distribution, and to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to be used in place of the stored parameters.  
  
## See Also  
 [\<random>](../vs140/-random-.md)   
 [piecewise_linear_distribution](../vs140/piecewise_linear_distribution-class.md)