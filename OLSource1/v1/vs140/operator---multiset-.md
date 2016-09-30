---
title: "operator&lt; (multiset)"
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
  - "std::operator<"
  - "operator<"
  - "std.<"
  - "<"
  - "set/std::operator<"
  - "std.operator<"
  - "std::<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator>"
  - "< operator"
ms.assetid: 8fa621bc-107d-458c-ba71-acd007f095a2
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# operator&lt; (multiset)
Tests if the multiset object on the left side of the operator is less than the multiset object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 **true** if the multiset on the left side of the operator is strictly less than the multiset on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between multiset objects is based on a pairwise comparison of their elements. The less-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The multiset s1 is less than the multiset s2.**  
**The multiset s1 is not less than the multiset s3.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)