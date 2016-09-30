---
title: "unique_ptr::reset"
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
  - "std.unique_ptr.reset"
  - "unique_ptr.reset"
  - "memory/std::unique_ptr::reset"
  - "unique_ptr::reset"
  - "reset"
  - "std::unique_ptr::reset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reset method"
ms.assetid: ad3bc68d-add1-40a3-9427-40a1fbaf8cbb
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_ptr::reset
Takes ownership of the pointer parameter, and then deletes the original stored pointer. If the new pointer is the same as the original stored pointer, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> deletes the pointer and sets the stored pointer to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|A pointer to the resource to take ownership of.|  
  
## Remarks  
 Use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to change the stored [pointer](../vs140/pointer.md) owned by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and then delete the original stored pointer. If the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> was not empty, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> invokes the deleter function returned by [get_deleter](../vs140/unique_ptr--get_deleter.md) on the original stored pointer.  
  
 Because <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> first stores the new pointer <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and then deletes the original stored pointer, it's possible for <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to immediately delete <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if it is the same as the original stored pointer.  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [unique_ptr](../vs140/unique_ptr-class.md)   
 [\<memory>](../vs140/-memory-.md)