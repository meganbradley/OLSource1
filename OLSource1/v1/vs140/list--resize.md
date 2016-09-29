---
title: "list::resize"
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
  - "std.list.resize"
  - "Resize"
  - "list.resize"
  - "std::list::resize"
  - "list/std::list::resize"
  - "resize"
  - "list::resize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "resize method"
ms.assetid: 4a69f5ae-8125-4753-aead-1a500b917d78
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# list::resize
Specifies a new size for a list.  
  
## Syntax  
  
```unstlib  
  
      void resize(  
   size_type _Newsize  
);  
void resize(  
   size_type _Newsize,  
   Type _Val  
);  
```  
  
#### Parameters  
 `_Newsize`  
 The new size of the list.  
  
 `_Val`  
 The value of the new elements to be added to the list if the new size is larger that the original size. If the value is omitted, the new elements are assigned the default value for the class.  
  
## Remarks  
 If the list's size is less than the requested size, `_Newsize`, elements are added to the list until it reaches the requested size.  
  
 If the list's size is larger than the requested size, the elements closest to the end of the list are deleted until the list reaches the size `_Newsize`.  
  
 If the present size of the list is the same as the requested size, no action is taken.  
  
 [size](../vs140/list--size.md) reflects the current size of the list.  
  
## Example  
  
```  
// list_resize.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main( )  
{   
   using namespace std;  
   list <int> c1;  
  
   c1.push_back( 10 );  
   c1.push_back( 20 );  
   c1.push_back( 30 );  
  
   c1.resize( 4,40 );  
   cout << "The size of c1 is " << c1.size( ) << endl;  
   cout << "The value of the last element is " << c1.back( ) << endl;  
  
   c1.resize( 5 );  
   cout << "The size of c1 is now " << c1.size( ) << endl;  
   cout << "The value of the last element is now " << c1.back( ) << endl;  
  
   c1.resize( 2 );  
   cout << "The reduced size of c1 is: " << c1.size( ) << endl;  
   cout << "The value of the last element is now " << c1.back( ) << endl;  
}  
```  
  
 **The size of c1 is 4**  
**The value of the last element is 40**  
**The size of c1 is now 5**  
**The value of the last element is now 0**  
**The reduced size of c1 is: 2**  
**The value of the last element is now 20**   
## Requirements  
 **Header:** <list\>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)