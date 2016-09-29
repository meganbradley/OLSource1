---
title: "moneypunct::curr_symbol"
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
  - "moneypunct::curr_symbol"
  - "std::moneypunct::curr_symbol"
  - "curr_symbol"
  - "moneypunct.curr_symbol"
  - "std.moneypunct.curr_symbol"
  - "locale/std::moneypunct::curr_symbol"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "curr_symbol method"
ms.assetid: 99430cc1-569d-4417-bea7-4d6125b7cb59
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# moneypunct::curr_symbol
Returns a locale-specific sequence of elements to use as a currency symbol.  
  
## Syntax  
  
```  
string_type curr_symbol( ) const;  
```  
  
## Return Value  
 A string containing the currency symbol.  
  
## Remarks  
 The member function returns [do_curr_symbol](../vs140/moneypunct--do_curr_symbol.md).  
  
## Example  
  
```  
// moneypunct_curr_symbol.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
using namespace std;  
int main( )  
{  
   locale loc( "german_germany" );  
  
   const moneypunct < char, true > &mpunct = use_facet < moneypunct < char, true > >(loc);  
   cout << loc.name( ) << " international currency symbol "<<  mpunct.curr_symbol( ) << endl;  
  
   const moneypunct < char, false> &mpunct2 = use_facet < moneypunct < char, false> >(loc);  
   cout << loc.name( ) << " domestic currency symbol "<<  mpunct2.curr_symbol( ) << endl;  
};  
```  
  
## Sample Output  
 If you run Windows 2000 or earlier, you will get this output:  
  
```  
German_Germany.1252 international currency symbol DEM  
German_Germany.1252 domestic currency symbol DM  
```  
  
 If you run Windows XP, you will get this output:  
  
```  
German_Germany.1252 international currency symbol EUR  
German_Germany.1252 domestic currency symbol   
```  
  
 This assumes that you have not changed the default currency settings.  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [moneypunct Class](../vs140/moneypunct-class.md)