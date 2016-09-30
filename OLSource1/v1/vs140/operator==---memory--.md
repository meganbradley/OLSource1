---
title: "operator== (&lt;memory&gt;)"
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
  - "std.=="
  - "std::=="
  - "memory/std::operator=="
  - "operator=="
  - "std.operator=="
  - "std::operator=="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator ==, unique_ptr objects"
  - "operator==, unique_ptr objects"
  - "operator ==, allocators objects"
  - "== operator, with specific standard C++ objects"
  - "operator==, allocators objects"
ms.assetid: 04c15ebd-14ce-43bd-b68f-4e468c2e950c
caps.latest.revision: 25
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# operator== (&lt;memory&gt;)
Tests for equality between objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 One of the objects to be tested for equality.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 One of the objects to be tested for equality.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The type controlled by the left shared pointer.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The type controlled by the right shared pointer.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the objects are equal, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if objects are not equal.  
  
## Remarks  
 The first template operator returns true. (All default allocators are equal.)  
  
 The second and third template operators return <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The allocator objects cv1Alloc & v1Alloc are equal.**  
**The allocator objects cAlloc & Alloc are equal.**   
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **sp0 == sp0 == true**  
**sp0 == sp1 == false**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [auto_ptr Class](../vs140/auto_ptr-class.md)   
 [shared_ptr Class](../vs140/shared_ptr-class.md)   
 [shared_ptr::operator==](assetId:///69467417-7d95-4363-b64e-ca5ac08b9530)   
 [unique_ptr Class](../vs140/unique_ptr-class.md)