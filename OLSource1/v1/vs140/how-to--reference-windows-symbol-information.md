---
title: "How to: Reference Windows Symbol Information"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "performance tools, symbol servers"
  - "servers, symbol servers"
  - "profiling tools, symbol servers"
  - "symbol servers"
ms.assetid: b7c67318-6be2-4b1e-a161-077b1f4a7c30
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Reference Windows Symbol Information
The Visual Studio Profiling Tools use symbol (.pdb) files to resolve symbolic names such as function names in program binaries. You can follow these steps to automatically download and update the correct .pdb files for the version of Windows on the local computer.  
  
> [!NOTE]
>  This setting does not affect existing reports. Only reports created after specifying the symbol server will have the symbol information.  
  
 For more information, see [Managing Symbols and Source Code](../vs140/specify-symbol--.pdb--and-source-files-in-the-visual-studio-debugger.md).  
  
### To use the Microsoft symbol server  
  
1.  Create a folder to contain the symbol file information, such as C:\SymbolCache.  
  
2.  On the **Tools** menu, click **Options**.  
  
     The **Options** dialog box appears.  
  
3.  Expand the **Debugging** tree, and then click **Symbols**.  
  
4.  In the **Symbol file (.pdb) locations**, select **Microsoft Symbol Servers**  
  
5.  In the **Cache symbols from the symbol server to this directory**, type the path of the folder that was created in step 1, for example:  
  
     **C:\SymbolCache**  
  
     You can also click the ellipsis button (**...**) and then select a directory from the **Browse for Folder** dialog box.  
  
## See Also  
 [Configuring Performance Sessions](../vs140/configuring-performance-sessions.md)   
 [How to: Serialize Symbol Information](../vs140/how-to--serialize-symbol-information.md)