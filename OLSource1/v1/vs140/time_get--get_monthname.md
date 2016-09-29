---
title: "time_get::get_monthname"
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
  - "time_get::get_monthname"
  - "time_get.get_monthname"
  - "xloctime/std::time_get::get_monthname"
  - "std.time_get.get_monthname"
  - "std::time_get::get_monthname"
  - "get_monthname"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_monthname method"
ms.assetid: 5ba32f1b-1bdc-42b2-81ea-14ef67951af0
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_get::get_monthname
Parses a string as the name of the month.  
  
## Syntax  
  
```  
  
      iter  
      _  
      type get  
      _  
      monthname(  
   iter_type _First,   
   iter_type _Last,  
   ios_base& _Iosbase,   
   ios_base::iostate& _State,   
   tm* _Pt  
) const;  
```  
  
#### Parameters  
 `_First`  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 `_Last`  
 Input iterator addressing the end of the sequence to be converted.  
  
 `_Iosbase`  
 Unused.  
  
 `_State`  
 An output parameter that sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 `_Pt`  
 A pointer to where the month information is to be stored.  
  
## Return Value  
 An input iterator addressing the first element beyond the input field.  
  
## Remarks  
 The member function returns [do_get_monthname](../vs140/time_get--do_get_monthname.md)(`_First`, `_Last`, `_Iosbase`, `_State`, `_Pt`).  
  
## Example  
  
```  
// time_get_get_monthname.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
#include <time.h>  
using namespace std;  
int main( )  
{  
   locale loc ( "French" );  
   basic_stringstream<char> pszGetF, pszPutF, pszGetI, pszPutI;  
   ios_base::iostate st = 0;  
   struct tm t;  
   memset( &t, 0, sizeof( struct tm ) );  
  
   pszGetF << "juillet";  
   pszGetF.imbue( loc );  
   basic_istream<char>::_Iter i = use_facet <time_get <char> >  
   (loc).get_monthname(basic_istream<char>::_Iter(pszGetF.rdbuf( )),  
              basic_istream<char>::_Iter(0), pszGetF, st, &t);  
  
   if (st & ios_base::failbit)  
      cout << "time_get("<< pszGetF.rdbuf( )->str( )<< ") FAILED on char: " << *i << endl;  
   else  
  
      cout << "time_get("<< pszGetF.rdbuf( )->str( )<< ") ="  
      << "\ntm_sec: " << t.tm_sec  
      << "\ntm_min: " << t.tm_min  
      << "\ntm_hour: " << t.tm_hour  
      << "\ntm_mday: " << t.tm_mday  
      << "\ntm_mon: " << t.tm_mon  
      << "\ntm_year: " << t.tm_year  
      << "\ntm_wday: " << t.tm_wday  
      << "\ntm_yday: " << t.tm_yday  
      << "\ntm_isdst: " << t.tm_isdst  
      << endl;  
}  
```  
  
 **time_get(juillet) =**  
**tm_sec: 0**  
**tm_min: 0**  
**tm_hour: 0**  
**tm_mday: 0**  
**tm_mon: 6**  
**tm_year: 0**  
**tm_wday: 0**  
**tm_yday: 0**  
**tm_isdst: 0**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [time_get Class](../vs140/time_get-class.md)