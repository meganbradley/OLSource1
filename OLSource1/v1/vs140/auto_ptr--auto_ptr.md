---
title: "auto_ptr::auto_ptr"
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
  - "std.auto_ptr.auto_ptr"
  - "auto_ptr.auto_ptr"
  - "std::auto_ptr::auto_ptr"
  - "auto_ptr::auto_ptr"
  - "memory/std::auto_ptr::auto_ptr"
  - "auto_ptr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "auto_ptr class, constructor"
  - "auto_ptr method"
ms.assetid: 3848ab33-8739-4af7-b3a0-6084b75bbacc
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_ptr::auto_ptr
The constructor for objects of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The pointer to the object that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> encapsulates.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object to be copied by the constructor.  
  
## Remarks  
 The first constructor stores <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in **myptr**, the stored pointer to the allocated object. The second constructor transfers ownership of the pointer stored in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, by storing <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.[release](../vs140/auto_ptr--release.md) in **myptr**.  
  
 The third constructor behaves the same as the second, except that it stores **right**.<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.**release** in **myptr**, where <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is the reference stored in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 The template constructor behaves the same as the second constructor, provided that a pointer to **Other** can be implicitly converted to a pointer to **Type**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Constructing 00311AF8**  
**5**  
**7**  
**Destructing 00311AF8**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [auto_ptr Class](../vs140/auto_ptr-class.md)