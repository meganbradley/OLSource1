---
title: "set_terminate (&lt;exception&gt;)"
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
  - std::set_terminate
  - set_terminate
  - std.set_terminate
dev_langs: 
  - C++
helpviewer_keywords: 
  - set_terminate function
ms.assetid: b949bd45-75ae-4fe8-af2c-f6ce67167d67
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# set_terminate (&lt;exception&gt;)
Establishes a new `terminate_handler` to be called at the termination of the program.  
  
## Syntax  
  
```  
  
   terminate_handler  
set_terminate(  
   terminate_handler fnew  
) throw( );  
```  
  
#### Parameters  
 `fnew`  
 The function to be called at termination.  
  
## Return Value  
 The address of the previous function that used to be called at termination.  
  
## Remarks  
 The function establishes a new [terminate_handler](../vs140/terminate_handler.md) as the function *`fnew`. Thus, `fnew` must not be a null pointer. The function returns the address of the previous terminate handler.  
  
## Example  
  
```cpp  
// exception_set_terminate.cpp  
// compile with: /EHsc  
#include <exception>  
#include <iostream>  
  
using namespace std;  
  
void termfunction()  
{  
    cout << "My terminate function called." << endl;  
    abort();  
}  
  
int main()  
{  
    terminate_handler oldHandler = set_terminate(termfunction);  
  
    // Throwing an unhandled exception would also terminate the program  
    // or we could explicitly call terminate();  
  
    //throw bad_alloc();  
    terminate();  
}  
  
```  
  
## Output  
  
```  
My terminate function called.  
```  
  
## Requirements  
 **Header:** <exception\>  
  
 **Namespace:** std  
  
## See Also  
 [<exception\>](../vs140/-exception-.md)   
 [get_terminate](../vs140/get_terminate.md)