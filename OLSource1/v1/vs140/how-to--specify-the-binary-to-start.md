---
title: "How to: Specify the Binary to Start"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.performance.property.itemlaunch"
helpviewer_keywords: 
  - "profiling tools, launching"
  - "performance tools, launching"
  - "performance sessions, launching"
ms.assetid: ba77fcf4-8d78-49f1-b8f3-7dd0acf84306
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Specify the Binary to Start
To profile binaries, such as DLLs, you must enter information in the **\<Target> Property Pages** dialog box. This information indicates where the DLL project can find the calling application.  
  
 **Requirements**  
  
-   [!INCLUDE[vsUltLong](../vs140/includes/vsultlong_md.md)], [!INCLUDE[vsPreLong](../vs140/includes/vsprelong_md.md)], [!INCLUDE[vsPro](../vs140/includes/vspro_md.md)]  
  
### To specify the executable to start  
  
1.  In **Performance Explorer**, right-click the target binary, and then click **Properties**.  
  
2.  In the **Property Pages** dialog box, click the **Launch** properties.  
  
3.  Select the **Override project properties** check box.  
  
4.  In the **Executable to launch** text box, specify the file location.  
  
5.  In the **Arguments** text box, specify arguments that are required to start the application.  
  
6.  In the **Working directory** text box, specify the directory location.  
  
7.  Click **OK**.  
  
## See Also  
 [Configuring Performance Sessions](../vs140/configuring-performance-sessions.md)