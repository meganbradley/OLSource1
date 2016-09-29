---
title: "std::shuffle"
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
  - "std::shuffle"
dev_langs: 
  - "C++"
ms.assetid: ef345cd0-ef35-4019-9340-7d062fcd2eab
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# std::shuffle
Shuffles (rearranges) elements for a given range by using a random number generator.  
  
## Syntax  
  
```vb  
template<class RandomAccessIterator, class UniformRandomNumberGenerator>  
void shuffle(RandomAccessIterator first,  
    RandomAccessIterator last,  
    UniformRandomNumberGenerator&& gen);  
```  
  
#### Parameters  
 `first`  
 An iterator to the first element in the range to be shuffled, inclusive. Must meet the requirements of `RandomAccessIterator` and `ValueSwappable`.  
  
 `last`  
 An iterator to the last element in the range to be shuffled, exclusive. Must meet the requirements of `RandomAccessIterator` and `ValueSwappable`.  
  
 `gen`  
 The random number generator that the `shuffle()` function will use for the operation. Must meet the requirements of a `UniformRandomNumberGenerator`.  
  
## Remarks  
 For more information, and a code sample that uses `shuffle()`, see [\<random>](../vs140/-random-.md).  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [\<algorithm>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)