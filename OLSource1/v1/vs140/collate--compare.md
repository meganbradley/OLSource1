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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the first element in the first sequence to be compared.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the last element in the first sequence to be compared.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to the first element in the second sequence to be compared.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to the last element in the second sequence to be compared.  
  
## Return Value  
 The member function returns:  
  
-   –1 if the first sequence compares less than the second sequence.  
  
-   +1 if the second sequence compares less than the first sequence.  
  
-   0 if the sequences are equivalent.  
  
## Remarks  
 The first sequence compares less if it has the smaller element in the earliest unequal pair in the sequences, or, if no unequal pairs exist, but the first sequence is shorter.  
  
 The member function returns [do_compare](../vs140/collate--do_compare.md)(<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [collate Class](../vs140/collate-class.md)