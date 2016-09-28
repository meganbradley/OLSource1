---
title: "true (C++)"
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
  - "true_cpp"
  - "true"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "true keyword [C++]"
ms.assetid: 96be2a70-51c3-4250-9752-874d25a5a11e
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# true (C++)
## Syntax  
  
```  
  
      bool-identifier = true ;  
bool-expression logical-operator true ;  
```  
  
## Remarks  
 This keyword is one of the two values for a variable of type [bool](../vs140/bool--c---.md) or a conditional expression (a conditional expression is now a true boolean expression). If `i` is of type `bool`, then the statement `i = true;` assigns **true** to `i`.  
  
## Example  
  
```  
// bool_true.cpp  
#include <stdio.h>  
int main()  
{  
    bool bb = true;  
    printf_s("%d\n", bb);  
    bb = false;  
    printf_s("%d\n", bb);  
}  
```  
  
 **1**  
**0**   
## See Also  
 [Keywords](../vs140/keywords--c---.md)