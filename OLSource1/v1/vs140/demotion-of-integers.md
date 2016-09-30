---
title: "Demotion of Integers"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "demoting integers"
ms.assetid: 51fb3654-60b0-4de7-80eb-bd910086c18a
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Demotion of Integers
**ANSI 3.2.1.2** The result of converting an integer to a shorter signed integer, or the result of converting an unsigned integer to a signed integer of equal length, if the value cannot be represented  
  
 When a **long** integer is cast to **a short**, or a **short** is cast to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the least-significant bytes are retained.  
  
 For example, this line  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 assigns the value 0x5678 to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and this line  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 assigns the value 0x34 to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 When signed variables are converted to unsigned and vice versa, the bit patterns remain the same. For example, casting –2 (0xFE) to an unsigned value yields 254 (also 0xFE).  
  
## See Also  
 [Integers](../vs140/integers.md)