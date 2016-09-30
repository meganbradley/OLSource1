---
title: "codecvt::out"
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
  - "xlocale/std::codecvt::out"
  - "std::codecvt::out"
  - "std.codecvt.out"
  - "codecvt::out"
  - "out"
  - "codecvt.out"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "out method"
ms.assetid: 9eeb32e2-baed-47ac-a355-f484e314c770
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::out
Converts a sequence of internal **CharType**s to a sequence of external **Byte**s.  
  
## Syntax  
  
```  
result out(  
    StateType& _State,  
    const CharType* _First1,   
    const CharType* _Last1,  
    const CharType*& _Next1,  
    Byte* _First2,   
    Byte* _Last2,   
    Byte*& _Next2  
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
 Reference to a pointer to the first unconverted **CharType** after the last **CharType** converted.  
  
 `_First2`  
 Pointer to the beginning of the converted sequence.  
  
 `_Last2`  
 Pointer to the end of the converted sequence.  
  
 `_Next2`  
 Reference to a pointer to the first unconverted **Byte** after the last converted **Byte**.  
  
## Return Value  
 The member function returns [do_out](../vs140/codecvt--do_out.md)(`_State`, `_First1`, `_Last1`, `_Next1`, `_First2`, `_Last2`, `_Next2`).  
  
## Remarks  
 For more information, see [codecvt::do_out](../vs140/codecvt--do_out.md).  
  
## Example  
  
```  
// codecvt_out.cpp  
// compile with: /EHsc  
#define _INTL  
#include <locale>  
#include <iostream>  
#include <wchar.h>  
using namespace std;  
#define LEN 90  
int main( )     
{  
   char pszExt[LEN+1];  
   wchar_t *pwszInt = L"This is the wchar_t string to be converted.";  
   memset( &pszExt[0], 0, ( sizeof( char ) )*( LEN+1 ) );  
   char* pszNext;  
   const wchar_t* pwszNext;  
   mbstate_t state;  
   locale loc("C");//English_Britain");//German_Germany  
   int res = use_facet<codecvt<wchar_t, char, mbstate_t> >  
      ( loc ).out( state,  
      pwszInt, &pwszInt[wcslen( pwszInt )], pwszNext ,  
      pszExt, &pszExt[wcslen( pwszInt )], pszNext );  
   pszExt[wcslen( pwszInt )] = 0;  
   cout << ( ( res!=codecvt_base::error ) ? "It worked: " : "It didn't work: " )  
   << "The converted string is:\n ["  
   << &pszExt[0]  
   << "]" << endl;  
}  
```  
  
 **It worked: The converted string is:**  
 **[This is the wchar_t string to be converted.]**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)