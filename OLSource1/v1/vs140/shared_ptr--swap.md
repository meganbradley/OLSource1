---
title: "shared_ptr::swap"
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
  - "shared_ptr.swap"
  - "memory/std::tr1::shared_ptr::swap"
  - "tr1::shared_ptr::swap"
  - "shared_ptr::swap"
  - "tr1.shared_ptr.swap"
  - "std.tr1.shared_ptr.swap"
  - "std::tr1::shared_ptr::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method [TR1]"
  - "swap method"
ms.assetid: 2c85710d-64a7-41ad-98c0-2a8c7d87c7ca
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_ptr::swap
Swaps two <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The shared pointer to swap with.  
  
## Remarks  
 The member function leaves the resource originally owned by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> subsequently owned by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and the resource originally owned by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> subsequently owned by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The function does not change the reference counts for the two resources and it does not throw any exceptions.  
  
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
 [shared_ptr::operator=](../vs140/shared_ptr--operator=.md)