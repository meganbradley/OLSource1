---
title: "hash_set::value_type"
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
  - stdext.hash_set.value_type
  - hash_set.value_type
  - hash_set::value_type
  - stdext::hash_set::value_type
  - hash_set/stdext::hash_set::value_type
  - std.hash_set.value_type
  - std::hash_set::value_type
  - value_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - value_type typedef
ms.assetid: f2a923ac-8a63-4f2f-8b3e-d70c17e2ecab
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_set::value_type
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that describes an object stored as an element of a hash_set in its capacity as a value.  
  
## Syntax  
  
```  
typedef Key value_type;  
```  
  
## Remark  
 `value_type` is a synonym for the template parameter `Key`.  
  
 Note that both [key_type](../vs140/hash_set--key_type.md) and `value_type` are synonyms for the template parameter **Key**. Both types are provided for the set and hash_set classes, where they are identical, for compatibility with the map and multimap classes, where they are distinct.  
  
 For more information on `Key`, see the Remarks section of the [hash_set Class](../vs140/hash_set-class.md) topic.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_set_value_type.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_set <int> hs1;  
   hash_set <int>::iterator hs1_Iter;  
  
   hash_set <int> :: value_type hsvt_Int;   // Declare value_type  
   hsvt_Int = 10;             // Initialize value_type  
  
   hash_set <int> :: key_type hskt_Int;   // Declare key_type  
   hskt_Int = 20;             // Initialize key_type  
  
   hs1.insert( hsvt_Int );         // Insert value into hs1  
   hs1.insert( hskt_Int );         // Insert key into hs1  
  
   // A hash_set accepts key_types or value_types as elements  
   cout << "The hash_set has elements:";  
   for ( hs1_Iter = hs1.begin( ) ; hs1_Iter != hs1.end( ); hs1_Iter++)  
      cout << " " << *hs1_Iter;  
   cout << "." << endl;  
}  
```  
  
 **The hash_set has elements: 10 20.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)