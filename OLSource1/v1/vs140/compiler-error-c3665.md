---
title: "Compiler Error C3665"
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
  - "C3665"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3665"
ms.assetid: 893bb47e-8de1-43aa-af7d-fa47ad149ee9
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3665
'destructor' : override specifier 'keyword' not allowed on a destructor/finalizer  
  
 A keyword was used that is not allowed on a destructor or finalizer.  
  
 For example, a new slot cannot be requested on a destructor or finalizer.  For more information, see [Explicit Overrides](../vs140/explicit-overrides---c---component-extensions-.md) and [Destructors and Finalizers](../vs140/how-to--define-and-consume-classes-and-structs--c---cli-.md#BKMK_Destructors_and_finalizers).  
  
 The following sample generates C3665:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>