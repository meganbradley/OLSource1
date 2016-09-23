---
title: "time_get::get_year"
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
  - std.time_get.get_year
  - xloctime/std::time_get::get_year
  - time_get.get_year
  - get_year
  - std::time_get::get_year
  - time_get::get_year
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_year method
ms.assetid: fc403fd2-cf89-4368-941a-394b971b0b57
caps.latest.revision: 16
translation.priority.mt: 
  - de-de
  - ja-jp
---
# time_get::get_year
Parses a string as the name of the year.  
  
## Syntax  
  
```  
  
      iter  
      _  
      type get  
      _  
      year(  
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
 A pointer to where the year information is to be stored.  
  
## Return Value  
 An input iterator addressing the first element beyond the input field.  
  
## Remarks  
 The member function returns [do_get_year](../vs140/time_get--do_get_year.md)(`_First`, `_Last`, `_Iosbase`, `_State`, `_Pt`).  
  
## Example  
  
```  
// time_get_get_year.cpp  
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
  
   pszGetF << "1928";  
  
   pszGetF.imbue( loc );  
   basic_istream<char>::_Iter i = use_facet   
      <time_get<char> >  
      (loc).get_year(basic_istream<char>::_Iter(pszGetF.rdbuf( )),     
               basic_istream<char>::_Iter(0), pszGetF, st, &t);  
  
   if (st & ios_base::failbit)  
      cout << "time_get::get_year("<< pszGetF.rdbuf( )->str( )<< ") FAILED on char: " << *i << endl;  
   else  
  
      cout << "time_get::get_year("<< pszGetF.rdbuf( )->str( )<< ") ="  
      << "\ntm_year: " << t.tm_year  
      << endl;  
}  
```  
  
 **time_get::get_year(1928) =**  
**tm_year: 28**   
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [time_get Class](../vs140/time_get-class.md)