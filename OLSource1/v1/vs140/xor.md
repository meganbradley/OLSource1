---
title: "xor"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
apilocation: 
  - msvcr100.dll
  - msvcr120.dll
  - msvcr110_clr0400.dll
  - msvcr90.dll
  - msvcr110.dll
  - msvcr80.dll
apitype: DLLExport
f1_keywords: 
  - Xor
  - std::xor
  - std.xor
dev_langs: 
  - C++
helpviewer_keywords: 
  - xor function
ms.assetid: 0fe9554b-d87b-4487-92ed-366c6dc21df2
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# xor
An alternative to the ^ operator.  
  
## Syntax  
  
```  
  
#define xor ^  
  
```  
  
## Remarks  
 The macro yields the operator ^.  
  
## Example  
  
```  
// iso646_xor.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <iso646.h>  
  
int main( )  
{  
   using namespace std;  
   int a = 3, b = 2, result;  
  
   result= a ^ b;  
   cout << result << endl;  
  
   result= a xor_eq b;  
   cout << result << endl;  
}  
```  
  
 **1**  
**1**   
## Requirements  
 **Header:** <iso646.h>