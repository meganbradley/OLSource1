---
title: "An invalid name was specified for the event log"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: b1b158bd-f13f-4371-a8af-31c0e86ae6be
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# An invalid name was specified for the event log
An invalid name was specified for the event log. Usually this is a result of invalid characters in the name, a blank file name, or a file name that is too long.  
  
### To correct this error  
  
-   If the specified name is more than eight characters, make sure there is no conflict with the names of other event logs. Only the first eight characters are evaluated when determining if the name is unique.  
  
-   If supplying a path, make sure it is parsed correctly.  
  
-   Check that there are no invalid characters in the name. Characters that cannot be used in a file name include `<`, `>`, `:`, `"`, `/`, `\`, and `|`.  
  
## See Also  
 [How to: Parse File Paths in Visual Basic](../vs140/how-to--parse-file-paths-in-visual-basic.md)   
 [How to: Rename a File in Visual Basic](../vs140/how-to--rename-a-file-in-visual-basic.md)   
 [How to: Create and Remove Custom Event Logs](assetId:///af9b7da0-80c7-46ac-b7f7-897063ddd503)