---
title: "Compiler Warning (level 1) C4807"
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
  - "C4807"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4807"
ms.assetid: 089c9f87-fd81-402e-9826-66a8ef1ef1fe
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4807
'operation' : unsafe mix of type 'type' and signed bitfield of type 'type'  
  
 This warning is generated when comparing a one-bit signed bit field to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> variable. Because a one-bit, signed bit field can only contain the values -1 or 0, it is dangerous to compare it to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. No warnings are generated about mixing <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and one-bit, unsigned bitfields since they are identical to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and can only hold 0 or 1.  
  
## Example  
 The following sample generates C4807:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>