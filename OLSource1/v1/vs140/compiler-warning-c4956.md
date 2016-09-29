---
title: "Compiler Warning C4956"
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
  - "C4956"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4956"
ms.assetid: 9154f2d1-d49f-4e07-90d2-0e9bc028011a
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning C4956
'type' : this type is not verifiable  
  
 This warning is generated when [/clr:safe](../vs140/-clr--common-language-runtime-compilation-.md) is specified and your code contains a type that is not verifiable.  
  
 For more information, see [Pure / Verifiable](../vs140/pure-and-verifiable-code--c---cli-.md).  
  
 This warning is issued as an error and can be disabled with the [warning](../vs140/warning.md) pragma or the [/wd](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md) compiler option.  
  
 The following sample generates C4956:  
  
```  
// C4956.cpp  
// compile with: /clr:safe  
int* p;   // C4956  
```