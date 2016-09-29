---
title: "operator&gt; (set)"
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
  - "std::operator>"
  - "std.>"
  - "std.operator>"
  - "operator>"
  - "std::>"
  - ">"
  - "set/std::operator>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator >, set or multiset objects"
  - "> operator, comparing specific objects"
ms.assetid: 0a43c029-79bb-466a-a6d8-9f005cd04b26
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt; (set)
Tests if the set object on the left side of the operator is greater than the set object on the right side.  
  
## Syntax  
  
```  
  
      bool operator>(  
   const set <Key, Traits, Allocator>& _Left,  
   const set <Key, Traits, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type **set**.  
  
 `_Right`  
 An object of type **set**.  
  
## Return Value  
 **true** if the set on the left side of the operator is greater than the set on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between set objects is based on a pairwise comparison of their elements. The greater-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
```  
// set_op_gt.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   set <int> s1, s2, s3;  
   int i;  
  
   for ( i = 0 ; i < 3 ; i++ )  
   {  
      s1.insert ( i );  
      s2.insert ( i * i );  
      s3.insert ( i - 1 );  
   }  
  
   if ( s1 > s2 )  
      cout << "The set s1 is greater than the set s2." << endl;  
   else  
      cout << "The set s1 is not greater than the set s2." << endl;  
  
   if ( s1 > s3 )  
      cout << "The set s1 is greater than the set s3." << endl;  
   else  
      cout << "The set s1 is not greater than the set s3." << endl;  
}  
```  
  
 **The set s1 is not greater than the set s2.**  
**The set s1 is greater than the set s3.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)