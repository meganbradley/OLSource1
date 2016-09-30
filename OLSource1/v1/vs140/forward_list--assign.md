---
title: "forward_list::assign"
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
  - "std::forward_list::assign"
  - "assign"
  - "forward_list.assign"
  - "forward_list::assign"
  - "forward_list/std::forward_list::assign"
  - "std.forward_list.assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign method"
ms.assetid: 9a93691d-7579-46b3-b440-c542945e3cf9
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward_list::assign
Erases elements from a forward list and copies a new set of elements to a target forward list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The beginning of the replacement range.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The end of the replacement range.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The number of elements to assign.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The value to assign each element.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The type of the value.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The initializer_list to copy.|  
  
## Remarks  
 If the forward_list is an integer type, the first member function behaves the same as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Otherwise, the first member function replaces the sequence controlled by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> with the sequence  [<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, which must not overlap the initial controlled sequence.  
  
 The second member function replaces the sequence controlled by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> with a repetition of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> elements of value <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 The third member function copies the elements of the initializer_list into the forward_list.  
  
## Requirements  
 **Header:** \<forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)