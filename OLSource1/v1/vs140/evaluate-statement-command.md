---
title: "Evaluate Statement Command"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "debug.evaluatestatement"
helpviewer_keywords: 
  - "Debug.EvaluateStatement command"
  - "Evaluate Statement command"
ms.assetid: 032039bc-9477-4f93-9b9d-66d4be0e90f4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Evaluate Statement Command
Evaluates and displays the given statement.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Required. The statement to evaluate.  
  
## Remarks  
 The window used to enter the **EvaluateStatement** command determines whether an equals sign (=) is interpreted as a comparison operator or as an assignment operator.  
  
 In the **Command** window, an equals sign (=) is interpreted as a comparison operator. So, for example, if the values of variables <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> are different, then the command  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 will return a value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 In the **Immediate** window, by contrast, an equals sign (=) is interpreted as an assignment operator. So, for example, the command  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 will assign to variable <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> the value of variable <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Print Command](../vs140/print-command.md)   
 [Visual Studio Commands](../vs140/visual-studio-commands.md)   
 [Command Window](../vs140/command-window.md)   
 [Find/Command Box](../vs140/find-command-box.md)   
 [Visual Studio Command Aliases](../vs140/visual-studio-command-aliases.md)