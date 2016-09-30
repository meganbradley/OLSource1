---
title: "Compiler Warning (level 4) C4432"
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
  - "C4432"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4432"
ms.assetid: 7909311e-23df-49db-8579-203e5bc53712
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4432
a destructor in a ref-class must have public accessibility; changing to public access  
  
 The compiler made a destructor public. To resolve this warning, explicitly put the destructor in a public section of the class.  
  
 For more information, see [Destructors and Finalizers](../vs140/how-to--define-and-consume-classes-and-structs--c---cli-.md#BKMK_Destructors_and_finalizers).