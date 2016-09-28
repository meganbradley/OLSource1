---
title: "basic_ios::narrow"
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
  - "basic_ios.narrow"
  - "narrow"
  - "std.basic_ios.narrow"
  - "Narrow"
  - "ios/std::basic_ios::narrow"
  - "std::basic_ios::narrow"
  - "basic_ios::narrow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "narrow method"
ms.assetid: 1978033a-a27c-43af-b9f0-21b57b1fd673
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ios::narrow
Finds the equivalent char to a given `char_type`.  
  
## Syntax  
  
```  
char narrow(  
    char_type _Char,  
    char _Default = '\0'  
) const;  
```  
  
#### Parameters  
 `_Char`  
 The `char` to convert.  
  
 `_Default`  
 The `char` that you want returned if no equivalent is found.  
  
## Return Value  
 The equivalent `char` to a given `char_type`.  
  
## Remarks  
 The member function returns [use_facet](../vs140/basic_filebuf--open.md)**< ctype**<**E**> >( [getloc](../vs140/ios_base--getloc.md)( ) ). `narrow`(`_Char`, `_Default`).  
  
## Example  
  
```  
// basic_ios_narrow.cpp  
// compile with: /EHsc  
#include <ios>  
#include <iostream>  
#include <wchar.h>  
  
int main( )   
{  
   using namespace std;  
   wchar_t *x = L"test";  
   char y[10];  
   cout << x[0] << endl;  
   wcout << x << endl;  
   y[0] = wcout.narrow( x[0] );  
   cout << y[0] << endl;  
}  
```  
  
## Output  
  
```  
116  
test  
t  
```  
  
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)