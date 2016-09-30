---
title: "list::insert"
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
  - "std::list::insert"
  - "Insert"
  - "insert"
  - "list.insert"
  - "list::insert"
  - "list/std::list::insert"
  - "std.list.insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: 9df9f43b-30cd-43a5-b349-c43f741edd4b
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::insert
Inserts an element or a number of elements or a range of elements into a list at a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The position in the target list where the first element is inserted.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The value of the element being inserted into the list.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The number of elements being inserted into the list.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The position of the first element in the range of elements in the argument list to be copied.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements in the argument list to be copied.|  
  
## Return Value  
 The first two insert functions return an iterator that points to the position where the new element was inserted into the list.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 c1 = 10 20 30c1 = 10 100 20 30c1 = 10 100 200 200 20 30c1 = 10 40 50 100 200 200 20 30Moved first element: ac4 = 5 6 7 8 1 2 3 4  
  
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)