---
title: "list::crend"
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
  - "list.crend"
  - "crend"
  - "std::list::crend"
  - "std.list.crend"
  - "list/std::list::crend"
  - "list::crend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crend method"
ms.assetid: 60922007-b4df-4716-b309-4f4ea40fb570
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::crend
Returns a const iterator that addresses the location succeeding the last element in a reversed list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed [list](../vs140/list-class.md) (the location that had preceded the first element in the unreversed <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>).  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used with a reversed list just as [end](../vs140/list--end.md) is used with a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The value returned by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> should not be dereferenced.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element in the list is: 10**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)