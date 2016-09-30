---
title: "auto_ptr::reset"
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
  - "auto_ptr::reset"
  - "Reset"
  - "reset"
  - "std::auto_ptr::reset"
  - "memory/std::auto_ptr::reset"
  - "auto_ptr.reset"
  - "std.auto_ptr.reset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reset method"
ms.assetid: a8cb1832-ce90-4613-ac1c-37e74b16e4a1
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_ptr::reset
The member function evaluates the expression **delete myptr**, but only if the stored pointer value **myptr** changes as a result of a function call. It then replaces the stored pointer with **ptr**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The pointer specified to replace the stored pointer **myptr**.  
  
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