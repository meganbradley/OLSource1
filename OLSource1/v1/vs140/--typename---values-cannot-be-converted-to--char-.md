---
title: "&#39;&lt;typename&gt;&#39; values cannot be converted to &#39;Char&#39;"
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
  - "bc32007"
  - "vbc32007"
helpviewer_keywords: 
  - "BC32007"
ms.assetid: b04212da-57ac-4493-9480-04c12b50f875
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;typename&gt;&#39; values cannot be converted to &#39;Char&#39;
'<typename\>' values cannot be converted to Char. Use Microsoft.VisualBasic.ChrW to interpret a numeric value as a Unicode character or first convert it to 'String' to produce a digit.  
  
 An expression attempts to convert a data type other than `String` or `Object` to `Char`.  
  
 **Error ID:** BC32007  
  
### To correct this error  
  
-   Use the `ChrW` function to convert a numeric value to a Unicode character, or first convert the value to `String` and then to `Char`.  
  
## See Also  
 [NOT IN BUILD: Chr, ChrW Functions](assetId:///37f3c707-8a6f-4c51-9b02-9e634c4299ab)   
 [Implicit and Explicit Conversions](../vs140/implicit-and-explicit-conversions--visual-basic-.md)   
 [Char Data Type](../vs140/char-data-type--visual-basic-.md)