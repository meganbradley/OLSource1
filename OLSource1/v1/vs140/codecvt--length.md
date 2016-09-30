---
title: "codecvt::length"
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
  - "codecvt.length"
  - "length"
  - "codecvt::length"
  - "xlocale/std::codecvt::length"
  - "std::codecvt::length"
  - "std.codecvt.length"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "length method"
ms.assetid: 368dad1a-c151-4c3d-9a02-537d74a7f8c0
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::length
Determines how many **Byte**s from a given sequence of external **Byte**s produce not more than a given number of internal **CharType**s and returns that number of **Byte**s.  
  
## Syntax  
  
```  
int length(  
    const StateType& _State,  
    const Byte* _First1,   
    const Byte* _Last1,  
    size_t _Len2  
) const;  
```  
  
#### Parameters  
 `_State`  
 The conversion state that is maintained between calls to the member function.  
  
 `_First1`  
 Pointer to the beginning of the external sequence.  
  
 `_Last1`  
 Pointer to the end of the external sequence.  
  
 `_Len2`  
 The maximum number of Bytes that can be returned by the member function.  
  
## Return Value  
 An integer that represents a count of the maximum number of conversions, not greater than `_Len2`, defined by the external source sequence at [`_First1`, `_Last1`).  
  
## Remarks  
 The member function returns [do_length](../vs140/codecvt--do_length.md)(*_State, _First1*, `_Last1`, `_Len2`).  
  
## Example  
  
```  
// codecvt_length.cpp  
// compile with: /EHsc  
#define _INTL  
#include <locale>  
#include <iostream>  
using namespace std;  
#define LEN 90  
int main( )     
{  
   char* pszExt = "This is the string whose length is to be measured!";  
   mbstate_t state = {0};  
   locale loc("C");//English_Britain");//German_Germany  
   int res = use_facet<codecvt<wchar_t, char, mbstate_t> >  
     ( loc ).length( state,  
          pszExt, &pszExt[strlen(pszExt)], LEN );  
   cout << "The length of the string is: ";  
   wcout << res;  
   cout << "." << endl;  
   exit(-1);  
}  
```  
  
 **The length of the string is: 50.**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)