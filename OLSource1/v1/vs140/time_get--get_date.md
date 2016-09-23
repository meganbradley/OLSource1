---
title: "time_get::get_date"
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
  - xloctime/std::time_get::get_date
  - std::time_get::get_date
  - time_get::get_date
  - get_date
  - time_get.get_date
  - std.time_get.get_date
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_date method
ms.assetid: b659c5a4-4911-4494-9fcf-1f8ebe1b9000
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# time_get::get_date
Parses a string as the date produced by the *x* specifier for `strftime`.  
  
## Syntax  
  
```  
  
      iter  
      _  
      type get  
      _  
      date(  
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
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required.  
  
 `_State`  
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 `_Pt`  
 A pointer to where the date information is to be stored.  
  
## Return Value  
 An input iterator addressing the first element beyond the input field.  
  
## Remarks  
 The member function returns [do_get_date](../vs140/time_get--do_get_date.md)(`_First`, `_Last`, `_Iosbase`, `_State`, `_Pt`).  
  
 Note that months are counted from 0 to 11.  
  
## Example  
  
```  
// time_get_get_date.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
#include <time.h>  
using namespace std;  
int main( )  
{  
   locale loc;  
   basic_stringstream< char > pszGetF, pszPutF, pszGetI, pszPutI;  
   ios_base::iostate st = 0;  
   struct tm t;  
   memset(&t, 0, sizeof(struct tm));  
  
   pszGetF << "July 4, 2000";  
   pszGetF.imbue( loc );  
   basic_istream<char>::_Iter i = use_facet <time_get<char> >  
   (loc).get_date(basic_istream<char>::_Iter(pszGetF.rdbuf( ) ),  
            basic_istream<char>::_Iter(0), pszGetF, st, &t);  
  
   if ( st & ios_base::failbit )  
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
  
 **time_get(July 4, 2000) =**  
**tm_sec: 0**  
**tm_min: 0**  
**tm_hour: 0**  
**tm_mday: 4**  
**tm_mon: 6**  
**tm_year: 100**  
**tm_wday: 0**  
**tm_yday: 0**  
**tm_isdst: 0**   
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [time_get Class](../vs140/time_get-class.md)