---
title: "Argument BasePath must be a path to a folder"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: b180ce60-ad57-41a6-a313-491d86d84cc7
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Argument BasePath must be a path to a folder
The argument `BasePath` must consist of a path to a folder. You may be parsing a string incorrectly and supplying a value that is not recognized as a valid path.  
  
### To correct this error  
  
-   Check the value you are supplying for `BasePath` to make sure it is a valid path to a folder.  
  
## See Also  
 <xref:System.CodeDom.Compiler.TempFileCollection.BasePath*>   
 <xref:System.Resources.ResXResourceWriter.BasePath*>   
 <xref:System.Resources.ResXResourceReader.BasePath*>   
 [How to: Parse File Paths in Visual Basic](../vs140/how-to--parse-file-paths-in-visual-basic.md)