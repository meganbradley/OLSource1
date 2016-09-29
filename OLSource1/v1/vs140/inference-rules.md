---
title: "Inference Rules"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "inference rules in NMAKE"
  - "rules, inference"
  - "NMAKE program, inference rules"
ms.assetid: caff320f-fb07-4eea-80c3-a6a2133a8492
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Inference Rules
Inference rules supply commands to update targets and to infer dependents for targets. Extensions in an inference rule match a single target and dependent that have the same base name. Inference rules are user-defined or predefined; predefined rules can be redefined.  
  
 If an out-of-date dependency has no commands, and if [.SUFFIXES](../vs140/dot-directives.md) contains the dependent's extension, NMAKE uses a rule whose extensions match the target and an existing file in the current or specified directory. If more than one rule matches existing files, the **.SUFFIXES** list determines which to use; list priority descends from left to right. If a dependent file does not exist and is not listed as a target in another description block, an inference rule can create the missing dependent from another file with the same base name. If a description block's target has no dependents or commands, an inference rule can update the target. Inference rules can build a command-line target even if no description block exists. NMAKE may invoke a rule for an inferred dependent even if an explicit dependent is specified.  
  
## What do you want to know more about?  
 [Defining a rule](../vs140/defining-a-rule.md)  
  
 [Batch-mode rules](../vs140/batch-mode-rules.md)  
  
 [Predefined rules](../vs140/predefined-rules.md)  
  
 [Inferred dependents and rules](../vs140/inferred-dependents-and-rules.md)  
  
 [Precedence in inference rules](../vs140/precedence-in-inference-rules.md)  
  
## See Also  
 [NMAKE Reference](../vs140/nmake-reference.md)