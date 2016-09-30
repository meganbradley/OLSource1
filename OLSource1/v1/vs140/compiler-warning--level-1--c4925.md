---
title: "Compiler Warning (level 1) C4925"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C4925"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4925"
ms.assetid: a4b206c0-016a-4f28-873a-bb8bb41bad50
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4925
'method': dispinterface method cannot be called from script  
  
 Scripting languages cannot create a VT_BYREF 'in' parameter, it can only create VT_BYREF 'out' parameters.  
  
 Another way to resolve this warning is not make the parameter (in the definition and implementation) a pointer type.  
  
 The following sample generates C4925:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>