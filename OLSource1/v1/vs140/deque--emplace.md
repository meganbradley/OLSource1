---
title: "deque::emplace"
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
  - "deque/std::deque::emplace"
  - "std::deque::emplace"
  - "deque::emplace"
  - "deque.emplace"
  - "emplace"
  - "std.deque.emplace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace method"
  - "emplace method, deque class"
ms.assetid: b3ea8ce1-87f8-4a76-8881-c3f92fcae96f
caps.latest.revision: 11
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# deque::emplace
Inserts an element constructed in place into the deque at a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The position in the [deque](../vs140/deque-class.md) where the first element is inserted.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The value of the element being inserted into the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
  
## Return Value  
 The function returns an iterator that points to the position where the new element was inserted into the deque.  
  
## Remarks  
 Any insertion operation can be expensive, see <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for a discussion of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> performance.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **v1 = 10 20 30**  
**vv1[0] = 10 20 30**   
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)