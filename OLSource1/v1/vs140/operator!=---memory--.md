---
title: "operator!= (&lt;memory&gt;)"
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
  - "std::!="
  - "!="
  - "std::operator!="
  - "std.operator!="
  - "std.!="
  - "memory/std::operator!="
  - "operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator !=, allocators objects"
  - "operator !=, unique_ptr objects"
  - "!= operator"
  - "operator!=, unique_ptr objects"
  - "operator!=, allocators objects"
ms.assetid: 4c87d3f8-fa0d-486b-bed7-1123b3968d32
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator!= (&lt;memory&gt;)
Tests for inequality between objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 One of the objects to be tested for inequality.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 One of the objects to be tested for inequality.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The type controlled by the left shared pointer.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The type controlled by the right shared pointer.  
  
## Return Value  
 **true** if the objects are not equal; **false** if objects are equal.  
  
## Remarks  
 The first template operator returns false. (All default allocators are equal.)  
  
 The second and third template operators return <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The allocator objects Alloc & v1Alloc are equal.**   
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **sp0 != sp0 == false**  
**sp0 != sp1 == true**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [auto_ptr Class](../vs140/auto_ptr-class.md)   
 [shared_ptr Class](../vs140/shared_ptr-class.md)   
 [shared_ptr::operator!=](assetId:///1798dc0c-311b-4a1a-8148-5d21e41026e0)   
 [unique_ptr Class](../vs140/unique_ptr-class.md)