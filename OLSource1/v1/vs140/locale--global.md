---
title: "locale::global"
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
  - "global"
  - "locale::global"
  - "locale.global"
  - "xlocale/std::locale::global"
  - "std.locale.global"
  - "std::locale::global"
  - "Global"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "global method"
ms.assetid: 16e47251-a892-42d0-a6ea-ca17692e34d8
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# locale::global
Resets the default locale for the program. This affects the global locale for both C and C++.  
  
## Syntax  
  
```  
static locale global(  
    const locale& _Loc  
);  
```  
  
#### Parameters  
 `_Loc`  
 The locale to be used as the default locale by the program.  
  
## Return Value  
 The previous locale before the default locale was reset.  
  
## Remarks  
 At program startup, the global locale is the same as the classic locale. The `global()` function calls `setlocale( LC_ALL, loc.name. c_str())` to establish a matching locale in the Standard C library.  
  
## Example  
  
```cpp  
// locale_global.cpp  
// compile by using: /EHsc  
#include <locale>  
#include <iostream>  
#include <tchar.h>  
using namespace std;  
  
int main( )  
{  
   locale loc ( "German_germany" );  
   locale loc1;  
   cout << "The initial locale is: " << loc1.name( ) << endl;  
   locale loc2 = locale::global ( loc );  
   locale loc3;  
   cout << "The current locale is: " << loc3.name( ) << endl;  
   cout << "The previous locale was: " << loc2.name( ) << endl;  
}  
```  
  
 **The initial locale is: C**  
**The current locale is: German_Germany.1252**  
**The previous locale was: C**   
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [locale Class](../vs140/locale-class.md)