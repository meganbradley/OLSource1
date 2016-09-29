---
title: "multimap::value_type"
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
  - "multimap.value_type"
  - "std.multimap.value_type"
  - "multimap::value_type"
  - "map/std::multimap::value_type"
  - "std::multimap::value_type"
  - "value_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_type typedef"
ms.assetid: 57b6ae00-9e6c-4131-9e58-418212735c18
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::value_type
A type that represents the type of object stored as an element in a map.  
  
## Syntax  
  
```  
typedef pair<const Key, Type> value_type;  
```  
  
## Remark  
 `value_type` is declared to be `pair` *<***const** [key_type](../vs140/multimap--key_type.md), [mapped_type](../vs140/multimap--mapped_type.md)*>* and not `pair` *<*`key_type`, `mapped_type`*>*, because the keys of an associative container may not be changed using a nonconstant iterator or reference.  
  
## Example  
  
```  
// multimap_value_type.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   typedef pair <const int, int> cInt2Int;  
   multimap <int, int> m1;  
   multimap <int, int> :: key_type key1;  
   multimap <int, int> :: mapped_type mapped1;  
   multimap <int, int> :: value_type value1;  
   multimap <int, int> :: iterator pIter;  
  
   // value_type can be used to pass the correct type  
   // explicitely to avoid implicit type conversion  
   m1.insert ( multimap <int, int> :: value_type ( 1, 10 ) );  
  
   // Compare another way to insert objects into a hash_multimap  
   m1.insert ( cInt2Int ( 2, 20 ) );  
  
   // Initializing key1 and mapped1  
   key1 = ( m1.begin( ) -> first );  
   mapped1 = ( m1.begin( ) -> second );  
  
   cout << "The key of first element in the multimap is "  
        << key1 << "." << endl;  
  
   cout << "The data value of first element in the multimap is "  
        << mapped1 << "." << endl;  
  
   // The following line would cause an error because  
   // the value_type is not assignable  
   // value1 = cInt2Int ( 4, 40 );  
  
   cout  << "The keys of the mapped elements are:";  
   for ( pIter = m1.begin( ) ; pIter != m1.end( ) ; pIter++ )  
      cout << " " << pIter -> first;  
   cout << "." << endl;  
  
   cout  << "The values of the mapped elements are:";  
   for ( pIter = m1.begin( ) ; pIter != m1.end( ) ; pIter++ )  
      cout << " " << pIter -> second;  
   cout << "." << endl;  
}  
```  
  
 **The key of first element in the multimap is 1.**  
**The data value of first element in the multimap is 10.**  
**The keys of the mapped elements are: 1 2.**  
**The values of the mapped elements are: 10 20.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)