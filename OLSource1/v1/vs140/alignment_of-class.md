---
title: "alignment_of Class"
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
  - "std.tr1.alignment_of"
  - "std::tr1::alignment_of"
  - "alignment_of"
  - "std.alignment_of"
  - "std::alignment_of"
  - "type_traits/std::alignment_of"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "alignment_of class [TR1]"
  - "alignment_of"
ms.assetid: 4141c59a-f94e-41c4-93fd-9ea578b27387
caps.latest.revision: 24
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# alignment_of Class
Gets alignment of the specified type. This struct is implemented in terms of [alignof](../vs140/alignof-and-alignas--c---.md). Use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> directly when you simply need to query an alignment value. Use alignment_of when you need an integral constant, for example when doing tag dispatch.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 The type query holds the value of the the alignment of the type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [aligned_storage](../vs140/aligned_storage-class.md)