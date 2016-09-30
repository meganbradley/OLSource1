---
title: "Compiler Warning (level 1) CS1685"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1685"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1685"
ms.assetid: b115dd93-a749-4549-83d3-9cdc92a8ef31
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS1685
The predefined type 'System.type name' is defined in multiple assemblies in the global alias; using definition from 'File Name'  
  
 This error occurs when a predefined system type such as System.int32 is found in two assemblies. One way this can happen is if you are referencing mscorlib from two different places, such as trying to run the.Net Framework versions 1.0 and 1.1 side-by-side.  
  
 The compiler will use the definition from only one of the assemblies. The compiler searches only global aliases, does not search libraries defined **/reference**. If you have specified **/nostdlib**, the compiler will search for \<xref:System.Object*>, and in the future start all searches for predefined types in the file where it found \<xref:System.Object*>.