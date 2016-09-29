---
title: "Directives (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "directives, Visual Basic compiler"
  - "Visual Basic code, directives"
  - "directives"
ms.assetid: 20d5fe65-490a-4c23-88c2-ee4f490ed762
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Directives (Visual Basic)
The topics in this section document the Visual Basic source code compiler directives.  
  
## In This Section  
 [#Const Directive](../VS_csharp/sharpconst-directive.md) -- Define a compiler constant  
  
 [#ExternalSource Directive](../VS_csharp/sharpexternalsource-directive.md) -- Indicate a mapping between source lines and text external to the source  
  
 [#If...Then...#Else Directives](../VS_csharp/sharpif...then...sharpelse-directives.md) -- Compile selected blocks of code  
  
 [#Region Directive](../VS_csharp/sharpregion-directive.md) -- Collapse and hide sections of code in the Visual Studio editor  
  
 **#Disable, #Enable** -- Disable and enable specific warnings for regions of code.  
  
```vb  
#Disable Warning BC42356 ' suppress warning about no awaits in this method  
    Async Function TestAsync() As Task  
        Console.WriteLine("testing")  
    End Function  
#Enable Warning BC42356  
  
```  
  
 You can disable and enable a comma-separated list of warning codes too.  
  
## Related Sections  
 [Visual Basic Language Reference](../VS_csharp/visual-basic-language-reference.md)  
  
 [Visual Basic](../VS_csharp/visual-basic.md)