---
title: "overflow_error Class"
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
  - "std::overflow_error"
  - "std.overflow_error"
  - "overflow_error"
  - "stdexcept/std::overflow_error"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "overflow_error class"
ms.assetid: bae7128d-e36b-4a45-84f1-2f89da441d20
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# overflow_error Class
The class serves as the base class for all exceptions thrown to report an arithmetic overflow.  
  
## Syntax  
  
```  
class overflow_error : public runtime_error {  
public:  
    explicit overflow_error(const string& message);  
    explicit overflow_error(const char *message);  
};  
```  
  
## Remarks  
 The value returned by [what](../vs140/exception-class.md) is a copy of **message**`.`[data](../vs140/basic_string-class.md#basic_string__data).  
  
## Example  
  
```  
// overflow_error.cpp  
// compile with: /EHsc /GR  
#include <bitset>  
#include <iostream>  
  
using namespace std;  
  
int main( )  
{  
   try   
   {  
      bitset< 33 > bitset;  
      bitset[32] = 1;  
      bitset[0] = 1;  
      unsigned long x = bitset.to_ulong( );  
   }  
   catch ( exception &e )   
   {  
      cerr << "Caught " << e.what( ) << endl;  
      cerr << "Type " << typeid( e ).name( ) << endl;  
   };  
}  
\* Output:   
Caught bitset<N> overflow  
Type class std::overflow_error  
*\  
```  
  
## Requirements  
 **Header:** <stdexcept\>  
  
 **Namespace:** std  
  
## See Also  
 [runtime_error Class](../vs140/runtime_error-class.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)