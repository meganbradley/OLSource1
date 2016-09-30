---
title: "Compiler Warning C4368"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4368"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4368"
ms.assetid: cb85bcee-fd3d-4aa5-b626-2324f07a4f1b
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning C4368
cannot define 'member' as a member of managed 'type': mixed types are not supported  
  
 You cannot embed a native data member in a CLR type.  
  
 You can, however, declare a pointer to a native type and control its lifetime in the constructor and destructor and finalizer of your managed class. For more information see [Destructors and Finalizers](../vs140/how-to--define-and-consume-classes-and-structs--c---cli-.md#BKMK_Destructors_and_finalizers).  
  
 This warning is always issued as an error. Use the [warning](../vs140/warning.md) pragma to disable C4368.  
  
## Example  
 The following sample generates C4368.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>