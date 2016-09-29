---
title: "hash_multiset::rehash (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multiset::rehash (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multiset::rehash"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rehash member [STL/CLR]"
ms.assetid: 1208cffc-acee-4c75-87b5-ce9ec641c3b6
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::rehash (STL-CLR)
Rebuilds the hash table.  
  
## Syntax  
  
```  
void rehash();  
```  
  
## Remarks  
 The member function rebuilds the hash table, ensuring that [load_factor](../vs140/hash_multiset--load_factor--stl-clr-.md)`() <=` [max_load_factor](../vs140/hash_multiset--max_load_factor--stl-clr-.md). Otherwise, the hash table increases in size only as needed after an insertion. (It never automatically decreases in size.) You use it to adjust the size of the hash table.  
  
## Example  
  
```  
// cliext_hash_multiset_rehash.cpp   
// compile with: /clr   
#include <cliext/hash_set>   
  
typedef cliext::hash_multiset<wchar_t> Myhash_multiset;   
int main()   
    {   
    Myhash_multiset c1;   
    c1.insert(L'a');   
    c1.insert(L'b');   
    c1.insert(L'c');   
  
// display initial contents " a b c"   
    for each (wchar_t elem in c1)   
        System::Console::Write(" {0}", elem);   
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
  
  **a b c**  
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
 **Header:** <cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_multiset](../vs140/hash_multiset--stl-clr-.md)   
 [bucket_count](../vs140/hash_multiset--bucket_count--stl-clr-.md)   
 [load_factor](../vs140/hash_multiset--load_factor--stl-clr-.md)   
 [max_load_factor](../vs140/hash_multiset--max_load_factor--stl-clr-.md)