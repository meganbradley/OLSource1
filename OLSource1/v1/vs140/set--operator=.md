---
title: "set::operator="
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
  - "operator="
  - "set::operator="
  - "std.set.operator="
  - "std::set::operator="
  - "set.operator="
  - "set/std::set::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator="
ms.assetid: 20183766-3575-430a-aee2-84f2bb647a3e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::operator=
Replaces the elements of this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> using elements from another <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> providing new elements to be assigned to this <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
  
## Remarks  
 The first version of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> uses an [lvalue reference](../vs140/lvalue-reference-declarator---.md) for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, to copy elements from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to this <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 The second version uses an [rvalue reference](../vs140/rvalue-reference-declarator----.md) for _Right. It moves elements from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to this <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 Any elements in this <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> before the operator function executes are discarded.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)   
 [Lvalues and Rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)