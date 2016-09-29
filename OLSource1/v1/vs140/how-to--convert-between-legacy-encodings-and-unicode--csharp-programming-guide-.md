---
title: "How to: Convert Between Legacy Encodings and Unicode (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "conversions [C#], legacy to unicode encoding"
  - "strings [C#], converting between encodings"
ms.assetid: 4eed7d8e-47ab-4a7c-8b95-9645a0ef000b
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Convert Between Legacy Encodings and Unicode (C# Programming Guide)
In C#, all strings in memory are encoded as Unicode (UTF-16). When you bring data from storage into a `string` object, the data is automatically converted to UTF-16. If the data contains only ASCII values from 0 through 127, the conversion requires no extra effort on your part. However, if the source text contains extended ASCII byte values (128 through 255), the extended characters will be interpreted by default according to the current code page. To specify that the source text should be interpreted according to a different code page, use the <xref:System.Text.Encoding*?displayProperty=fullName> class as shown in the following example.  
  
## Example  
 The following example shows how to convert a text file that has been encoded in 8-bit ASCII, interpreting the source text according to Windows Code Page 737.  
  
 [!code[csProgGuideStrings#34](../vs140/codesnippet/CSharp/how-to--convert-between-legacy-encodings-and-unicode--csharp-programming-guide-_1.cs)]  
  
## See Also  
 [Strings Overview (C# Programming Guide)](../vs140/strings--csharp-programming-guide-.md)