---
title: "hash_map::rehash (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: hash_map::rehash (STL/CLR)
f1_keywords: 
  - cliext::hash_map::rehash
dev_langs: 
  - C++
helpviewer_keywords: 
  - rehash member [STL/CLR]
ms.assetid: e894157c-4e31-4fbf-8020-b90f236da3e7
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_map::rehash (STL-CLR)
Rebuilds the hash table.  
  
## Syntax  
  
```  
void rehash();  
```  
  
## Remarks  
 The member function rebuilds the hash table, ensuring that [load_factor](../vs140/hash_map--load_factor--stl-clr-.md)`() <=` [max_load_factor](../vs140/hash_map--max_load_factor--stl-clr-.md). Otherwise, the hash table increases in size only as needed after an insertion. (It never automatically decreases in size.) You use it to adjust the size of the hash table.  
  
## Example  
  
```  
// cliext_hash_map_rehash.cpp   
// compile with: /clr   
#include <cliext/hash_map>   
  
typedef cliext::hash_map<wchar_t, int> Myhash_map;   
int main()   
    {   
    Myhash_map c1 = gcnew Myhash_map;   
    c1.insert(Myhash_map::make_value(L'a', 1));   
    c1.insert(Myhash_map::make_value(L'b', 2));   
    c1.insert(Myhash_map::make_value(L'c', 3));   
  
// display contents " [a 1] [b 2] [c 3]"   
    for each (Myhash_map::value_type elem in c1)   
        System::Console::Write(" [{0} {1}]", elem->first, elem->second);   
    System::Console::WriteLine();   
  
// inspect current parameters   
    System::Console::WriteLine("bucket_count() = {0}", c1.bucket_count());   
    System::Console::WriteLine("load_factor() = {0}", c1.load_factor());   
    System::Console::WriteLine("max_load_factor() = {0}",   
        c1.max_load_factor());   
    System::Console::WriteLine();   
  
// change max_load_factor and redisplay   
    c1.max_load_factor(0.25f);   
    System::Console::WriteLine("bucket_count() = {0}", c1.bucket_count());   
    System::Console::WriteLine("load_factor() = {0}", c1.load_factor());   
    System::Console::WriteLine("max_load_factor() = {0}",   
        c1.max_load_factor());   
    System::Console::WriteLine();   
  
// rehash and redisplay   
    c1.rehash(100);   
    System::Console::WriteLine("bucket_count() = {0}", c1.bucket_count());   
    System::Console::WriteLine("load_factor() = {0}", c1.load_factor());   
    System::Console::WriteLine("max_load_factor() = {0}",   
        c1.max_load_factor());   
    return (0);   
    }  
  
```  
  
  **[a 1] [b 2] [c 3]**  
**bucket_count() = 16**  
**load_factor() = 0.1875**  
**max_load_factor() = 4**  
**bucket_count() = 16**  
**load_factor() = 0.1875**  
**max_load_factor() = 0.25**  
**bucket_count() = 128**  
**load_factor() = 0.0234375**  
**max_load_factor() = 0.25**   
## Requirements  
 **Header:** <cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_map](../vs140/hash_map--stl-clr-.md)   
 [bucket_count](../vs140/hash_map--bucket_count--stl-clr-.md)   
 [load_factor](../vs140/hash_map--load_factor--stl-clr-.md)   
 [max_load_factor](../vs140/hash_map--max_load_factor--stl-clr-.md)