---
title: "swap (C++ Standard Library)"
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
  - "std.tr1.swap"
  - "std::tr1::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap function [TR1]"
ms.assetid: fd328269-955b-4d79-8268-9038841e5c76
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# swap (C++ Standard Library)
Swap two shared_ptr or weak_ptr objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type controlled by the left shared/weak pointer.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type controlled by the right shared/weak pointer.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The left shared/weak pointer.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The right shared/weak pointer.  
  
## Remarks  
 The template functions call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **\*sp1 == 5**  
**\*sp1 == 10**  
**\*sp1 == 5**  
**\*wp1 == 5**  
**\*wp1 == 10**  
**\*wp1 == 5**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)   
 [weak_ptr](../vs140/weak_ptr-class.md)