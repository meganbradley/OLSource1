---
title: "raw_storage_iterator::raw_storage_iterator"
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
  - "std.raw_storage_iterator.raw_storage_iterator"
  - "raw_storage_iterator.raw_storage_iterator"
  - "raw_storage_iterator::raw_storage_iterator"
  - "std::raw_storage_iterator::raw_storage_iterator"
  - "raw_storage_iterator"
  - "memory/std::raw_storage_iterator::raw_storage_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "raw_storage_iterator method"
  - "raw_storage_iterator class, constructor"
ms.assetid: 777c7602-8fe2-4b1e-b35d-9ca3da10da27
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# raw_storage_iterator::raw_storage_iterator
Constructs a raw storage iterator with a specified underlying output iterator.  
  
## Syntax  
  
```  
explicit raw_storage_iterator(  
   ForwardIterator _First  
);  
```  
  
#### Parameters  
 `_First`  
 The forward iterator that is to underlie the `raw_storage_iterator` object being constructed.  
  
## Example  
  
```  
// raw_storage_iterator_ctor.cpp  
// compile with: /EHsc /W3  
#include <iostream>  
#include <iterator>  
#include <memory>  
#include <list>  
using namespace std;  
  
class Int  
{  
public:  
   Int(int i)  
   {  
      cout << "Constructing " << i << endl;  
      x = i;  
      bIsConstructed = true;  
   };  
   Int &operator=( int i )  
   {  
      if (!bIsConstructed)  
         cout << "Error! I'm not constructed!\n";  
      cout << "Copying " << i << endl;  x = i; return *this;  
   };  
   int x;  
   bool bIsConstructed;  
};  
  
int main( void )  
{  
   std::list<int> l;  
   l.push_back( 1 );  
   l.push_back( 2 );  
   l.push_back( 3 );  
   l.push_back( 4 );  
  
   Int *pInt = (Int*)malloc(sizeof(Int)*l.size( ));  
   memset (pInt, 0, sizeof(Int)*l.size( ));  
   // Hack: make sure bIsConstructed is false  
  
   std::copy( l.begin( ), l.end( ), pInt );  // C4996  
   for (unsigned int i = 0; i < l.size( ); i++)  
      cout << "array " << i << " = " << pInt[i].x << endl;;  
  
   memset (pInt, 0, sizeof(Int)*l.size( ));  
   // hack: make sure bIsConstructed is false  
  
   std::copy( l.begin( ), l.end( ),  
      std::raw_storage_iterator<Int*,Int>(pInt));  // C4996  
   for (unsigned int i = 0; i < l.size( ); i++ )  
      cout << "array " << i << " = " << pInt[i].x << endl;  
  
   free(pInt);  
}  
```  
  
 **Error! I'm not constructed!**  
**Copying 1**  
**Error! I'm not constructed!**  
**Copying 2**  
**Error! I'm not constructed!**  
**Copying 3**  
**Error! I'm not constructed!**  
**Copying 4**  
**array 0 = 1**  
**array 1 = 2**  
**array 2 = 3**  
**array 3 = 4**  
**Constructing 1**  
**Constructing 2**  
**Constructing 3**  
**Constructing 4**  
**array 0 = 1**  
**array 1 = 2**  
**array 2 = 3**  
**array 3 = 4**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [raw_storage_iterator Class](../vs140/raw_storage_iterator-class.md)