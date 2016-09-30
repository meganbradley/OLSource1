---
title: "Compiler Error CS0811"
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
  - "CS0811"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0811"
ms.assetid: 99f81ad3-684f-47aa-adb8-360e24901454
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0811
The fully qualified name for 'name' is too long for debug information. Compile without '/debug' option.  
  
 There are size constraints on variable and type names in debug information.  
  
### To correct this error  
  
1.  If modifying the name is not possible, the only alternative is to compile without the [/debug](../vs140/-debug--csharp-compiler-options-.md) option.  
  
## Example  
 The following code generates CS0811:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>