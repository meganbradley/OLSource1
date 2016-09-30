---
title: "shared_ptr::unique"
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
  - "tr1.shared_ptr.unique"
  - "memory/std::shared_ptr::unique"
  - "memory/std::tr1::shared_ptr::unique"
  - "tr1::shared_ptr::unique"
  - "shared_ptr.unique"
  - "shared_ptr::unique"
  - "std::tr1::shared_ptr::unique"
  - "std.tr1.shared_ptr.unique"
  - "std::shared_ptr::unique"
  - "std.shared_ptr.unique"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unique method [TR1]"
  - "unique method"
ms.assetid: 13cf3869-dbb8-4d0e-854f-f5add4f1fc9a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_ptr::unique
Tests if owned resource is unique.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if no other <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object owns the resource that is owned by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, otherwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **sp1.unique() == true**  
**sp1.unique() == false**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)