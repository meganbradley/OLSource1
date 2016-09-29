---
title: "regex_error::regex_error"
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
  - "std::tr1::regex_error::regex_error"
  - "regex_error.regex_error"
  - "std.tr1.regex_error.regex_error"
  - "regex_error"
  - "regex_error::regex_error"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "regex_error constructor [TR1]"
ms.assetid: 3ee874d6-60cd-4201-96e1-6e366a423640
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_error::regex_error
Constructs the object.  
  
## Syntax  
  
```  
regex_error(regex_constants::error_code error);  
```  
  
#### Parameters  
 `error`  
 The error code.  
  
## Remarks  
 The constructor constructs an object that holds the value `error`.  
  
## Example  
  
```  
// std_tr1__regex__regex_error_construct.cpp   
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
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_error](../vs140/regex_error-class.md)