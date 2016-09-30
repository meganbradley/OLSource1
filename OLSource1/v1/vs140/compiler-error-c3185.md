---
title: "Compiler Error C3185"
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
  - "C3185"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3185"
ms.assetid: 5bf96279-043c-4981-9d02-b4550071b192
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3185
'typeid' used on managed or WinRT type 'type', use 'operator' instead  
  
 You cannot apply the [typeid](../vs140/typeid-operator.md) operator to a managed or WinRT type; use [typeid](../vs140/typeid---c---component-extensions-.md) instead.  
  
 The following sample generates C3185 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Managed Extensions for C++**  
  
 You cannot apply [typeid](../vs140/typeid-operator.md) to a managed type; use [__typeof](../vs140/__typeof.md) instead.  
  
 The following sample generates C3185:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>