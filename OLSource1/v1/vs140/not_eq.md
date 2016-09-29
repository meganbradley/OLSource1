---
title: "not_eq"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "not_eq"
  - "std::not_eq"
  - "std.not_eq"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "not_eq function"
ms.assetid: d87ad299-8b50-4393-a57f-06f70e1f23fb
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# not_eq
An alternative to the != operator.  
  
## Syntax  
  
```  
  
#define not_eq !=  
  
```  
  
## Remarks  
 The macro yields the operator !=.  
  
## Example  
  
```  
// iso646_not_eq.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <iso646.h>  
  
int main( )  
{  
   using namespace std;  
   int a = 0, b = 1;  
  
   if (a != b)  
      cout << "a is not equal to b" << endl;  
  
   if (a not_eq b)  
      cout << "a is not equal to b" << endl;  
}  
```  
  
 **a is not equal to b**  
**a is not equal to b**   
## Requirements  
 **Header:** <iso646.h>