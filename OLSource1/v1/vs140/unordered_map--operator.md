---
title: "unordered_map::operator"
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
  - "unordered_map/std::tr1::unordered_map::operator[]"
  - "tr1::unordered_map::operator[]"
  - "unordered_map::operator[]"
  - "operator[]"
  - "std::tr1::unordered_map::operator[]"
  - "std.tr1.unordered_map.operator[]"
  - "unordered_map.operator[]"
  - "tr1.unordered_map.operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator[] operator [TR1]"
  - "operator[]"
ms.assetid: 4584d4af-72b4-48da-9f35-3100d54a9bb4
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::operator
Finds or inserts an element with the specified key.  
  
## Syntax  
  
```  
Ty& operator[](const Key& keyval);  
Ty& operator[](Key&& keyval);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`Keyval`|The key value to find or insert.|  
  
## Return Value  
 A reference to the data value of the inserted element.  
  
## Remarks  
 If the argument key value is not found, then it is inserted along with the default value of the data type.  
  
 `operator[]` may be used to insert elements into a map *m* using *m*[_*Key*] = `DataValue`; where `DataValue` is the value of the `mapped_type` of the element with a key value of \_*Key*.  
  
 When using `operator[]` to insert elements, the returned reference does not indicate whether an insertion is changing a pre-existing element or creating a new one. The member functions [find](../vs140/map--find.md) and [insert](../vs140/map--insert.md) can be used to determine whether an element with a specified key is already present before an insertion.  
  
## Example  
  
```  
// std__unordered_map__unordered_map_operator_sub.cpp   
// compile with: /EHsc   
#include <unordered_map>   
#include <iostream>   
#include <string>  
  
typedef std::unordered_map<char, int> Mymap;   
int main()   
    {   
    Mymap c1;   
  
    c1.insert(Mymap::value_type('a', 1));   
    c1.insert(Mymap::value_type('b', 2));   
    c1.insert(Mymap::value_type('c', 3));   
  
// display contents " [c 3] [b 2] [a 1]"   
    for (Mymap::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " [" << it->first << ", " << it->second << "]";   
    std::cout << std::endl;   
  
// try to find and fail   
    std::cout << "c1['A'] == " << c1['A'] << std::endl;   
  
// try to find and succeed   
    std::cout << "c1['a'] == " << c1['a'] << std::endl;   
  
// redisplay contents   
    for (Mymap::const_iterator it = c1.begin();   
        it != c1.end(); ++it)   
        std::cout << " [" << it->first << ", " << it->second << "]";   
    std::cout << std::endl;   
  
// insert by moving key  
    std::tr1::unordered_map<string, int> c2;  
    std::string str("abc");  
    std::cout << "c2[std::move(str)] == " << c2[std::move(str)] << std::endl;  
    std::cout << "c2["abc"] == " << c2["abc"] << std::endl;  
  
    return (0);   
    }  
  
```  
  
  **[c, 3] [b, 2] [a, 1]**  
**c1['A'] == 0**  
**c1['a'] == 1**  
 **[c, 3] [b, 2] [A, 0] [a, 1]**  
**c2[move(str)] == 0**  
**c2["abc"] == 1**   
## Remarks  
 The member function determines the iterator `where` as the return value of [insert](../vs140/unordered_map--insert.md)`(` [value_type](../vs140/unordered_map--value_type.md)`(keyval, Ty())`. (It inserts an element with the specified key if no such element exists.) It then returns a reference to `(*where).second`.  
  
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::find](../vs140/unordered_map--find.md)   
 [unordered_map::insert](../vs140/unordered_map--insert.md)