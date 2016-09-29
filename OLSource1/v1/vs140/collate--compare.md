---
title: "collate::compare"
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
  - "std::collate::compare"
  - "Compare"
  - "collate::compare"
  - "std.collate.compare"
  - "collate.compare"
  - "locale/std::collate::compare"
  - "compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "compare method"
ms.assetid: dc166150-1f54-4d12-a810-059b7f349bfb
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# collate::compare
Compares two character sequences according to their facet-specific rules for equality or inequality.  
  
## Syntax  
  
```  
  
      int compare(  
   const CharType* _First1,  
   const CharType* _Last1,  
   const CharType* _First2,  
   const CharType* _Last2  
) const;  
```  
  
#### Parameters  
 `_First1`  
 Pointer to the first element in the first sequence to be compared.  
  
 `_Last1`  
 Pointer to the last element in the first sequence to be compared.  
  
 `_First2`  
 Pointer to the first element in the second sequence to be compared.  
  
 `_Last2`  
 Pointer to the last element in the second sequence to be compared.  
  
## Return Value  
 The member function returns:  
  
-   –1 if the first sequence compares less than the second sequence.  
  
-   +1 if the second sequence compares less than the first sequence.  
  
-   0 if the sequences are equivalent.  
  
## Remarks  
 The first sequence compares less if it has the smaller element in the earliest unequal pair in the sequences, or, if no unequal pairs exist, but the first sequence is shorter.  
  
 The member function returns [do_compare](../vs140/collate--do_compare.md)(`_First1`, `_Last1`, `_First2`, `_Last2`).  
  
## Example  
  
```  
// collate_compare.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <tchar.h>  
using namespace std;  
  
int main() {  
   locale loc ( "German_germany" );  
   _TCHAR * s1 = _T("Das ist wei\x00dfzz."); // \x00df is the German sharp-s, it comes before z in the German alphabet  
   _TCHAR * s2 = _T("Das ist weizzz.");  
   int result1 = use_facet<collate<_TCHAR> > ( loc ).  
      compare ( s1, &s1[_tcslen( s1 )-1 ],  s2, &s2[_tcslen( s2 )-1 ] );  
   cout << result1 << endl;  
  
   locale loc2 ( "C" );  
   int result2 = use_facet<collate<_TCHAR> > ( loc2 ).  
      compare (s1, &s1[_tcslen( s1 )-1 ],  s2, &s2[_tcslen( s2 )-1 ] );  
   cout << result2 << endl;  
}  
```  
  
## Sample Output  
  
```  
-1  
1  
```  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [collate Class](../vs140/collate-class.md)