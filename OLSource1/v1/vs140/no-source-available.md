---
title: "No Source Available"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vs.debug.nosource
dev_langs: 
  - FSharp
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - No Source Code Available for the Current Location dialog box
ms.assetid: ed0732bc-4b8c-490f-adb1-af06869a2a6b
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# No Source Available
Your project does not contain source code for the code that you are trying to view. The usual cause is double-clicking a module that does not have source code in the **Call Stack Window** or **Threads Window**. You can continue to debug, but cannot use the source window to set breakpoints and perform other actions at this location. If you need to set a breakpoint, use the **Disassembly Window** instead.  
  
 In the Solution Property Pages, you can change the directories where the debugger looks for sources files and tell the debugger to ignore selected source files. See [Debug Source Files, Common Properties, Solution Property Pages Dialog Box](../vs140/debug-source-files--common-properties--solution-property-pages-dialog-box.md).  
  
 **Browse to find source code**  
 Click this link to open a dialog box where you can browse to find the source code.  
  
 **Show Disassembly**  
 Launches the **Disassembly Window**.  
  
 **Always show disassembly for missing source files**  
 Select this option to display the **Disassembly Window** automatically when no source is available. This setting can also be changed in the **Options** dialog box, **Debugging** category, **General** page, by selecting or clearing **Show disassembly if source is not available**.  
  
## See Also  
 [Debug Source Files, Common Properties, Solution Property Pages Dialog Box](../vs140/debug-source-files--common-properties--solution-property-pages-dialog-box.md)   
 [Specify Symbol (.pdb) and Source Files in the Visual Studio Debugger](../vs140/specify-symbol--.pdb--and-source-files-in-the-visual-studio-debugger.md)   
 [SOS Debugging Extension (SOS.dll)](assetId:///9ac1b522-77ab-4cdc-852a-20fcdc9ae498)