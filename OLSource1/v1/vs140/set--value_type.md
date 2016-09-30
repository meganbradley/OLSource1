---
title: "set::value_type"
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
  - "set/std::set::value_type"
  - "std::set::value_type"
  - "set::value_type"
  - "set.value_type"
  - "std.set.value_type"
  - "value_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_type typedef"
ms.assetid: 15700abd-4561-4736-9a05-08a47e5dae27
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::value_type
A type that describes an object stored as an element of a set in its capacity as a value.  
  
## Syntax  
  
```  
typedef Key value_type;  
```  
  
## Remarks  
 `value_type` is a synonym for the template parameter `Key`.  
  
 For more information on `Key`, see the Remarks section of the [set Class](../vs140/set-class.md) topic.  
  
 Note that both [key_type](../vs140/set--key_type.md) and `value_type` are synonyms for the template parameter **Key**. Both types are provided for the set and multiset classes, where they are identical, for compatibility with the map and multimap classes, where they are distinct.  
  
## Example  
  
```  
// set_value_type.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   set <int> s1;  
   set <int>::iterator s1_Iter;  
  
   set <int>::value_type svt_Int;   // Declare value_type  
   svt_Int = 10;            // Initialize value_type  
  
   set <int> :: key_type skt_Int;   // Declare key_type  
   skt_Int = 20;             // Initialize key_type  
  
   s1.insert( svt_Int );         // Insert value into s1  
   s1.insert( skt_Int );         // Insert key into s1  
  
   // A set accepts key_types or value_types as elements  
   cout << "The set has elements:";  
   for ( s1_Iter = s1.begin( ) ; s1_Iter != s1.end( ); s1_Iter++)  
      cout << " " << *s1_Iter;  
   cout << "." << endl;  
}  
```  
  
 **The set has elements: 10 20.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)