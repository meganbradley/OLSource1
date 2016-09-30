---
title: "minmax"
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
  - "std::minmax"
  - "std.minmax"
  - "minmax"
  - "xutility/std::minmax"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "minmax"
  - "minmax function"
ms.assetid: 83ba8b0d-6fec-4aa8-8e41-ec2eed73e7a2
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# minmax
Compares two input parameters and returns them as a pair, in order of lesser to greater.  
  
## Syntax  
  
```  
template<class Type>  
    pair<const Type&, const Type&>  
        minmax(  
            const Type& _Left,   
            const Type& _Right  
        );  
template<class Type, class BinaryPredicate>  
    pair<const Type&, const Type&>  
        minmax(  
            const Type& _Left,  
            const Type& _Right,  
            BinaryPredicate _Comp  
        );  
template<class Type>     pair<Type&, Type&>         minmax(  
            initializer_list<Type> _Ilist  
        );  
template<class Type, class BinaryPredicate>   
    pair<Type&, Type&>         minmax(  
            initializer_list<Type> _Ilist,   
            BinaryPredicate _Comp  
        );  
  
```  
  
#### Parameters  
 `_Left`  
 The first of the two objects being compared.  
  
 `_Right`  
 The second of the two objects being compared.  
  
 `_Comp`  
 A binary predicate used to compare the two objects.  
  
 `_IList`  
 The initializer_list that contains the members to be compared.  
  
## Return Value  
 Returns a pair of objects where the first is the lesser and the second is the greater. In the case of an initializer_list, the pair is the least object and the greatest object in the list.  
  
## Remarks  
 The first template function returns `pair<const Type&, const Type&>(``_Right``,` `_Left``)` if `_Right` is less than `_Left`. Otherwise, it returns `pair<const Type&, const Type&>(``_Left``,` `_Right``)`.  
  
 The second member function returns a pair where the first element is the lesser and the second is the greater when compared by the predicate `_Comp`.  
  
 The remaining template functions behave the same, except that they replace the `_Left` and `_Right` parameters with `_IList`.  
  
 The function performs exactly one comparison.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [minmax_element](../vs140/minmax_element.md)   
 [min](../vs140/min.md)   
 [min_element](../vs140/min_element.md)   
 [max](../vs140/max.md)   
 [max_element](../vs140/max_element.md)   
 [\<algorithm>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)