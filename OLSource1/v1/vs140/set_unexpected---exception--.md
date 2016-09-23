---
title: "set_unexpected (&lt;exception&gt;)"
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
  - std::set_unexpected
  - std.set_unexpected
  - set_unexpected
dev_langs: 
  - C++
helpviewer_keywords: 
  - set_unexpected function
ms.assetid: 2132735f-3249-407e-b860-3e99be782614
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# set_unexpected (&lt;exception&gt;)
Establishes a new `unexpected_handler` to be when an unexpected exception is encountered.  
  
## Syntax  
  
```  
  
   unexpected_handler  
set_unexpected(  
   unexpected_handler fnew  
) throw( );  
```  
  
#### Parameters  
 `fnew`  
 The function to be called when an unexpected exception is encountered.  
  
## Return Value  
 The address of the previous `unexpected_handler`.  
  
## Remarks  
 `fnew` must not be a null pointer.  
  
 The C++ Standard requires that `unexpected` is called when a function throws an exception that is not on its throw list. The current implementation does not support this. The following example calls `unexpected` directly, which then calls the `unexpected_handler`.  
  
## Example  
  
```cpp  
// exception_set_unexpected.cpp  
// compile with: /EHsc  
#include <exception>  
#include <iostream>  
  
using namespace std;  
  
void uefunction()  
{  
    cout << "My unhandled exception function called." << endl;  
    terminate(); // this is what unexpected() calls by default  
}  
  
int main()  
{  
    unexpected_handler oldHandler = set_unexpected(uefunction);  
  
    unexpected(); // library function to force calling the   
                  // current unexpected handler  
}  
  
```  
  
## Output  
  
```  
My unhandled exception function called.  
```  
  
## Requirements  
 **Header:** <exception\>  
  
 **Namespace:** std  
  
## See Also  
 [<exception\>](../vs140/-exception-.md)   
 [get_unexpected](../vs140/get_unexpected.md)