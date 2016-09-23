---
title: "compl"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
apiname: 
  - compl
apilocation: 
  - msvcr120.dll
  - msvcr80.dll
  - msvcr100.dll
  - msvcr90.dll
  - msvcrt.dll
  - msvcr110_clr0400.dll
  - msvcr110.dll
apitype: DLLExport
f1_keywords: 
  - std::compl
  - std.compl
  - compl
dev_langs: 
  - C++
helpviewer_keywords: 
  - compl function
ms.assetid: e03f6fb5-cb8b-4afa-99c0-905f4105fb34
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# compl
An alternative to the ~ operator.  
  
## Syntax  
  
```  
  
#define compl ~  
  
```  
  
## Remarks  
 The macro yields the operator ~.  
  
## Example  
  
```  
// iso646_compl.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <iso646.h>  
  
int main( )  
{  
   using namespace std;  
   int a = 1, result;  
  
   result = ~a;  
   cout << result << endl;  
  
   result= compl(a);  
   cout << result << endl;  
}  
```  
  
 **-2**  
**-2**   
## Requirements  
 **Header:** <iso646.h>