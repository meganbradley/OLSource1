---
title: "map::at"
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
  - "map.at"
  - "std.map.at"
  - "std::map::at"
  - "at"
  - "map/std::map::at"
  - "map::at"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "at method"
ms.assetid: 4d8df16b-ad09-4962-8d87-abf7cfdefbf0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::at
Finds an element with a specified key value.  
  
## Syntax  
  
```  
  
      Type& at(  
   const Key& _Key  
);  
const Type& at(  
   const Key& _Key  
) const;  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Key`|The key value to find.|  
  
## Return Value  
 A reference to the data value of the element found.  
  
## Remarks  
 If the argument key value is not found, then the function throws an object of class [out_of_range Class](../vs140/out_of_range-class.md).  
  
## Example  
  
```  
// map_at.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
typedef std::map<char, int> Mymap;   
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
c1.at('a') == 1  
c1.at('b') == 2  
c1.at('c') == 3  
```  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)