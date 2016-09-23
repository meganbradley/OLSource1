---
title: "range_error Class"
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
  - stdexcept/std::range_error
  - std.range_error
  - range_error
  - std::range_error
dev_langs: 
  - C++
helpviewer_keywords: 
  - range_error class
ms.assetid: 8afb3e88-fc49-4213-b096-ed63d7aea37c
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# range_error Class
The class serves as the base class for all exceptions thrown to report a range error.  
  
## Syntax  
  
```  
class range_error : public runtime_error {  
public:  
    explicit range_error(const string& message);  
    explicit range_error(const char *message);  
};  
```  
  
## Remarks  
 The value returned by [what](../vs140/exception-class.md) is a copy of **message**`.`[data](../vs140/basic_string-class.md#basic_string__data).  
  
## Example  
  
```  
// range_error.cpp  
// compile with: /EHsc /GR  
#include <iostream>  
using namespace std;  
int main()  
{  
   try   
   {  
      throw range_error( "The range is in error!" );  
   }  
   catch (exception &e)   
   {  
      cerr << "Caught: " << e.what( ) << endl;  
      cerr << "Type: " << typeid( e ).name( ) << endl;  
   };  
}  
\* Output:   
Caught: The range is in error!  
Type: class std::range_error  
*\  
```  
  
## Requirements  
 **Header:** <stdexcept\>  
  
 **Namespace:** std  
  
## See Also  
 [runtime_error Class](../vs140/runtime_error-class.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)