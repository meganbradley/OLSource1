---
title: "end"
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
  - end
  - std::end
  - xutility/std::end
  - std.end
  - iterator/std:end
dev_langs: 
  - C++
ms.assetid: 90e02cf5-1d69-42c8-a1e1-9875a4523f76
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# end
Retrieves an iterator to the element that follows the last element in the specified container.  
  
## Syntax  
  
```cpp  
template<class Container>  
    auto end(Container& cont)   
        -> decltype(cont.end());  
template<class Container>  
    auto end(const Container& cont)   
        -> decltype(cont.end());  
template<class Ty, class Size>  
    Ty *end(Ty (&array)[Size]);  
  
```  
  
#### Parameters  
 `cont`  
 A container.  
  
 `array`  
 An array of objects of type `Ty`.  
  
## Return Value  
 The first two template functions return `cont.end()` (the first is non-constant and the second is constant).  
  
 The third template function returns `array + Size`.  
  
## Remarks  
 For a code example, see [begin](../vs140/begin.md).  
  
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [<iterator\>](../vs140/-iterator-.md)   
 [begin](../vs140/begin.md)   
 [cbegin](../vs140/cbegin.md)   
 [cend](../vs140/cend.md)