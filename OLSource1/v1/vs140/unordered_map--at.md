---
title: "unordered_map::at"
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
  - "unordered_map/std::tr1::unordered_map::at"
  - "tr1.unordered_map.at"
  - "at"
  - "unordered_map.at"
  - "tr1::unordered_map::at"
  - "std::tr1::unordered_map::at"
  - "unordered_map::at"
  - "std.tr1.unordered_map.at"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "at method"
ms.assetid: b5201140-4d5e-47c9-b815-ed0afcb918d1
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::at
Finds an element in a unordered_map with a specified key value.  
  
## Syntax  
  
```  
  
      Ty& at(const Key&   
      _Key  
      );  
const Ty& at(const Key& _Key) const;  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Key`|The key value to find.|  
  
## Return Value  
 A reference to the data value of the element found.  
  
## Remarks  
 If the argument key value is not found, then the function throws an object of class `out_of_range`.  
  
## Example  
  
```  
// unordered_map_at.cpp  
// compile with: /EHsc  
#include <unordered_map>  
#include <iostream>  
  
typedef std::unordered_map<char, int> Mymap;   
int main()   
    {   
    Mymap c1;   
  
    c1.insert(Mymap::value_type('a', 1));   
    c1.insert(Mymap::value_type('b', 2));   
    c1.insert(Mymap::value_type('c', 3));   
  
// find and show elements  
    std::cout << "c1.at('a') == " << c1.at('a') << std::endl;   
    std::cout << "c1.at('b') == " << c1.at('b') << std::endl;   
    std::cout << "c1.at('c') == " << c1.at('c') << std::endl;   
  
    return (0);   
    }   
```  
  
## Output  
  
```  
c1.at('a') == 10  
c1.at('b') == 20  
c1.at('c') == 30  
```  
  
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)