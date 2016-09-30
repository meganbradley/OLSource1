---
title: "aligned_union Class"
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
  - "aligned_union"
  - "std.aligned_union"
  - "std::aligned_union"
  - "type_traits/std::aligned_union"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "aligned_union"
ms.assetid: 9931a44d-3a67-4f29-a0f6-d47a7cf560ac
caps.latest.revision: 10
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# aligned_union Class
Provides a POD type large enough and suitably aligned to store a union type, and the size required.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The alignment value for the largest type in the union.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The distinct types in the underlying union.  
  
## Remarks  
 Use the template class to get the alignment and size needed to store a union in uninitialized storage. The member typedef <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> names a POD type suitable for storage of any type listed in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; the minimum size is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The static member <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> contains the strictest alignment required of all the types listed in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
 The following example shows how to use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to allocate an aligned stack buffer to place a union.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **value of u->i is 1065353216**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [alignment_of](../vs140/alignment_of-class.md)