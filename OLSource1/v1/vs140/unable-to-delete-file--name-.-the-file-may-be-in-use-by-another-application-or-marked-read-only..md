---
title: "Unable to delete file &lt;name&gt;. The file may be in use by another application or marked read-only."
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vs.message.VB_E_DELETEFILEFAILED
  - vs.message.0x800A00A2
ms.assetid: 5c425dca-1d28-47a8-a11c-6a890be10baf
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Unable to delete file &lt;name&gt;. The file may be in use by another application or marked read-only.
This error generally occurs when the keyboard scheme selected to be deleted is either in use or is read-only.  
  
### To correct this error  
  
1.  If another application is using the specified file, close that application  
  
     —or—  
  
     If the file is read-only, remove the read-only attribute. You can modify the read-only attribute in the Properties dialog box for the file, available in File Explorer.  
  
## See Also  
 [How to: Work with Shortcut Key Combinations](../vs140/identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md)