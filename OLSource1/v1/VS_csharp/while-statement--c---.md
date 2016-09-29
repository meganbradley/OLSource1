---
title: "while Statement (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "while_cpp"
  - "while"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "while keyword [C++]"
  - "while keyword [C++], syntax"
ms.assetid: 358dbe76-5e5e-4af5-b575-c2293c636899
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# while Statement (C++)
Executes *statement* repeatedly until *expression* evaluates to zero.  
  
## Syntax  
  
```  
  
      while ( expression )  
   statement  
```  
  
## Remarks  
 The test of *expression* takes place before each execution of the loop; therefore, a `while` loop executes zero or more times. *expression* must be of an integral type, a pointer type, or a class type with an unambiguous conversion to an integral or pointer type.  
  
 A `while` loop can also terminate when a [break](../VS_csharp/break-statement--c---.md), [goto](../VS_csharp/goto-statement--c---.md), or [return](../VS_csharp/return-statement--c---.md) within the statement body is executed. Use [continue](../VS_csharp/continue-statement--c---.md) to terminate the current iteration without exiting the `while` loop. **continue** passes control to the next iteration of the `while` loop.  
  
 The following code uses a `while` loop to trim trailing underscores from a string:  
  
```  
// while_statement.cpp  
  
#include <string.h>  
#include <stdio.h>  
char *trim( char *szSource )  
{  
    char *pszEOS = 0;  
  
    //  Set pointer to character before terminating NULL  
    pszEOS = szSource + strlen( szSource ) - 1;  
  
    //  iterate backwards until non '_' is found   
    while( (pszEOS >= szSource) && (*pszEOS == '_') )  
        *pszEOS-- = '\0';  
  
    return szSource;  
}  
int main()  
{  
    char szbuf[] = "12345_____";  
  
    printf_s("\nBefore trim: %s", szbuf);  
    printf_s("\nAfter trim: %s\n", trim(szbuf));  
}  
```  
  
 The termination condition is evaluated at the top of the loop. If there are no trailing underscores, the loop never executes.  
  
## See Also  
 [Iteration Statements](../VS_csharp/iteration-statements--c---.md)   
 [Keywords](../VS_csharp/keywords--c---.md)   
 [do-while Statement (C++)](../VS_csharp/do-while-statement--c---.md)   
 [for Statement (C++)](../VS_csharp/for-statement--c---.md)   
 [Range-based for Statement (C++)](../VS_csharp/range-based-for-statement--c---.md)