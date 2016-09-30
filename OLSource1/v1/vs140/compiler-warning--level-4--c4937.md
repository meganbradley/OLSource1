---
title: "Compiler Warning (level 4) C4937"
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
  - "C4937"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4937"
ms.assetid: 2bb9f0e7-bbd6-4697-84de-95955e32ae29
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4937
'text1' and 'text2' are indistinguishable as arguments to 'directive'  
  
 Because of the way the compiler processes arguments to directives, names that have meaning to the compiler, such as keywords with multiple text representations (single and double underscore forms), cannot be distinguished.  
  
 Examples of such strings are __cdecl and \__forceinline.  Note, under /Za, only the double underscore forms are enabled.  
  
 The following sample generates C4937:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>