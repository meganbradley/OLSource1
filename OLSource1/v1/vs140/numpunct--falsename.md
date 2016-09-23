---
title: "numpunct::falsename"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - numpunct.falsename
  - std::numpunct::falsename
  - numpunct::falsename
  - std.numpunct.falsename
  - falsename
  - xlocnum/std::numpunct::falsename
dev_langs: 
  - C++
helpviewer_keywords: 
  - falsename method
ms.assetid: f8ec70a1-a259-4fb6-ace0-00a99b7b054c
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# numpunct::falsename
Returns a string to use as a text representation of the value **false**.  
  
## Syntax  
  
```  
string_type falsename( ) const;  
```  
  
## Return Value  
 A string containing a sequence of **CharType**s to use as a text representation of the value **false**.  
  
## Remarks  
 The member function returns the string "false" to represent the value **false** in all locales.  
  
 The member function returns [do_falsename](../vs140/numpunct--do_falsename.md).  
  
## Example  
  
```  
// numpunct_falsename.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
using namespace std;  
int main( )  
{  
   locale loc( "English" );  
  
   const numpunct <char> &npunct = use_facet <numpunct <char> >( loc );  
   cout << loc.name( ) << " truename "<< npunct.truename( ) << endl;  
   cout << loc.name( ) << " falsename "<< npunct.falsename( ) << endl;  
  
   locale loc2( "French" );  
   const numpunct <char> &npunct2 = use_facet <numpunct <char> >(loc2);  
   cout << loc2.name( ) << " truename "<< npunct2.truename( ) << endl;  
   cout << loc2.name( ) << " falsename "<< npunct2.falsename( ) << endl;  
}  
```  
  
 **English_United States.1252 truename true**  
**English_United States.1252 falsename false**  
**French_France.1252 truename true**  
**French_France.1252 falsename false**   
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [numpunct Class](../vs140/numpunct-class.md)