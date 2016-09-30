---
title: "basic_ios::widen"
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
  - "widen"
  - "std::basic_ios::widen"
  - "basic_ios::widen"
  - "ios/std::basic_ios::widen"
  - "basic_ios.widen"
  - "std.basic_ios.widen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "widen method"
ms.assetid: 77a14bdb-f04c-41ac-b9a7-5b2cdda46865
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ios::widen
Finds the equivalent `char_type` to a given `char`.  
  
## Syntax  
  
```  
char_type widen(  
    char _Char  
) const;  
```  
  
#### Parameters  
 `_Char`  
 The character to convert.  
  
## Return Value  
 Finds the equivalent `char_type` to a given `char`.  
  
## Remarks  
 The member function returns [use_facet](../vs140/basic_filebuf--open.md)< **ctype**\<**E**> >( [getloc](../vs140/ios_base--getloc.md)). `widen`(`_Char`).  
  
## Example  
  
```  
// basic_ios_widen.cpp  
// compile with: /EHsc  
#include <ios>  
#include <iostream>  
#include <wchar.h>  
  
int main( )   
{  
   using namespace std;  
   char *z = "Hello";  
   wchar_t y[2] = {0,0};  
   cout << z[0] << endl;  
   y[0] = wcout.widen( z[0] );  
   wcout << &y[0] << endl;  
}  
```  
  
## Output  
  
```  
H  
H  
```  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)