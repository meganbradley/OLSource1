---
title: "vector::erase"
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
  - std::vector::erase
  - vector::erase
  - vector.erase
  - std.vector.erase
  - Erase
dev_langs: 
  - C++
helpviewer_keywords: 
  - erase method
ms.assetid: 0b7065d2-da9f-4649-8784-31d8a5edc6bd
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# vector::erase
Removes an element or a range of elements in a vector from specified positions.  
  
## Syntax  
  
```  
iterator erase(  
   const_iterator_Where  
);  
iterator erase(  
   const_iterator _First,  
   const_iterator_Last  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Where`|Position of the element to be removed from the vector.|  
|`_First`|Position of the first element removed from the vector.|  
|`_Last`|Position just beyond the last element removed from the vector.|  
  
## Return Value  
 An iterator that designates the first element remaining beyond any elements removed, or a pointer to the end of the vector if no such element exists.  
  
## Example  
  
```  
// vector_erase.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   vector <int> v1;  
   vector <int>::iterator Iter;  
  
   v1.push_back( 10 );  
   v1.push_back( 20 );  
   v1.push_back( 30 );  
   v1.push_back( 40 );  
   v1.push_back( 50 );  
  
   cout << "v1 =" ;  
   for ( Iter = v1.begin( ) ; Iter != v1.end( ) ; Iter++ )  
      cout << " " << *Iter;  
   cout << endl;  
  
   v1.erase( v1.begin( ) );  
   cout << "v1 =";  
   for ( Iter = v1.begin( ) ; Iter != v1.end( ) ; Iter++ )  
      cout << " " << *Iter;  
   cout << endl;  
  
   v1.erase( v1.begin( ) + 1, v1.begin( ) + 3 );  
   cout << "v1 =";  
   for ( Iter = v1.begin( ) ; Iter != v1.end( ) ; Iter++ )  
      cout << " " << *Iter;  
   cout << endl;  
}  
```  
  
 **v1 = 10 20 30 40 50**  
**v1 = 20 30 40 50**  
**v1 = 20 50**   
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [vector::empty, vector::erase, and vector::push_back](../vs140/vector--empty--vector--erase--and-vector--push_back.md)   
 [Standard Template Library](../vs140/standard-template-library.md)