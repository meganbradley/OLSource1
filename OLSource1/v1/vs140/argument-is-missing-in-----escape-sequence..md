---
title: "Argument is missing in &#39;-&#39; escape sequence."
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Argument is missing in &#39;\&#39; escape sequence."
f1_keywords: 
  - "vs.message.VS_E_RE_ESCAPEMISSINGARG"
  - "vs.message.0x800A00BD"
ms.assetid: 5bd6559b-8cd9-450f-91c8-335ff1b1ef86
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Argument is missing in &#39;-&#39; escape sequence.
This error generally occurs during search or replace when regular expressions or wildcards are used in a search string. This error can be caused by a single backslash (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>) at the end of a pattern or by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> entered without a valid hexadecimal Unicode character.  
  
### To correct this error  
  
1.  To search using the regular expression escape character, enter <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
2.  To search for a Unicode character, enter <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> followed by a valid Unicode value.  
  
3.  To search for the literal backslash, use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## See Also  
 [Using Regular Expressions in Visual Studio](../vs140/using-regular-expressions-in-visual-studio.md)   
 [NIB: Find and Replace, Quick Find](assetId:///dad03582-4931-4893-83ba-84b37f5b1600)   
 [Find in Files](../vs140/find-in-files.md)