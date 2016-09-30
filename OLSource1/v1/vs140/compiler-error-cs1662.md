---
title: "Compiler Error CS1662"
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
  - "CS1662"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1662"
ms.assetid: e61a4fc8-0ef1-4a4a-a27b-3a015c3ba38a
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1662
Cannot convert anonymous method block to delegate type 'delegate type' because some of the return types in the block are not implicitly convertible to the delegate return type  
  
 This error occurs if the anonymous method block's return statement had a type that was not implicitly convertible to the return type of the delegate.  
  
 The following sample generates CS1662:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>