---
title: "Compiler Error CS1958"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1958"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1958"
ms.assetid: bb6f3bb2-ea93-4d2e-984c-da9c99f5653f
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1958
Object and collection initializer expressions may not be applied to a delegate creation expression,  
  
 A delegate has no members like a class or struct has, and so there is nothing for an object initializer to initialize. If you encounter this error, it is probably because there are braces after the delegate creation expression. Just remove the braces and this error will disappear.  
  
### To correct this error  
  
1.  Remove the braces.  
  
## Example  
 The following code produces CS1958:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>