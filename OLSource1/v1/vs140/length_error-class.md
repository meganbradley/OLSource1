---
title: "length_error Class"
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
  - "stdexcept/std::length_error"
  - "length_error"
  - "std::length_error"
  - "std.length_error"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "length_error class"
ms.assetid: d53c46c5-4626-400d-bd76-bf3e1e0f64ae
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# length_error Class
The class serves as the base class for all exceptions thrown to report an attempt to generate an object too long to be specified.  
  
## Syntax  
  
```  
class length_error : public logic_error {  
public:  
    explicit length_error(const string& message);  
    explicit length_error(const char *message);  
};  
```  
  
## Remarks  
 The value returned by [what](../vs140/exception-class.md) is a copy of **message**`.`[data](../vs140/basic_string-class.md#basic_string__data).  
  
## Example  
  
```  
// length_error.cpp  
// compile with: /EHsc /GR /MDd  
#include <vector>  
#include <iostream>  
  
using namespace std;  
  
template<class _Ty>  
class stingyallocator : public allocator<_Ty>  
{  
public:  
   template <class U>  
      struct rebind { typedef stingyallocator<U> other; };  
   _SIZT max_size( ) const  
   {  
         return 10;  
   };  
  
};  
  
int main( )  
{  
   try  
   {  
      vector<int, stingyallocator< int > > myv;  
      for ( int i = 0; i < 11; i++ ) myv.push_back( i );  
   }  
   catch ( exception &e )  
   {  
      cerr << "Caught " << e.what( ) << endl;  
      cerr << "Type " << typeid( e ).name( ) << endl;  
   };  
}  
\* Output:   
Caught vector<T> too long  
Type class std::length_error  
*\  
```  
  
## Requirements  
 **Header:** <stdexcept\>  
  
 **Namespace:** std  
  
## See Also  
 [logic_error Class](../vs140/logic_error-class.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)