---
title: "Encoding cannot be set to Nothing"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 59f7c731-8291-4a85-bf51-c225e48cdc84
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Encoding cannot be set to Nothing
An attempt to read from or write to a file has failed because the parameter `encoding` has been set to `Nothing` but requires a valid value.  
  
 <xref:System.Text.Encoding*> is used to determine what encoding to use when writing to a file. The default is UTF-8.  
  
### To correct this error  
  
-   Supply a valid value for the `encoding` parameter.  
  
## See Also  
 [File Encodings](../vs140/file-encodings--visual-basic-.md)   
 [Reading from Files in Visual Basic](../vs140/reading-from-files-in-visual-basic.md)   
 [Writing to Files in Visual Basic](../vs140/writing-to-files-in-visual-basic.md)   
 [My.Computer.FileSystem.ReadAllText Method](assetId:///3a7ac8be-fb1d-4087-bc65-167d6754d57f)   
 [My.Computer.FileSystem.WriteAllText Method](assetId:///f507460c-87d9-4504-b74f-3ff825c7d5c4)