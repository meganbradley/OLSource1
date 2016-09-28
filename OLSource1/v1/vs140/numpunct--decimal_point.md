---
title: "numpunct::decimal_point"
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
  - "std::numpunct::decimal_point"
  - "numpunct.decimal_point"
  - "std.numpunct.decimal_point"
  - "numpunct::decimal_point"
  - "decimal_point"
  - "xlocnum/std::numpunct::decimal_point"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "decimal_point method"
ms.assetid: c57a9981-c68a-46a3-aa58-631e945251c6
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numpunct::decimal_point
Returns a locale-specific element to use as a decimal point.  
  
## Syntax  
  
```  
CharType decimal_point( ) const;  
```  
  
## Return Value  
 A locale-specific element to use as a decimal point.  
  
## Remarks  
 The member function returns [do_decimal_point](../vs140/numpunct--do_decimal_point.md).  
  
## Example  
  
```  
// numpunct_decimal_point.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
using namespace std;  
int main( )  
{  
   locale loc( "german_germany" );  
  
   const numpunct <char> &npunct =   
   use_facet <numpunct <char> >( loc);  
   cout << loc.name( ) << " decimal point "<<   
   npunct.decimal_point( ) << endl;  
   cout << loc.name( ) << " thousands separator "   
   << npunct.thousands_sep( ) << endl;  
};  
```  
  
 **German_Germany.1252 decimal point ,**  
**German_Germany.1252 thousands separator .**   
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [numpunct Class](../vs140/numpunct-class.md)