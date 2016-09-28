---
title: "MBCS Programming Tips"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "_mbcs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "programming [C++], MBCS"
  - "character sets [C++], multibyte"
  - "MBCS [C++], programming"
  - "multibyte characters [C++]"
ms.assetid: d8ad36b8-917f-474e-8adb-69462adecd17
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MBCS Programming Tips
In new development, you should use Unicode character encoding for all strings that end users might possibly see. MBCS is a legacy technology that has been superceded by Unicode. This section supplies tips for developers who must maintain existing programs that use MBCS and where it is not practical to convert to Unicode. The advice applies to MFC applications and applications written without MFC. Topics include:  
  
-   [General MBCS Programming Advice](../vs140/general-mbcs-programming-advice.md)  
  
-   [Incrementing and Decrementing Pointers](../vs140/incrementing-and-decrementing-pointers.md)  
  
-   [Byte Indices](../vs140/byte-indices.md)  
  
-   [Last Character in a String](../vs140/last-character-in-a-string.md)  
  
-   [Character Assignment](../vs140/character-assignment.md)  
  
-   [Character Comparison](../vs140/character-comparison.md)  
  
-   [Buffer Overflow](../vs140/buffer-overflow.md)  
  
## See Also  
 [Support for Multibyte Character Sets (MBCSs)](../vs140/support-for-multibyte-character-sets--mbcss-.md)