---
title: "Compiler Warning C4959"
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
  - "C4959"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4959"
ms.assetid: 3a128f3e-4d8a-4565-ba1a-5d32fdeb5982
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning C4959
cannot define unmanaged struct 'type' in /clr:safe because accessing its members yields unverifiable code  
  
 Accessing a member of an unmanaged type will produce an unverifiable (peverify.exe) image.  
  
 For more information, see [Pure / Verifiable](../vs140/pure-and-verifiable-code--c---cli-.md).  
  
 This warning is issued as an error and can be disabled with the [warning](../vs140/warning.md) pragma or the [/wd](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md) compiler option.  
  
 The following sample generates C4959:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>