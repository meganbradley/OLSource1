---
title: "#ExternalSource Directive"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "#Externalsource"
  - "#ExternalSource"
  - "vb.ExternalSource"
  - "Externalsource"
  - "vb.#ExternalSource"
  - "ExternalSource"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "ExternalSource directive (#ExternalSource)"
  - "#ExternalSource directive"
ms.assetid: 243bc6a2-34c3-4eeb-a776-9fd2bf988149
caps.latest.revision: 164
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #ExternalSource Directive
Indicates a mapping between specific lines of source code and text external to the source.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The path to the external source.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The line number of the first line of the external source.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The line where the error occurs in the external source.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Terminates the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> block.  
  
## Remarks  
 This directive is used only by the compiler and the debugger.  
  
 A source file may include external source directives, which indicate a mapping between specific lines of code in the source file and text external to the source, such as an .aspx file. If errors are encountered in the designated source code during compilation, they are identified as coming from the external source.  
  
 External source directives have no effect on compilation and cannot be nested. They are intended for internal use by the application only.  
  
## See Also  
 [Conditional Compilation in Visual Basic](../vs140/conditional-compilation-in-visual-basic.md)