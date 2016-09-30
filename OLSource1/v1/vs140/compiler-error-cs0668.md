---
title: "Compiler Error CS0668"
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
  - "CS0668"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0668"
ms.assetid: 7bdaa795-ce13-4284-b753-a617c1735cfa
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0668
Two indexers have different names; the IndexerName attribute must be used with the same name on every indexer within a type  
  
 The values passed to the **IndexerName** attribute must be the same for all indexers in a type. For more information on the **IndexerName** attribute, see [IndexerNameAttribute Class](frlrfSystemRuntimeCompilerServicesIndexerNameAttributeClassTopic).  
  
 The following sample generates CS0668:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>