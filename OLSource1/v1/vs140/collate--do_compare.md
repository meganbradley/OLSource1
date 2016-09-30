---
title: "collate::do_compare"
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
  - "std::collate::do_compare"
  - "locale/std::collate::do_compare"
  - "do_compare"
  - "collate::do_compare"
  - "std.collate.do_compare"
  - "collate.do_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_compare method"
ms.assetid: e7f99848-169c-4f63-8168-e7227549595a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# collate::do_compare
A virtual function called to compare two character sequences according to their facet-specific rules for equality or inequality.  
  
## Syntax  
  
```  
  
      virtual int do  
      _  
      compare(  
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
  
-   -1 if the first sequence compares less than the second sequence.  
  
-   +1 if the second sequence compares less than the first sequence.  
  
-   0 if the sequences are equivalent.  
  
## Remarks  
 The protected virtual member function compares the sequence at [*_First1, Last1)* with the sequence at *[_First2, _Last2*). It compares values by applying **operator<** between pairs of corresponding elements of type **CharType**. The first sequence compares less if it has the smaller element in the earliest unequal pair in the sequences or if no unequal pairs exist but the first sequence is shorter.  
  
## Example  
 See the example for [collate::compare](../vs140/collate--compare.md), which calls `do_compare`.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [collate Class](../vs140/collate-class.md)