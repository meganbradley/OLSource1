---
title: "raw_storage_iterator::operator*"
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
  - "raw_storage_iterator.operator*"
  - "std.raw_storage_iterator.operator*"
  - "memory/std::raw_storage_iterator::operator*"
  - "operator*"
  - "std::raw_storage_iterator::operator*"
  - "raw_storage_iterator::operator*"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "* operator"
  - "operator*"
  - "* operator, with specific iterator expressions"
  - "multiplication operator, iterator expressions"
ms.assetid: 0239d7f5-e74f-404d-9ae9-fae860dfc774
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# raw_storage_iterator::operator*
A dereferencing operator used to implement the raw storage iterator expression \**ii* = *x*.  
  
## Syntax  
  
```  
raw_storage_iterator<ForwardIterator, Type>& operator*( );  
```  
  
## Return Value  
 A reference to the raw storage iterator  
  
## Remarks  
 The requirements for a **ForwardIterator** are that the raw storage iterator must satisfy require only the expression \**ii* = *t* be valid and that it says nothing about the **operator** or the `operator=` on their own. The member operators in this implementation returns **\*this**, so that [operator=](../vs140/raw_storage_iterator--operator=.md)(**const Type**&) can perform the actual store in an expression, such as **_Ptr* = `_Val`.  
  
## Example  
  
```  
// raw_storage_iterator_op_deref.cpp  
// compile with: /EHsc  
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
  
   Int &operator=(int i)   
   {  
      if (!bIsConstructed)  
         cout << "Not constructed.\n";  
      cout << "Copying " << i << endl;    
      x = i;   
      return *this;  
   };  
  
   int x;  
  
private:  
   bool bIsConstructed;  
};  
  
int main( void)   
{  
   Int *pInt = ( Int* ) malloc( sizeof( Int ) );  
   memset( pInt, 0, sizeof( Int ) ); // Set bIsConstructed to false;  
   *pInt = 5;  
   raw_storage_iterator< Int*, Int > it( pInt );  
   *it = 5;  
}  
```  
  
 **Not constructed.**  
**Copying 5**  
**Constructing 5**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [raw_storage_iterator Class](../vs140/raw_storage_iterator-class.md)