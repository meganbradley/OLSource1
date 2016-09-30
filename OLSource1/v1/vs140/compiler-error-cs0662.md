---
title: "Compiler Error CS0662"
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
  - "CS0662"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0662"
ms.assetid: 836fa15e-3bf3-4af5-8acf-072d7d731dcd
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0662
'method' cannot specify only Out attribute on a ref parameter. Use both In and Out attributes, or neither.  
  
 An interface method has a parameter that uses [ref](../vs140/ref--csharp-reference-.md) with just the [Out](frlrfSystemRuntimeInteropServicesOutAttributeClassTopic) attribute. A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter that uses the **Out** attribute must also use the [In](frlrfSystemRuntimeInteropServicesInAttributeClassTopic) attribute.  
  
 The following sample generates CS0662:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>