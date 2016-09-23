---
title: "discrete_distribution::discrete_distribution"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - random/std::tr1::discrete_distribution::discrete_distribution
  - discrete_distribution.discrete_distribution
  - tr1::discrete_distribution::discrete_distribution
  - std.tr1.discrete_distribution.discrete_distribution
  - discrete_distribution::discrete_distribution
  - std::tr1::discrete_distribution::discrete_distribution
  - discrete_distribution
  - tr1.discrete_distribution.discrete_distribution
dev_langs: 
  - C++
helpviewer_keywords: 
  - discrete_distribution method
ms.assetid: 263a48f8-5049-44e8-894f-3c80b9cfdc1d
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# discrete_distribution::discrete_distribution
Constructs the distribution.  
  
## Syntax  
  
```  
  
// default constructor  
discrete_distribution();  
  
// constructs using a range of weights, [firstW, lastW)  
template<class InputIterator>  
discrete_distribution(InputIterator firstW, InputIterator lastW);  
  
// constructs using an initializer list for range of weights  
discrete_distribution(initializer_list<double> weightlist);  
  
// constructs using unary operation function  
template<class UnaryOperation>  
discrete_distribution(size_t count, double xmin, double xmax, UnaryOperation weightfunc);  
  
// constructs from an existing param_type structure  
explicit discrete_distribution(const param_type& parm);  
  
```  
  
#### Parameters  
 `firstW`  
 The first iterator in the list from which to construct the distribution.  
  
 `lastW`  
 The last iterator in the list from which to construct the distribution (non-inclusive because iterators use an empty element for the end).  
  
 `weightlist`  
 The [initializer_list](../vs140/initializers.md) from which to construct the distribution.  
  
 `count`  
 The number of elements in the distribution range. If `count==0`, equivalent to the default constructor (always generates zero).  
  
 `minx`  
 The lowest value in the distribution range.  
  
 `maxw`  
 The highest value in the distribution range.  
  
 `weightfunc`  
 The object representing the probability function for the distribution. Both the parameter and the return value must be convertible to `double`.  
  
 `parm`  
 The parameter structure used to construct the distribution.  
  
## Remarks  
 The default constructor constructs an object whose stored probability value has one element with value 1. This will result in a distribution that always generates a zero.  
  
 The iterator range constructor,  
  
```  
template<class InputIterator>  
discrete_distribution(InputIterator firstW, InputIterator lastW);  
  
```  
  
 constructs a distribution object with weights from iterators over the interval sequence [`firstI`, `lastI`).  
  
 The initializer list constructor  
  
```  
discrete_distribution(initializer_list<double> weightlist);  
```  
  
 constructs a distribution object with weights from the intializer list `weightlist`.  
  
 The constructor defined as  
  
```  
template<class UnaryOperation>  
discrete_distribution(size_t count, double xmin, double xmax, UnaryOperation funcweight);  
```  
  
 constructs a distribution object whose stored probability value is initialized based on the following rules. If `count < 1`, `n` = `1`, and as such is equivalent to the default constructor, always generating zero. If `count > 0`, `n` = `count`. Provided `0` < `d` = (`maxw - minw`)/`n`, using `d` uniform subranges each weight is assigned as follows: `weight`k = `weightfunc(x)`, where `x` = `xmin` + `k` * `d` + `d`/`2`, for `k` = `0`, ..., `n - 1`.  
  
 The constructor defined as  
  
```  
explicit discrete_distribution(const param_type& parm);  
```  
  
 constructs a distribution object using `parm` as the stored parameter structure.  
  
## Requirements  
 **Header:** <random\>  
  
 **Namespace:** std  
  
## See Also  
 [<random\>](../vs140/-random-.md)   
 [discrete_distribution Class](../vs140/discrete_distribution-class.md)