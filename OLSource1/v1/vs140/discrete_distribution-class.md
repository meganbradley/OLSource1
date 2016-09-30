---
title: "discrete_distribution Class"
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
  - "random/std::tr1::discrete_distribution"
  - "std::tr1::discrete_distribution"
  - "tr1.discrete_distribution"
  - "std.tr1.discrete_distribution"
  - "discrete_distribution"
  - "tr1::discrete_distribution"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "discrete_distribution class"
ms.assetid: 8c8ba8f8-c06f-4f07-b354-f53950142fcf
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# discrete_distribution Class
Generates a discrete integer distribution that has uniform-width intervals with uniform probability in each interval.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The integer result type, defaults to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For possible types, see [\<random>](../vs140/-random-.md).  
  
## Remarks  
 This sampling distribution has uniform-width intervals with uniform probability in each interval. For information about other sampling distributions, see [piecewise_linear_distribution](../vs140/piecewise_linear_distribution-class.md) and [piecewise_constant_distribution](../vs140/piecewise_constant_distribution-class.md).  
  
 The following table links to articles about individual members:  
  
|||  
|-|-|  
|[discrete_distribution::discrete_distribution](#discrete_distribution__discrete_distribution)|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|[discrete_distribution::param_type](#discrete_distribution__param_type)|  
  
 The property function <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> returns the individual probabilities for each integer generated.  
  
 For more information about distribution classes and their members, see [\<random>](../vs140/-random-.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 **Use CTRL-Z to bypass data entry and run using default values.Enter an integer value for the sample count: 100min() == 0max() == 4probabilities (value: probability):          0:   0.0666666667          1:   0.1333333333          2:   0.2000000000          3:   0.2666666667          4:   0.3333333333Distribution for 100 samples:    0 :::::    1 ::::::::::::::    2 :::::::::::::::::    3 ::::::::::::::::::::::::::::::    4 ::::::::::::::::::::::::::::::::::**   
## Requirements  
 **Header:** \<random>  
  
 **Namespace:** std  
  
##  \<a name="discrete_distribution__discrete_distribution">\</a>  discrete_distribution::discrete_distribution  
 Constructs the distribution.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The first iterator in the list from which to construct the distribution.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The last iterator in the list from which to construct the distribution (non-inclusive because iterators use an empty element for the end).  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The [initializer_list](../vs140/initializers.md) from which to construct the distribution.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The number of elements in the distribution range. If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, equivalent to the default constructor (always generates zero).  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The lowest value in the distribution range.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The highest value in the distribution range.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The object representing the probability function for the distribution. Both the parameter and the return value must be convertible to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The parameter structure used to construct the distribution.  
  
### Remarks  
 The default constructor constructs an object whose stored probability value has one element with value 1. This will result in a distribution that always generates a zero.  
  
 The iterator range constructor,  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 constructs a distribution object with weights from iterators over the interval sequence [ <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>).  
  
 The initializer list constructor  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 constructs a distribution object with weights from the intializer list <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 The constructor defined as  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 constructs a distribution object whose stored probability value is initialized based on the following rules. If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, and as such is equivalent to the default constructor, always generating zero. If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. Provided <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> < <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> = ( <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>)/ <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, using <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> uniform subranges each weight is assigned as follows: <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>k = <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> + <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> * <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> + <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>/ <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, for <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, ..., <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
 The constructor defined as  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 constructs a distribution object using <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> as the stored parameter structure.  
  
##  \<a name="discrete_distribution__param_type">\</a>  discrete_distribution::param_type  
 Stores all the parameters of the distribution.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 See parent topic [discrete_distribution Class](../vs140/discrete_distribution-class.md).  
  
### Remarks  
 This parameter package can be passed to [operator()](../vs140/discrete_distribution--operator--.md) to generate the return value.  
  
## See Also  
 [\<random>](../vs140/-random-.md)