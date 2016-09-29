---
title: "DA0008: Few samples collected"
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
  - "vs.performance.rules.DATooFewSamples"
  - "vs.performance.8"
  - "vs.performance.DA0008"
  - "vs.performance.rules.DA0008"
ms.assetid: 8a5b78aa-7b3d-476c-a47d-abfaff3fae7c
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DA0008: Few samples collected
|||  
|-|-|  
|Rule Id|DA0008|  
|Category|Profiling Tools Usage|  
|Profiling method|Sampling|  
|Message|Only just a few samples were collected. Consider a longer run or faster sampling rate for more significant results.|  
|Rule type|Information|  
  
## Cause  
 Just a few samples were collected in the profiling run.  
  
## Rule Description  
 When the sampling method is used, you should collect a statistically significant number of samples to make sure that the data represent actual program behavior. To minimize sampling errors, you should try to collect at least 1000 samples of program instruction execution behavior. If you do not collect enough samples, you can be misled when you analyze the profiling data.  
  
## How to Fix Violations  
 Consider a profiling a longer run of the application or using a faster sampling rate to obtain statistically significant results. For information about how to change the sampling rate in the Visual Studio IDE, see [How to: Choose Sampling Events](../vs140/how-to--choose-sampling-events.md). For more information about how to change the sampling rate when you use the Profiling Tools command line, see [Timer](../vs140/timer.md) in the [VSPerfCmd](../vs140/vsperfcmd.md) reference.