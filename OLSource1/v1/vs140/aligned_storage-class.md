---
title: "aligned_storage Class"
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
  - "aligned_storage"
  - "std::tr1::aligned_storage"
  - "std.tr1.aligned_storage"
  - "std.aligned_storage"
  - "std::aligned_storage"
  - "type_traits/std::aligned_storage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "aligned_storage class [TR1]"
  - "aligned_storage"
ms.assetid: f255e345-1f05-4d07-81e4-017f420839fb
caps.latest.revision: 23
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# aligned_storage Class
Makes suitably aligned type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The object size.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The object alignment.  
  
## Remarks  
 The template member typedef <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a synonym for a POD type with alignment <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and size <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> must be equal to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> for some type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, or to the default alignment.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **alignment_of\<int> == 4**  
**aligned to double == 8**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [alignment_of](../vs140/alignment_of-class.md)