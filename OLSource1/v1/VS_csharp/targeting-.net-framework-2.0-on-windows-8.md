---
title: "Targeting .NET Framework 2.0 on Windows 8"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
ms.assetid: 0db6510f-9d4e-4e49-9200-c25ada84c86c
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Targeting .NET Framework 2.0 on Windows 8
The following error might appear if you try to target the .NET Framework 2.0, 3.0, or 3.5 in an F# project when Visual Studio is installed on [!INCLUDE[win8](../VS_csharp/includes/win8_md.md)]: **This project requires the 2.0 F# runtime, but that runtime is not installed.** This error is known to occur under the following combination of conditions:  
  
-   You installed Visual Studio on [!INCLUDE[win8](../VS_csharp/includes/win8_md.md)].  
  
-   You didn’t enable the .NET Framework 3.5 before you installed Visual Studio.  
  
-   Your project targets the .NET Framework 2.0, 3.0, or 3.5.  
  
 When you install Visual Studio, it detects the installed versions of the .NET Framework and installs the F# 2.0 Runtime only if the .NET Framework 3.5 is installed and enabled.  
  
## Resolving the Error  
 To resolve this error, you can either target a newer version of the .NET Framework, or you can enable the .NET Framework 3.5 on [!INCLUDE[win8](../VS_csharp/includes/win8_md.md)] and then install the F# 2.0 runtime by running the setup program for Visual Studio with the **Repair** option.  
  
#### To enable the .NET Framework 3.5 on [!INCLUDE[win8](../VS_csharp/includes/win8_md.md)]  
  
1.  On the **Start** screen, start to enter `Control Panel`.  
  
     As you enter that name, the **Control Panel** icon appears under the **Apps** heading.  
  
2.  Choose the **Control Panel** icon, choose the **Programs** icon, and then choose the **Turn Windows features on or off** link.  
  
3.  Make sure that the **.NET Framework 3.5 (includes .NET 2.0 and 3.0)** check box is selected, and then choose the **OK** button.  
  
     You don’t need to select the check boxes for any child nodes for optional components of the .NET Framework.  
  
     The .NET Framework 3.5 is enabled if it wasn't already.  
  
#### To install the F# 2.0 runtime  
  
1.  In the Control Panel, choose the **Programs** link, and then choose the **Programs and Features** link.  
  
2.  In the list of installed programs, choose the edition of Visual Studio that you installed, and then choose the **Change** button.  
  
3.  After setup starts, choose the **Repair** button.  
  
     For more information, see [Installing Visual Studio](../VS_csharp/installing-visual-studio-2015.md).  
  
## See Also  
 [Visual F#](../VS_csharp/visual-fsharp.md)