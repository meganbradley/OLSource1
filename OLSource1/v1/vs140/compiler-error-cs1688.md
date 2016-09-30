---
title: "Compiler Error CS1688"
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
  - "CS1688"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1688"
ms.assetid: e15672a1-2570-4e65-99fc-7acc190ae643
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1688
Cannot convert anonymous method block without a parameter list to delegate type 'delegate' because it has one or more out parameters  
  
 The compiler allows parameters to be omitted from an anonymous method block in most cases. This error arises when the anonymous method block does not have a parameter list, but the delegate has an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter. The compiler does not allow this situation because it would need to ignore the presence of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter, which is unlikely to be the correct behavior.  
  
## Example  
 The following code generates error CS1688.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>