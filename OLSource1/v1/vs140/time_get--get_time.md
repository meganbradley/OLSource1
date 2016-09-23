---
title: "time_get::get_time"
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
  - std::time_get::get_time
  - time_get.get_time
  - time_get::get_time
  - std.time_get.get_time
  - xloctime/std::time_get::get_time
  - get_time
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_time method
ms.assetid: 6e933066-ec2b-4cea-aa27-670c0f6daa9e
caps.latest.revision: 16
translation.priority.mt: 
  - de-de
  - ja-jp
---
# time_get::get_time
Parses a string as the date produced by the *X* specifier for `strftime`.  
  
## Syntax  
  
```  
  
      iter  
      _  
      type get  
      _  
      time(  
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
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 `_Pt`  
 A pointer to where the date information is to be stored.  
  
## Return Value  
 An input iterator addressing the first element beyond the input field.  
  
## Remarks  
 The member function returns [do_get_time](../vs140/time_get--do_get_time.md)(`_First`, `_Last`, `_Iosbase`, `_State`, `_Pt`).  
  
## Example  
  
```  
// time_get_get_time.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
#include <time.h>  
using namespace std;  
int main( )  
{  
   locale loc;  
   basic_stringstream<char> pszGetF, pszPutF, pszGetI, pszPutI;  
   ios_base::iostate st = 0;  
   struct tm t;  
   memset( &t, 0, sizeof( struct tm ) );  
  
   pszGetF << "11:13:20";  
   pszGetF.imbue( loc );  
   basic_istream<char>::_Iter i = use_facet   
      <time_get <char> >  
      (loc).get_time(basic_istream<char>::_Iter(pszGetF.rdbuf( )),  
               basic_istream<char>::_Iter(0), pszGetF, st, &t);  
  
   if (st & ios_base::failbit)  
      cout << "time_get::get_time("<< pszGetF.rdbuf( )->str( )<< ") FAILED on char: " << *i << endl;  
   else  
  
      cout << "time_get::get_time("<< pszGetF.rdbuf( )->str( )<< ") ="  
      << "\ntm_sec: " << t.tm_sec  
      << "\ntm_min: " << t.tm_min  
      << "\ntm_hour: " << t.tm_hour  
      << endl;  
}  
```  
  
 **time_get::get_time(11:13:20) =**  
**tm_sec: 20**  
**tm_min: 13**  
**tm_hour: 11**   
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [time_get Class](../vs140/time_get-class.md)