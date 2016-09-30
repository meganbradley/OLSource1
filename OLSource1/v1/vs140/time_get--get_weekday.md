---
title: "time_get::get_weekday"
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
  - "get_weekday"
  - "time_get::get_weekday"
  - "time_get.get_weekday"
  - "xloctime/std::time_get::get_weekday"
  - "std::time_get::get_weekday"
  - "std.time_get.get_weekday"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_weekday method"
ms.assetid: bdf5233c-43b5-434e-aeb0-0e3f9c3702d0
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_get::get_weekday
Parses a string as the name of the day of the week.  
  
## Syntax  
  
```  
  
      iter  
      _  
      type get  
      _  
      weekday(  
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
 A pointer to where the weekday information is to be stored.  
  
## Return Value  
 An input iterator addressing the first element beyond the input field.  
  
## Remarks  
 The member function returns [do_get_weekday](../vs140/time_get--do_get_weekday.md)(`_First`, `_Last`, `_Iosbase`, `_State`, `_Pt`).  
  
## Example  
  
```  
// time_get_get_weekday.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
#include <time.h>  
using namespace std;  
int main( )  
{  
   locale loc ( "French" );  
   basic_stringstream< char > pszGetF, pszPutF, pszGetI, pszPutI;  
   ios_base::iostate st = 0;  
   struct tm t;  
   memset( &t, 0, sizeof( struct tm ) );  
  
   pszGetF << "mercredi";  
   pszGetF.imbue(loc);  
   basic_istream<char>::_Iter i = use_facet   
      <time_get<char> >  
      (loc).get_weekday(basic_istream<char>::_Iter(pszGetF.rdbuf( )),     
               basic_istream<char>::_Iter(0), pszGetF, st, &t);  
  
   if (st & ios_base::failbit)  
      cout << "time_get::get_time("<< pszGetF.rdbuf( )->str( )<< ") FAILED on char: " << *i << endl;  
   else  
  
      cout << "time_get::get_time("<< pszGetF.rdbuf( )->str( )<< ") ="  
      << "\ntm_wday: " << t.tm_wday  
      << endl;  
}  
```  
  
 **time_get::get_time(mercredi) =**  
**tm_wday: 3**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [time_get Class](../vs140/time_get-class.md)