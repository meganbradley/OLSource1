---
title: "hash_multiset::value_type"
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
  - "std::hash_multiset::value_type"
  - "stdext::hash_multiset::value_type"
  - "hash_multiset.value_type"
  - "stdext.hash_multiset.value_type"
  - "std.hash_multiset.value_type"
  - "hash_multiset::value_type"
  - "hash_set/stdext::hash_multiset::value_type"
  - "value_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_type typedef"
ms.assetid: 777243cc-fc2e-4ffe-8c87-41299430b8c2
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::value_type
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A type that describes an object stored as an element as a hash_multiset in its capacity as a value.  
  
## Syntax  
  
```  
typedef Key value_type;  
```  
  
## Remark  
 `value_type` is a synonym for the template parameter `Key`.  
  
 For more information on `Key`, see the Remarks section of the [hash_multiset Class](../vs140/hash_multiset-class.md) topic.  
  
 Note that both [key_type](../vs140/hash_multiset--key_type.md) and `value_type` are synonyms for the template parameter **Key**. Both types are provided for the classes hash_set and hash_multiset, where they are identical, for compatibility with the classes hash_map and hash_multimap, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_value_type.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multiset <int> hms1;  
   hash_multiset <int>::iterator hms1_Iter;  
  
   // Declare value_type  
   hash_multiset <int> :: value_type hmsvt_Int;   
  
   hmsvt_Int = 10;   // Initialize value_type  
  
   // Declare key_type  
   hash_multiset <int> :: key_type hmskt_Int;  
   hmskt_Int = 20;             // Initialize key_type  
  
   hms1.insert( hmsvt_Int );         // Insert value into s1  
   hms1.insert( hmskt_Int );         // Insert key into s1  
  
   // A hash_multiset accepts key_types or value_types as elements  
   cout << "The hash_multiset has elements:";  
   for ( hms1_Iter = hms1.begin() ; hms1_Iter != hms1.end( );  
         hms1_Iter++)  
      cout << " " << *hms1_Iter;  
      cout << "." << endl;  
}  
```  
  
 **The hash_multiset has elements: 10 20.**   
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)