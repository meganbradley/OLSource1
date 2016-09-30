---
title: "deque::insert"
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
  - "std::deque::insert"
  - "deque::insert"
  - "Insert"
  - "insert"
  - "deque.insert"
  - "std.deque.insert"
  - "deque/std::deque::insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: e926d4c4-a1eb-42f1-a90a-0446f2fafefc
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::insert
Inserts an element or a number of elements or a range of elements into the deque at a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The position in the target deque where the first element is inserted.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The value of the element being inserted into the deque.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The number of elements being inserted into the deque.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The position of the first element in the range of elements in the argument deque to be copied.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements in the argument deque to be copied.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The initializer_list of elements to insert.|  
  
## Return Value  
 The first two insert functions return an iterator that points to the position where the new element was inserted into the deque.  
  
## Remarks  
 Any insertion operation can be expensive.  
  
## Code  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::insert](../vs140/deque--insert--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)