---
title: "vector::insert"
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
  - "Insert"
  - "std.vector.insert"
  - "vector::insert"
  - "vector.insert"
  - "std::vector::insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: de278aeb-61df-459e-bd14-35bfde4511a2
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::insert
Inserts an element or a number of elements or a range of elements into the vector at a specified position.  
  
## Syntax  
  
```  
iterator insert(  
   const_iterator _Where,  
   const Type& _Val  
);  
iterator insert(  
   const_iterator _Where,  
   Type&& _Val  
);  
void insert(  
   const_iterator _Where,  
   size_type _Count,  
   const Type& _Val  
);  
template<class InputIterator>  
   void insert(  
      const_iterator _Where,  
      InputIterator _First,  
      InputIterator _Last  
   );  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Where`|The position in the vector where the first element is inserted.|  
|`_Val`|The value of the element being inserted into the vector.|  
|`_Count`|The number of elements being inserted into the vector.|  
|`_First`|The position of the first element in the range of elements to be copied.|  
|`_Last`|The position of the first element beyond the range of elements to be copied.|  
  
## Return Value  
 The first two `insert` functions return an iterator that points to the position where the new element was inserted into the vector.  
  
## Remarks  
 Any insertion operation can be expensive, see [vector Class](../vs140/vector-class.md) for a discussion of `vector` performance.  
  
## Example  
  
```  
// vector_insert.cpp  
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
  
   v1.insert( v1.begin( ) + 1, 40 );  
   cout << "v1 =";  
   for ( Iter = v1.begin( ) ; Iter != v1.end( ) ; Iter++ )  
      cout << " " << *Iter;  
   cout << endl;  
   v1.insert( v1.begin( ) + 2, 4, 50 );  
  
   cout << "v1 =";  
   for ( Iter = v1.begin( ) ; Iter != v1.end( ) ; Iter++ )  
      cout << " " << *Iter;  
   cout << endl;  
  
   v1.insert( v1.begin( )+1, v1.begin( )+2, v1.begin( )+4 );  
   cout << "v1 =";  
   for (Iter = v1.begin( ); Iter != v1.end( ); Iter++ )  
      cout << " " << *Iter;  
   cout << endl;  
  
// initialize a vector of vectors by moving v1  
   vector < vector <int> > vv1;  
  
   vv1.insert( vv1.begin(), move( v1 ) );  
   if ( vv1.size( ) != 0 && vv1[0].size( ) != 0 )  
      {  
      vector < vector <int> >::iterator Iter;  
      cout << "vv1[0] =";  
      for (Iter = vv1[0].begin( ); Iter != vv1[0].end( ); Iter++ )  
         cout << " " << *Iter;  
      cout << endl;  
      }  
}  
```  
  
 **v1 = 10 20 30**  
**v1 = 10 40 20 30**  
**v1 = 10 40 50 50 50 50 20 30**  
**v1 = 10 50 50 40 50 50 50 50 20 30**  
**vv1[0] = 10 50 50 40 50 50 50 50 20 30**   
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)