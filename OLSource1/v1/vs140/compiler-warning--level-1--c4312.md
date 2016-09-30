---
title: "Compiler Warning (level 1) C4312"
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
  - "C4312"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4312"
ms.assetid: 541906ed-4f62-4bcb-947f-cf9ae7411bcb
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4312
'operation' : conversion from 'type1' to 'type2' of greater size  
  
 This warning detects an attempt to assign a 32-bit value to a 64-bit pointer type, for example, casting a 32-bit <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to a 64-bit pointer.  
  
 This can be an unsafe conversion even for pointer values that fit in 32 bits when sign extension occurs. If a negative 32-bit integer is assigned to a 64-bit pointer type, sign extension causes the pointer value to reference a memory address different from the value of the integer.  
  
 This warning is only issued for 64-bit compilation targets. For more information, see [Rules for Using Pointers](http://msdn.microsoft.com/library/windows/desktop/aa384242).  
  
 The following code example generates C4312 when it is compiled for 64-bit targets:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>