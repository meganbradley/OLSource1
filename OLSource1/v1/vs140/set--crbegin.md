---
title: "set::crbegin"
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
  - "std::set::crbegin"
  - "std.set.crbegin"
  - "set/std::set::crbegin"
  - "set::crbegin"
  - "set.crbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crbegin method"
ms.assetid: f3355550-2cef-44da-989c-c7fe8eeaf7a6
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::crbegin
Returns a const iterator addressing the first element in a reversed set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed set or addressing what had been the last element in the unreversed set.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is used with a reversed set just as [begin](../vs140/set--begin.md) is used with a set.  
  
 With the return value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the set object cannot be modified.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element in the reversed set is 30.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [set::rbegin and set::rend](../vs140/set--rbegin-and-set--rend.md)   
 [Standard Template Library](../vs140/standard-template-library.md)