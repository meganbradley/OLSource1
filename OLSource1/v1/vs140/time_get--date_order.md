---
title: "time_get::date_order"
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
  - "date_order"
  - "xloctime/std::time_get::date_order"
  - "time_get::date_order"
  - "time_get.date_order"
  - "std.time_get.date_order"
  - "std::time_get::date_order"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "date_order method"
ms.assetid: 2dfa9643-c485-4e59-95cc-6ced9a8ddbec
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_get::date_order
Returns the date order used by a facet.  
  
## Syntax  
  
```  
  
dateorder date  
_  
order( ) const;  
  
```  
  
## Return Value  
 The date order used by a facet.  
  
## Remarks  
 The member function returns [do_date_order](../vs140/time_get--do_date_order.md).  
  
## Example  
  
```  
// time_get_date_order.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
#include <time.h>  
using namespace std;  
void po( char *p )  
{  
   locale loc( p );  
  
   time_get <char>::dateorder order = use_facet <time_get <char> >( loc ).date_order ( );  
   cout << loc.name( );  
   switch (order){  
      case time_base::dmy: cout << "(day, month, year)" << endl;  
      break;  
      case time_base::mdy: cout << "(month, day, year)" << endl;  
      break;  
      case time_base::ydm: cout << "(year, day, month)" << endl;  
      break;  
      case time_base::ymd: cout << "(year, month, day)"<< endl;  
      break;  
      case time_base::no_order: cout << "(no_order)"<< endl;  
      break;  
   }  
}  
  
int main( )  
{  
   po( "C" );  
   po( "german" );  
   po( "English_Britain" );  
}  
```  
  
 **C(month, day, year)**  
**German_Germany.1252(day, month, year)**  
**English_United Kingdom.1252(day, month, year)**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [time_get Class](../vs140/time_get-class.md)