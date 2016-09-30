---
title: "time_put::put"
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
  - "xloctime/std::time_put::put"
  - "put"
  - "time_put::put"
  - "time_put.put"
  - "std.time_put.put"
  - "std::time_put::put"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put method"
ms.assetid: dc87bd4a-ea57-4ce8-923b-10f6bab71849
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_put::put
Outputs time and date information as a sequence of **CharType**s.  
  
## Syntax  
  
```  
  
      iter  
      _  
      type put(  
   iter_type _Next,   
   ios_base& _Iosbase,  
   char_type _Fill,   
   const tm* _Pt,   
   char _Fmt,   
   char _Mod = 0  
) const;  
iter_type put(  
   iter_type _Next,   
   ios_base& _Iosbase,  
   char_type _Fill,   
   const tm* _Pt,  
   const CharType* _First,   
   const CharType* _Last  
) const;  
```  
  
#### Parameters  
 `_Next`  
 An output iterator where the sequence of characters representing time and date are to be inserted.  
  
 `_Iosbase`  
 Unused.  
  
 `_Fill`  
 The character of type **CharType** used for spacing.  
  
 `_Pt`  
 The time and date information being output.  
  
 `_Fmt`  
 The format of the output. See [strftime, wcsftime, _strftime_l, _wcsftime_l](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md) for valid values.  
  
 `_Mod`  
 A modifier for the format. See [strftime, wcsftime, _strftime_l, _wcsftime_l](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md) for valid values.  
  
 `_First`  
 The beginning of the formatting string for the output. See [strftime, wcsftime, _strftime_l, _wcsftime_l](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md) for valid values.  
  
 `_Last`  
 The end of the formatting string for the output. See [strftime, wcsftime, _strftime_l, _wcsftime_l](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md) for valid values.  
  
## Return Value  
 An iterator to the first position after the last element inserted.  
  
## Remarks  
 The first member function returns [do_put](../vs140/time_put--do_put.md)(`_Next`, `_Iosbase`, `_Fill`, `_Pt`, `_Fmt`, `_Mod`). The second member function copies to \*`_Next` ++ any element in the interval [`_First`, `_Last`) other than a percent (%). For a percent followed by a character *C* in the interval [`_First`, `_Last`), the function instead evaluates `_Next` = `do_put`(`_Next`, `_Iosbase`, `_Fill`, `_Pt`, *C*, 0) and skips past *C*. If, however, *C* is a qualifier character from the set EOQ#, followed by a character `C2` in the interval [`_First`, `_Last`), the function instead evaluates `_Next` = `do_put`(`_Next`, `_Iosbase`, `_Fill`, `_Pt`, `C2`, *C*) and skips past `C2`.  
  
## Example  
  
```  
// time_put_put.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
#include <time.h>  
using namespace std;  
int main( )  
{  
   locale loc;  
   basic_stringstream<char> pszPutI;  
   ios_base::iostate st = 0;  
   struct tm t;  
   memset( &t, 0, sizeof( struct tm ) );  
  
   t.tm_hour = 5;  
   t.tm_min = 30;  
   t.tm_sec = 40;  
   t.tm_year = 00;  
   t.tm_mday = 4;  
   t.tm_mon = 6;  
  
   pszPutI.imbue( loc );  
   char *pattern = "x: %X %x";  
   use_facet <time_put <char> >  
   (loc).put(basic_ostream<char>::_Iter(pszPutI.rdbuf( )),  
          pszPutI, ' ', &t, pattern, pattern+strlen(pattern));  
  
      cout << "num_put( ) = " << pszPutI.rdbuf( )->str( ) << endl;  
  
      char strftimebuf[255];  
      strftime(&strftimebuf[0], 255, pattern, &t);  
      cout << "strftime( ) = " << &strftimebuf[0] << endl;  
}  
```  
  
 **num_put( ) = x: 05:30:40 07/04/00**  
**strftime( ) = x: 05:30:40 07/04/00**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [time_put Class](../vs140/time_put-class.md)