---
title: "Alias definition is recursive."
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
  - "vs.message.0x800A00DA"
  - "vs.message.VS_E_RECURSIVEALIAS"
ms.assetid: e48a2908-9b94-4c6a-9807-beeeba71531c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Alias definition is recursive.
This error generally occurs when an alias has been defined that directly or indirectly references itself.  
  
### To correct this error  
  
1.  Change the definition of the alias and try again.  
  
     —or—  
  
2.  Review the current list of aliases and their definitions by entering <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> in the **Command** window and try again.  
  
## See Also  
 [Alias Command](../vs140/alias-command.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)