---
title: "How to: Relocate Instrumented Binaries"
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
  - "vs.performance.property.binaries"
helpviewer_keywords: 
  - "binaries, instrumented"
  - "instrumentation, instrumented binaries"
  - "instrumented binaries and relocating"
  - "profiling tools, instrumented binaries"
ms.assetid: 258f49e8-4b09-477e-a132-8fad685b66f4
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Relocate Instrumented Binaries
During instrumentation, probes are inserted into the binary to measure application performance. By choosing to relocate the instrumented binary, a copy of the original binary is instrumented and put in the specified location. This option is useful if you do not want the profiler to rename your original binary. If the binary is not relocated, the original version of the binary is overwritten.  
  
 **Requirements**  
  
-   [!INCLUDE[vsUltLong](../VS_csharp/includes/vsultlong_md.md)], [!INCLUDE[vsPreLong](../VS_csharp/includes/vsprelong_md.md)], [!INCLUDE[vsPro](../VS_csharp/includes/vspro_md.md)]  
  
### To relocate instrumented binary  
  
1.  In **Performance Explorer**, right-click the performance session, and then click **Properties**.  
  
2.  In the **Property Pages**, click the **Binary** properties.  
  
3.  Select the **Relocate instrumented binaries** check box.  
  
4.  Specify the location for the instrumented binary.  
  
## See Also  
 [Configuring Performance Sessions](../VS_csharp/configuring-performance-sessions.md)   
 [VSInstr](../VS_csharp/vsinstr.md)