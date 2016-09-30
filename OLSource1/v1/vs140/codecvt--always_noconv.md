---
title: "codecvt::always_noconv"
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
  - "std::codecvt::always_noconv"
  - "locale/std::codecvt::always_noconv"
  - "codecvt.always_noconv"
  - "codecvt::always_noconv"
  - "always_noconv"
  - "std.codecvt.always_noconv"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "always_noconv function"
ms.assetid: 30363b06-009f-4c18-9e5f-35dc62e9b22e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::always_noconv
Tests whether no conversions need be done.  
  
## Syntax  
  
```  
bool always_noconv( ) const throw( );  
```  
  
## Return Value  
 A Boolean value that is **true** if no conversions need be done; **false** is at least one needs to be done.  
  
## Remarks  
 The member function returns [do_always_noconv](../vs140/codecvt--do_always_noconv.md).  
  
## Example  
  
```  
// codecvt_always_noconv.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
using namespace std;  
  
int main( )     
{  
   locale loc ( "German_Germany" );  
   bool result1 = use_facet<codecvt<char, char, mbstate_t> >   
      ( loc ).always_noconv( );  
  
   if ( result1 )  
      cout << "No conversion is needed." << endl;  
   else  
      cout << "At least one conversion is required." << endl;  
  
   bool result2 = use_facet<codecvt<wchar_t, char, mbstate_t> >   
      ( loc ).always_noconv( );  
  
   if ( result2 )  
      cout << "No conversion is needed." << endl;  
   else  
      cout << "At least one conversion is required." << endl;  
}  
```  
  
 **No conversion is needed.**  
**At least one conversion is required.**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)