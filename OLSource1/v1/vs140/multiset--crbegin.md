---
title: "multiset::crbegin"
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
  - "std::multiset::crbegin"
  - "multiset.crbegin"
  - "multiset::crbegin"
  - "std.multiset.crbegin"
  - "set/std::multiset::crbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crbegin method"
ms.assetid: 87596713-91ef-4254-9f78-9cc037db8f49
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::crbegin
Returns a const iterator addressing the first element in a reversed multiset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed multiset or addressing what had been the last element in the unreversed multiset.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is used with a reversed multiset just as [begin](#vclrfmultisetrbegin) is used with a multiset.  
  
 With the return value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the multiset object cannot be modified.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> can be used to iterate through a multiset backwards.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element in the reversed multiset is 30.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)