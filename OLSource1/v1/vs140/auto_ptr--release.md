---
title: "auto_ptr::release"
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
  - "release"
  - "Release"
  - "auto_ptr::release"
  - "auto_ptr.release"
  - "std.auto_ptr.release"
  - "memory/std::auto_ptr::release"
  - "std::auto_ptr::release"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "release method"
ms.assetid: d6ba93ce-cc5d-4ba9-8c19-e017920dc516
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_ptr::release
The member replaces the stored pointer **myptr** with a null pointer and returns the previously stored pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The previously stored pointer.  
  
## Remarks  
 The member replaces the stored pointer **myptr** with a null pointer and returns the previously stored pointer.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Constructing 00311AF8 Value: 5**  
**Constructing 00311B88 Value: 6**  
**Destructing 00311AF8 Value: 5**  
**pi2 == pi3**  
**Destructing 00311B88 Value: 6**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [auto_ptr Class](../vs140/auto_ptr-class.md)