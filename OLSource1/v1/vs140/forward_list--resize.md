---
title: "forward_list::resize"
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
  - "forward_list/std::forward_list::resize"
  - "std.forward_list.resize"
  - "forward_list::resize"
  - "std::forward_list::resize"
  - "resize"
  - "forward_list.resize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "resize method"
ms.assetid: 56ddc483-1734-4621-b3bf-4483b2f0556c
caps.latest.revision: 11
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# forward_list::resize
Specifies a new size for a forward list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The number of elements in the resized forward list.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The value to use for padding.|  
  
## Remarks  
 The member functions both ensure that the number of elements in the list henceforth is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If it must make the controlled sequence longer, the first member function appends elements with value <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, while the second member function appends elements with value <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. To make the controlled sequence shorter, both member functions effectively call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)