---
title: "Compiler Warning (level 1) CS0420"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0420"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0420"
ms.assetid: 0f52f508-286e-493d-9151-180e05397bf9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS0420
'identifier': a reference to a volatile field will not be treated as volatile  
  
 A volatile field should not normally be passed using a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or **out** parameter, since it will not be treated as volatile within the scope of the function. There are exceptions to this, such as when calling an interlocked API. As with any warning, you may use the [#pragma warning](../vs140/sharppragma-warning--csharp-reference-.md) to disable this warning in those rare cases where you are intentionally using a volatile field as a reference parameter.  
  
 The following sample generates CS0420:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>