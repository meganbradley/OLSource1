---
title: "Compiler Warning (level 1) C4351"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4351"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4351"
ms.assetid: c2e0e34e-fc20-4812-9613-26c387356c92
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4351
new behavior: elements of array 'array' will be default initialized  
  
 When an array is in a constructor's member initialization list, the elements of the array will be default initialized. In previous versions of [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)], when an array was in a constructor's member initialization list, the elements of the array may not have been default initialized in some cases.  
  
 If the array's element type does not have a constructor, the elements of the array will be initialized with the corresponding zero representation for that type.  
  
 C4351 means that you should inspect your code. If you want the compiler's previous behavior, remove the array from the constructor's member initialization list.  
  
 If you want the new behavior, which is likely, because the array was explicitly added to the constructor's member initialization list, use the [warning](../vs140/warning.md) pragma to disable the warning. The new behavior should be fine for most users.  
  
 One situation where the new behavior can result in unexpected behavior is when placement `new` is used to construct the object that has the array as a member, and the program depends on the contents that the memory (for the elements of the default initialized array) had before the call to placement `new`. In this case, the older compiler would have left the contents of memory unchanged, but the new behavior will cause default initialization of the array elements, overwriting the original contents in memory.  
  
## Example  
 The following sample generates C4351:  
  
```  
// C4351.cpp  
// compile with: /W1 /LD  
#include <new>  
#include <stdio.h>  
  
extern "C" int printf_s(const char *, ...);  
  
struct POD   
{  
    char m_c;  
};  
  
struct S   
{  
    int m_i;  
    POD m_default_initialized_arr[10];  
    POD m_not_initialized_arr[10];  
  
    S() :  
       m_i(), m_default_initialized_arr()   
    {  
    }   // C4351  
};  
  
int main()   
{  
    S s;  
    printf_s("First byte of the default initialized array "  
             "= '%c' (%d)\n",   
             s.m_default_initialized_arr[0].m_c,   
             s.m_default_initialized_arr[0].m_c);  
    printf_s("First byte of the array not initialized = '%c' (%d)\n\n",   
             s.m_not_initialized_arr[0].m_c,  
             s.m_not_initialized_arr[0].m_c);  
  
    s.m_default_initialized_arr[0].m_c = 'a';  
    s.m_not_initialized_arr[0].m_c = 'a';     
  
    s.~S();  
  
    printf_s("First byte of the default initialized array "  
             "= '%c' (%d)\n",   
             s.m_default_initialized_arr[0].m_c, (int)   
             s.m_default_initialized_arr[0].m_c);  
    printf_s("First byte of the array not initialized = '%c' (%d)\n\n",   
             s.m_not_initialized_arr[0].m_c, (int)   
             s.m_not_initialized_arr[0].m_c);  
  
    new (&s) S();  
  
    // If your program depends on s.m_default_initialized_arr[0].m_c   
    // still having the value 'a', then the new compiler behavior will   
    // cause your program to behave differently  
  
    printf_s("First byte of the default initialized array "  
             "= '%c' (%d)\n",   
             s.m_default_initialized_arr[0].m_c, (int)   
             s.m_default_initialized_arr[0].m_c);  
    printf_s("First byte of the array not initialized = '%c' (%d)\n\n",   
             s.m_not_initialized_arr[0].m_c, (int)   
             s.m_not_initialized_arr[0].m_c);  
}  
```