---
title: "codecvt::in"
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
  - "xlocale/std::codecvt::in"
  - "std::codecvt::in"
  - "in"
  - "codecvt::in"
  - "std.codecvt.in"
  - "codecvt.in"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "in method"
ms.assetid: 7ae58847-76f0-4b65-8616-289c48d74699
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::in
Converts an external representation of a sequence of **Byte**s to an internal representation of a sequence of **CharType**s.  
  
## Syntax  
  
```  
result in(  
    StateType& _State,  
    const Byte* _First1,   
    const Byte* _Last1,   
    const Byte*& _Next1,  
    CharType* _First2,  
    CharType* _Last2,  
    CharType*& _Next2,  
) const;  
```  
  
#### Parameters  
 `_State`  
 The conversion state that is maintained between calls to the member function.  
  
 `_First1`  
 Pointer to the beginning of the sequence to be converted.  
  
 `_Last1`  
 Pointer to the end of the sequence to be converted.  
  
 `_Next1`  
 Pointer beyond the end of the converted sequence to the first unconverted character.  
  
 `_First2`  
 Pointer to the beginning of the converted sequence.  
  
 `_Last2`  
 Pointer to the end of the converted sequence.  
  
 `_Next2`  
 Pointer to the **CharType** that comes after the last converted **Chartype** to the first unaltered character in the destination sequence.  
  
## Return Value  
 A return that indicates the success, partial success or failure of the operation. The function returns:  
  
-   **codecvt_base::error** if the source sequence is ill formed.  
  
-   `codecvt_base::noconv` if the function performs no conversion.  
  
-   **codecvt_base::ok** if the conversion succeeds.  
  
-   **codecvt_base::partial** if the source is insufficient or if the destination is not large enough for the conversion to succeed.  
  
## Remarks  
 `_State` must represent the initial conversion state at the beginning of a new source sequence. The function alters its stored value, as needed, to reflect the current state of a successful conversion. After a partial conversion, `_State` must be set so as to allow the conversion to resume when new characters arrive.  
  
 The member function returns [do_in](../vs140/codecvt--do_in.md)(`_State`, _*First1, _Last1, _Next1, First2, _Llast2, _Next2*).  
  
## Example  
  
```  
// codecvt_in.cpp  
// compile with: /EHsc  
#define _INTL  
#include <locale>  
#include <iostream>  
using namespace std;  
#define LEN 90  
int main( )     
{  
   char* pszExt = "This is the string to be converted!";  
   wchar_t pwszInt [LEN+1];  
   memset(&pwszInt[0], 0, (sizeof(wchar_t))*(LEN+1));  
   const char* pszNext;  
   wchar_t* pwszNext;  
   mbstate_t state = {0};  
   locale loc("C");//English_Britain");//German_Germany  
   int res = use_facet<codecvt<wchar_t, char, mbstate_t> >  
     ( loc ).in( state,  
          pszExt, &pszExt[strlen(pszExt)], pszNext,  
          pwszInt, &pwszInt[strlen(pszExt)], pwszNext );  
   pwszInt[strlen(pszExt)] = 0;  
   wcout << ( (res!=codecvt_base::error) ? L"It worked! " : L"It didn't work! " )  
   << L"The converted string is:\n ["  
   << &pwszInt[0]  
   << L"]" << endl;  
   exit(-1);  
}  
```  
  
 **It worked! The converted string is:**  
 **[This is the string to be converted!]**   
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)