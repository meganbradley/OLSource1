---
title: "forward_list::erase_after"
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
  - "std.forward_list.erase_after"
  - "forward_list/std::forward_list::erase_after"
  - "std::forward_list::erase_after"
  - "forward_list.erase_after"
  - "forward_list::erase_after"
  - "erase_after"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase_after method"
ms.assetid: 6c6b7ad1-cf66-4ac6-9388-8a6f8e0d3699
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward_list::erase_after
Removes elements from the forward list after a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The position in the target forward list where the element is erased.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The beginning of the range to erase.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The end of the range to erase.|  
  
## Return Value  
 An iterator that designates the first element remaining beyond any elements removed, or [end](../vs140/forward_list--end.md) if no such element exists.  
  
## Remarks  
 The first member function removes the element of the controlled sequence just after <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 The second member function removes the elements of the controlled sequence in the range <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (neither end point is included).  
  
 Erasing <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> elements causes <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> destructor calls. [Reallocation](../vs140/forward_list-class.md) occurs, so iterators and references become invalid for the erased elements.  
  
 The member functions never throw an exception.  
  
## Requirements  
 **Header:** \<forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)