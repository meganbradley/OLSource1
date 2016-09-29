---
title: "locale::name"
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
  - "std::locale::name"
  - "xlocale/std::locale::name"
  - "std.locale.name"
  - "locale::name"
  - "name"
  - "locale.name"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "name method"
ms.assetid: b69bf87f-4157-4eed-b4a3-c325efed62e2
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# locale::name
Returns the stored locale name.  
  
## Syntax  
  
```  
string name( ) const;  
```  
  
## Return Value  
 A string giving the name of the locale.  
  
## Example  
  
```  
// locale_name.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <string>  
#include <locale>  
  
using namespace std;  
  
int main( )   
{  
   locale loc1( "german" );  
   locale loc2 = locale::global( loc1 );  
   cout << "The name of the previous locale is: "   
        << loc2.name( ) << "." << endl;  
   cout << "The name of the current locale is: "   
        << loc1.name( ) << "." << endl;  
}  
```  
  
 **The name of the previous locale is: C.**  
**The name of the current locale is: German_Germany.1252.**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [locale Class](../vs140/locale-class.md)