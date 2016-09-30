---
title: "multiset::swap"
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
  - "multiset::swap"
  - "multiset.swap"
  - "std::multiset::swap"
  - "set/std::multiset::swap"
  - "swap"
  - "std.multiset.swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: 909a7bef-ca13-48e1-a3f7-915216da1833
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::swap
Exchanges the elements of two multisets.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument multiset providing the elements to be swapped with the target multiset.  
  
## Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two multisets whose elements are being exchanged.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original multiset ms1 is: 10 20 30.**  
**After swapping with ms2, list ms1 is: 100 200.**  
**After swapping with ms3, list ms1 is: 300.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)