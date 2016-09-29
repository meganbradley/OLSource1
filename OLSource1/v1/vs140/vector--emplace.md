---
title: "vector::emplace"
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
  - "std.vector.emplace"
  - "vector.emplace"
  - "vector::emplace"
  - "std::vector::emplace"
  - "emplace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace method"
ms.assetid: 3bbd498e-aa3e-48a8-9926-1a0d4d6479e1
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::emplace
Inserts an element constructed in place into the vector at a specified position.  
  
## Syntax  
  
```  
iterator emplace(  
   const_iterator _Where,  
   Type&& _Val  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Where`|The position in the [vector](../vs140/vector-class.md) where the first element is inserted.|  
|`_Val`|The value of the element being inserted into the `vector`.|  
  
## Return Value  
 The function returns an iterator that points to the position where the new element was inserted into the `vector`.  
  
## Remarks  
 Any insertion operation can be expensive, see [vector Class](../vs140/vector-class.md) for a discussion of `vector` performance.  
  
## Example  
  
```  
// vector_emplace.cpp  
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
  
   cout << "v1 =" ;  
   for ( Iter = v1.begin( ) ; Iter != v1.end( ) ; Iter++ )  
      cout << " " << *Iter;  
   cout << endl;  
  
// initialize a vector of vectors by moving v1  
   vector < vector <int> > vv1;  
  
   vv1.emplace( vv1.begin(), move( v1 ) );  
   if ( vv1.size( ) != 0 && vv1[0].size( ) != 0 )  
      {  
      cout << "vv1[0] =";  
      for (Iter = vv1[0].begin( ); Iter != vv1[0].end( ); Iter++ )  
         cout << " " << *Iter;  
      cout << endl;  
      }  
}  
```  
  
 **v1 = 10 20 30**  
**vv1[0] = 10 20 30**   
## Requirements  
 **Header:** <vector\>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)