---
title: "Directives (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 9
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Directives (Visual Basic)
The topics in this section document the Visual Basic source code compiler directives.  
  
## In This Section  
 [#Const Directive](../VS_visualbasic/sharpconst-directive.md) -- Define a compiler constant  
  
 [#ExternalSource Directive](../VS_visualbasic/sharpexternalsource-directive.md) -- Indicate a mapping between source lines and text external to the source  
  
 [#If...Then...#Else Directives](../VS_visualbasic/sharpif...then...sharpelse-directives.md) -- Compile selected blocks of code  
  
 [#Region Directive](../VS_visualbasic/sharpregion-directive.md) -- Collapse and hide sections of code in the Visual Studio editor  
  
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
 [Visual Basic Language Reference](../VS_visualbasic/visual-basic-language-reference.md)  
  
 [Visual Basic](../VS_visualbasic/visual-basic.md)