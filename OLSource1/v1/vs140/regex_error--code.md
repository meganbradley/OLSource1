---
title: "regex_error::code"
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
  - std.tr1.regex_error.code
  - std::tr1::regex_error::code
  - regex_error.code
  - regex_error::code
dev_langs: 
  - C++
helpviewer_keywords: 
  - code method [TR1]
ms.assetid: cb606cdd-7425-44db-b1ac-7f1401ca8399
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# regex_error::code
Returns the error code.  
  
## Syntax  
  
```  
regex_constants::error_code code() const;  
```  
  
## Remarks  
 The member function returns the value that was passed to the object's constructor.  
  
## Example  
  
```  
// std_tr1__regex__regex_error_code.cpp   
// compile with: /EHsc   
#include <regex>   
#include <iostream>   
  
int main()   
    {   
    std::regex_error paren(std::regex_constants::error_paren);   
  
    try   
        {   
        std::regex rx("(a");   
        }   
    catch (const std::regex_error& rerr)   
        {   
        std::cout << "regex error: "   
            << (rerr.code() == paren.code()   
                ? "unbalanced parentheses" : "?")   
            << std::endl;   
        }   
    catch (...)   
        {   
        std::cout << "unknown exception" << std::endl;   
        }   
  
    return (0);   
    }  
  
```  
  
 **regex error: unbalanced parentheses**   
## Requirements  
 **Header:** <regex\>  
  
 **Namespace:** std  
  
## See Also  
 [<regex\>](../vs140/-regex-.md)   
 [regex_error](../vs140/regex_error-class.md)