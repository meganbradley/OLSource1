---
title: "collate::transform"
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
  - "locale/std::collate::transform"
  - "std::collate::transform"
  - "collate.transform"
  - "transform"
  - "std.collate.transform"
  - "collate::transform"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "transform method"
ms.assetid: fd83c0dc-69da-46bb-94e4-5c74fede68f8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# collate::transform
Converts a character sequence from a locale to a string that may be used in lexicographical comparisons with other character sequences similarly converted from the same locale.  
  
## Syntax  
  
```  
  
      string  
      _  
      type transform(  
   const CharType* _First,  
   const CharType* _Last  
) const;  
```  
  
#### Parameters  
 `_First`  
 A pointer to the first character in the sequence to be converted.  
  
 `_Last`  
 A pointer to the last character in the sequence to be converted.  
  
## Return Value  
 A string that contains the transformed character sequence.  
  
## Remarks  
 The member function returns [do_transform](../vs140/collate--do_transform.md)(`_First`, `_Last`).  
  
## Example  
  
```  
// collate_transform.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <tchar.h>  
using namespace std;  
  
int main( )     
{  
   locale loc ( "German_Germany" );  
   _TCHAR* s1 = _T("\x00dfzz abc.");   
   // \x00df is the German sharp-s (looks like beta),   
   // it comes before z in the alphabet  
   _TCHAR* s2 = _T("zzz abc.");   
  
   collate<_TCHAR>::string_type r1;   // OK for typedef?  
   r1 = use_facet< collate<_TCHAR> > ( loc ).  
      transform (s1, &s1[_tcslen( s1 )-1 ]);  
  
   cout << r1 << endl;  
  
   basic_string<_TCHAR> r2 = use_facet< collate<_TCHAR> > ( loc ).  
      transform (s2, &s2[_tcslen( s2 )-1 ]);  
  
   cout << r2 << endl;  
  
   int result1 = use_facet<collate<_TCHAR> > ( loc ).compare   
      (s1, &s1[_tcslen( s1 )-1 ],  s2, &s2[_tcslen( s2 )-1 ] );  
  
   cout << _tcscmp(r1.c_str( ),r2.c_str( )) << result1   
      << _tcscmp(s1,s2) <<endl;  
}  
```  
  
 **????????    ?**  
**????**  
**???????      ?**  
**????**  
**-1-11**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [collate Class](../vs140/collate-class.md)