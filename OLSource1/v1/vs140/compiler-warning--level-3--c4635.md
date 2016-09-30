---
title: "Compiler Warning (level 3) C4635"
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
  - "C4635"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4635"
ms.assetid: b2ba90de-c093-4a76-8076-b65878467574
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4635
XML document comment target: badly-formed XML: reason  
  
 The compiler found some problem with the XML tags.  Fix the problem and recompile  
  
 The following sample generates C4635:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Notice that the output for this sample says: **End tag 'member' does not match the start tag 'summary'.**  
  
 The problem with this sample is that the end tag for \<summary> is poorly formed, and the compiler does not recognize it as the \<summary> end tag.  The \<member> tag is embedded in the .xdc file by the compiler in every /doc compilation.  So, the problem here is that the end tag \</member>, does not match the previous start tag that the compiler processed (\<summary>.