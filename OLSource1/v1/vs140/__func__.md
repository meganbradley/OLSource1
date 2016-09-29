---
title: "__func__"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "__func__"
  - "__func___cpp"
dev_langs: 
  - "C++"
ms.assetid: a5299b8d-f0ee-4af2-91dd-8fb165e68798
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __func__
**(C++11)** The predefined identifier __func\_\_ is implicitly defined as a string that contains the unqualified and unadorned name of the enclosing function. \__func\_\_ is mandated by the C++ standard and is not a Microsoft extension.  
  
## Syntax  
  
```vb  
__func__  
```  
  
## Return Value  
 Returns a null-terminated const char array of characters that constains the function name.  
  
## Example  
  
```  
  
#include <string>  
#include <iostream>  
  
namespace Test  
{  
    struct Foo  
    {  
        static void DoSomething(int i, std::string s)  
        {  
           std::cout << __func__ << std::endl; // Output: DoSomething  
        }  
    };  
}  
int main()  
{  
    Test::Foo::DoSomething(42, "Hello");  
  
    return 0;  
}  
  
```  
  
## Requirements  
 C++11