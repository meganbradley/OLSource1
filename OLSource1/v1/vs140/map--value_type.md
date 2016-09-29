---
title: "map::value_type"
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
  - "map::value_type"
  - "std.map.value_type"
  - "map/std::map::value_type"
  - "map.value_type"
  - "std::map::value_type"
  - "value_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_type typedef"
ms.assetid: 136cac59-b154-4a92-956f-15e69d1f65f8
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::value_type
The type of object stored as an element in a map.  
  
## Syntax  
  
```  
typedef pair<const Key, Type> value_type;  
```  
  
## Remark  
 `value_type` is declared to be `pair` *<***const** [key_type](../vs140/map--key_type.md), [mapped_type](../vs140/map--mapped_type.md)*>* and not simply `pair` *<*`key_type`, **mapped_typ***e>* because the keys of an associative container may not be changed using a nonconstant iterator or reference.  
  
## Example  
  
```  
// map_value_type.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   typedef pair <const int, int> cInt2Int;  
   map <int, int> m1;  
   map <int, int> :: key_type key1;  
   map <int, int> :: mapped_type mapped1;  
   map <int, int> :: value_type value1;  
   map <int, int> :: iterator pIter;  
  
   // value_type can be used to pass the correct type  
   // explicitly to avoid implicit type conversion  
   m1.insert ( map <int, int> :: value_type ( 1, 10 ) );  
  
   // Compare other ways to insert objects into a map  
   m1.insert ( cInt2Int ( 2, 20 ) );  
   m1[ 3 ] = 30;  
  
   // Initializing key1 and mapped1  
   key1 = ( m1.begin( ) -> first );  
   mapped1 = ( m1.begin( ) -> second );  
  
   cout << "The key of first element in the map is "  
        << key1 << "." << endl;  
  
   cout << "The data value of first element in the map is "  
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
  
## Output  
  
```  
The key of first element in the map is 1.  
The data value of first element in the map is 10.  
The keys of the mapped elements are: 1 2 3.  
The values of the mapped elements are: 10 20 30.  
```  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)