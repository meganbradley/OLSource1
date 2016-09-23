---
title: "or"
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
  - msvcr80.dll
  - msvcr90.dll
  - msvcr110.dll
  - msvcr110_clr0400.dll
  - msvcr100.dll
  - msvcr120.dll
apitype: DLLExport
f1_keywords: 
  - std::or
  - std.or
  - Or
dev_langs: 
  - C++
helpviewer_keywords: 
  - or function
ms.assetid: 6523b3ac-0a18-44ec-9e9a-b9bab8525ead
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# or
An alternative to the &#124;&#124; operator.  
  
## Syntax  
  
```  
  
#define or ||  
  
```  
  
## Remarks  
 The macro yields the operator &#124;&#124;.  
  
## Example  
  
```  
// iso646_or.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <iso646.h>  
  
int main( )  
{  
   using namespace std;  
   bool a = true, b = false, result;  
  
   boolalpha(cout);  
  
   result= a || b;  
   cout << result << endl;  
  
   result= a or b;  
   cout << result << endl;  
}  
```  
  
 **true**  
**true**   
## Requirements  
 **Header:** <iso646.h>