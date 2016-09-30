---
title: "collate::hash"
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
  - "std.collate.hash"
  - "collate::hash"
  - "std::collate::hash"
  - "hash"
  - "Hash"
  - "collate.hash"
  - "locale/std::collate::hash"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hash method"
ms.assetid: 4cc4d587-f96d-441f-94ec-919522da2be4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# collate::hash
Determines the hash value of sequence according to their facet-specific rules.  
  
## Syntax  
  
```  
  
      long hash(  
   const CharType* _First,  
   const CharType* _Last  
) const;  
```  
  
#### Parameters  
 `_First`  
 A pointer to the first character in the sequence whose has value is to be determined.  
  
 `_Last`  
 A pointer to the last character in the sequence whose has value is to be determined.  
  
## Return Value  
 A hash value of type **long** for the sequence.  
  
## Remarks  
 The member function returns [do_hash](../vs140/collate--do_hash.md)(`_First`, `_Last`).  
  
 A hash value can be useful, for example, in distributing sequences pseudo-randomly across an array of lists.  
  
## Example  
  
```  
// collate_hash.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <tchar.h>  
using namespace std;  
  
int main( )     
{  
   locale loc ( "German_germany" );  
   _TCHAR * s1 = _T("\x00dfzz abc."); // \x00df is the German sharp-s (looks like beta), it comes before z in the alphabet  
   _TCHAR * s2 = _T("zzz abc."); // \x00df is the German sharp-s (looks like beta), it comes before z in the alphabet  
  
   long r1 = use_facet< collate<_TCHAR> > ( loc ).  
      hash (s1, &s1[_tcslen( s1 )-1 ]);  
   long r2 =  use_facet< collate<_TCHAR> > ( loc ).  
      hash (s2, &s2[_tcslen( s2 )-1 ] );  
   cout << r1 << " " << r2 << endl;  
}  
```  
  
 **541187293 551279837**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [collate Class](../vs140/collate-class.md)