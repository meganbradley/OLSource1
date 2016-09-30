---
title: "allocator::destroy"
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
  - "Destroy"
  - "memory/std::allocator::destroy"
  - "std::allocator::destroy"
  - "std.allocator.destroy"
  - "allocator::destroy"
  - "allocator.destroy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "destroy method"
ms.assetid: c33d12fd-0185-4829-899a-cb3d1d0580fa
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# allocator::destroy
Calls an objects destructor without deallocating the memory where the object was stored.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer designating the address of the object to be destroyed.  
  
## Remarks  
 The member function destroys the object designated by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, by calling the destructor <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> ->**Type**::**~Type**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original vector v1 is:**  
 **( 2 4 6 8 10 12 14 ).**  
**The modified vector v1 is:**  
 **( 2 4 6 8 10 -99 14 ).**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [allocator Class](../vs140/allocator-class.md)