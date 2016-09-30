---
title: "Compiler Error C2975"
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
  - "C2975"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2975"
ms.assetid: 526f6b9d-6c76-4c12-9252-1b1d7c1e06c7
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2975
'arg' : invalid template argument for 'type', expected compile-time constant expression  
  
 The template argument does not match the template declaration; a constant expression should appear within the angle brackets. Variables are not allowed as template actual arguments. Check the template definition to find the correct types.  
  
 The following sample generates C2975:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2975 will also occur when you use __LINE\_\_ as a compile-time constant with [/ZI](../vs140/-z7---zi---zi--debug-information-format-.md). One solution would be to compile with [/Zi](../vs140/-z7---zi---zi--debug-information-format-.md) instead of **/ZI**.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>