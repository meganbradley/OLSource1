---
title: "CA1308: Normalize strings to uppercase"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CA1308"
  - "NormalizeStringsToUppercase"
helpviewer_keywords: 
  - "NormalizeStringsToUppercase"
  - "CA1308"
ms.assetid: 7e9a7457-3f93-4938-ac6f-1389fba8d9cc
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1308: Normalize strings to uppercase
|||  
|-|-|  
|TypeName|NormalizeStringsToUppercase|  
|CheckId|CA1308|  
|Category|Microsoft.Globalization|  
|Breaking Change|Non-breaking|  
  
## Cause  
 An operation normalizes a string to lowercase.  
  
## Rule Description  
 Strings should be normalized to uppercase. A small group of characters, when they are converted to lowercase, cannot make a round trip. To make a round trip means to convert the characters from one locale to another locale that represents character data differently, and then to accurately retrieve the original characters from the converted characters.  
  
## How to Fix Violations  
 Change operations that convert strings to lowercase so that the strings are converted to uppercase instead. For example, change <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning message when you are not making security decision based on the result (for example, when you are displaying it in the UI).  
  
## See Also  
 [Globalization Warnings](../vs140/globalization-warnings.md)