---
title: "hash_map::value_comp"
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
  - "hash_map/stdext::hash_map::value_comp"
  - "value_comp"
  - "std.hash_map.value_comp"
  - "hash_map::value_comp"
  - "std::hash_map::value_comp"
  - "hash_map.value_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_comp method"
ms.assetid: 37155286-b786-4ce1-973c-ecbecd5fd205
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::value_comp
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns a function object that determines the order of elements in a hash_map by comparing their key values.  
  
## Syntax  
  
```  
  
value_compare value_comp( ) const;  
  
```  
  
## Return Value  
 Returns the comparison function object that a hash_map uses to order its elements.  
  
## Remarks  
 For a hash_map *m*, if two elements *e*1*(k*1*, d*1*)* and *e*2*(k*2*, d*2*)* are objects of type [value_type](../vs140/hash_map--value_type.md), where *k*1 and *k*2 are their keys of type [key_type](../vs140/hash_map--key_type.md) and `d`1 and `d`2 are their data of type [mapped_type](../vs140/hash_map--mapped_type.md), then *m.*`value_comp`*( )(e*1*, e*2*)* is equivalent to *m.*`key_comp`*( ) (k*1*, k*2*)*. A stored object defines the member function  
  
 **bool operator**(**value_type&** `_Left`, **value_type&** `_Right`)**;**  
  
 which returns **true** if the key value of `_Left` precedes and is not equal to the key value of `_Right` in the sort order.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_map_value_comp.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
  
   hash_map <int, int, hash_compare<int, less<int> > > hm1;  
   hash_map <int, int, hash_compare<int, less<int> > >  
   ::value_compare vc1 = hm1.value_comp( );  
   pair< hash_map<int,int>::iterator, bool > pr1, pr2;  
  
   pr1= hm1.insert ( hash_map <int, int> :: value_type ( 1, 10 ) );  
   pr2= hm1.insert ( hash_map <int, int> :: value_type ( 2, 5 ) );  
  
   if( vc1( *pr1.first, *pr2.first ) == true )     
   {  
      cout << "The element ( 1,10 ) precedes the element ( 2,5 )."  
           << endl;  
   }  
   else     
   {  
      cout << "The element ( 1,10 ) does not precede the element ( 2,5 )."  
           << endl;  
   }  
  
   if( vc1 ( *pr2.first, *pr1.first ) == true )  
   {  
      cout << "The element ( 2,5 ) precedes the element ( 1,10 )."  
           << endl;  
   }  
   else     
   {  
      cout << "The element ( 2,5 ) does not precede the element ( 1,10 )."  
           << endl;  
   }  
}  
```  
  
## Output  
  
```  
The element ( 1,10 ) precedes the element ( 2,5 ).  
The element ( 2,5 ) does not precede the element ( 1,10 ).  
```  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)