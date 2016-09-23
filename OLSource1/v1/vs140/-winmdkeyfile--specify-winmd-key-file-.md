---
title: "-WINMDKEYFILE (Specify winmd Key File)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: /WINMDKEYFILE (Specify winmd Key File)
f1_keywords: 
  - VC.Project.VCLinkerTool.WINMDKeyFile
dev_langs: 
  - C++
ms.assetid: 65d88fdc-fff9-49ea-8cfc-b2f408741734
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -WINMDKEYFILE (Specify winmd Key File)
Specifies a key or a key pair to sign a Windows Runtime Metadata (.winmd) file.  
  
```  
/WINMDKEYFILE:filename  
```  
  
## Remarks  
 Resembles the [/KEYFILE](../vs140/-keyfile--specify-key-or-key-pair-to-sign-an-assembly-.md) linker option that is applied to a .winmd file.  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Working with Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Select the **Linker** folder.  
  
3.  Select the **Windows Metadata** property page.  
  
4.  In the **Windows Metadata Key File** box, enter the file location.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)