---
title: "money_get::get"
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
  - money_get.get
  - get
  - std::money_get::get
  - std.money_get.get
  - money_get::get
  - xlocmon/std::money_get::get
dev_langs: 
  - C++
helpviewer_keywords: 
  - get method
ms.assetid: ac28c0c1-0cfe-411c-a458-7dcd95072089
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# money_get::get
Extracts a numerical value from a character sequence that represents a monetary value.  
  
## Syntax  
  
```  
  
      iter  
      _  
      type get(  
   iter_type _First,   
   iter_type _Last,  
   bool _Intl,   
   ios_base& _Iosbase,   
   ios_base::iostate& _State,  
   long double& _Val  
) const;  
iter_type get(  
   iter_type _First,   
   iter_type _Last,  
   bool _Intl,   
   ios_base& _Iosbase,   
   ios_base::iostate& _State,  
   string_type& _Val  
) const;  
```  
  
#### Parameters  
 `_First`  
 Input iterator addressing the beginning of the sequence to be converted.  
  
 `_Last`  
 Input iterator addressing the end of the sequence to be converted.  
  
 `_Intl`  
 A Boolean value indicating the type of currency symbol expected in the sequence: **true** if international, **false** if domestic.  
  
 `_Iosbase`  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required  
  
 `_State`  
 Sets the appropriate bitmask elements for the stream state according to whether the operations succeeded.  
  
 `_Val`  
 A string storing the converted sequence.  
  
## Return Value  
 An input iterator addressing the first element beyond the monetary input field.  
  
## Remarks  
 Both member functions return [do_get](../vs140/money_get--do_get.md)(`_First``,` `_Last``,` `_Intl`, `_Iosbase`, `_State`, `_Val`).  
  
## Example  
  
```  
// money_get_get.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
using namespace std;  
  
int main( )  
{  
   locale loc( "german_germany" );  
  
   basic_stringstream< char > psz;  
   psz << use_facet<moneypunct<char, 1> >(loc).curr_symbol() << "-1.000,56";  
   basic_stringstream< char > psz2;  
   psz2 << "-100056" << use_facet<moneypunct<char, 1> >(loc).curr_symbol();  
  
   ios_base::iostate st = 0;  
   long double fVal;  
  
   psz.flags( psz.flags( )|ios_base::showbase );   
   // Which forced the READING the currency symbol  
   psz.imbue(loc);  
   use_facet < money_get < char > >( loc ).  
      get( basic_istream<char>::_Iter( psz.rdbuf( ) ),     
           basic_istream<char>::_Iter( 0 ), true, psz, st, fVal );  
  
   if ( st & ios_base::failbit )  
      cout << "money_get(" << psz.str( ) << ", intl = 1) FAILED"  
           << endl;  
   else  
      cout << "money_get(" << psz.str( ) << ", intl = 1) = "   
           << fVal/100.0 << endl;  
  
   use_facet < money_get < char > >( loc ).  
      get(basic_istream<char>::_Iter(psz2.rdbuf( )),     
          basic_istream<char>::_Iter(0), false, psz2, st, fVal);  
  
   if ( st & ios_base::failbit )  
      cout << "money_get(" << psz2.str( ) << ", intl = 0) FAILED"   
           << endl;  
   else  
      cout << "money_get(" << psz2.str( ) << ", intl = 0) = "   
           << fVal/100.0 << endl;  
};  
```  
  
## Sample Output  
 If you run Windows 2000 or earlier, you will get this output:  
  
```  
money_get(DEM-1.000,56, intl = 1) = -1000.56  
money_get(-100056DM, intl = 0) = -1000.56  
```  
  
 If you run Windows XP, you will get this output:  
  
```  
money_get(EUR-1.000,56, intl = 1) = -1000.56  
money_get(-100056EUR, intl = 0) = -1000.56  
```  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [money_get Class](../vs140/money_get-class.md)