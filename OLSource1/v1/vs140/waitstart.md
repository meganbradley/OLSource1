---
title: "WaitStart"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 6c737177-2dfb-4150-963e-a49ac9aaa591
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WaitStart
The WaitStart option causes the VSPerfCmd.exe Start sub-command to return only when the profiler has initialized or when the specified number of seconds has passed. By default, the Start command returns immediately. If the Start sub command returns without initializing the profiler, an error is returned. If the number of seconds is not specified, the Start command waits indefinitely.  
  
 The WaitStart option is useful in batch files to insure that profiler has been initialized.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of seconds to wait before returning from the Start sub-command.  
  
## Required Options  
 The WaitStart option can only be used with the Start sub-command.  
  
 **Output:** <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the output file name.  
  
## Remarks  
  
## Example  
 In this batch file example, the Start command will wait for 5 seconds for the profiler to initialize.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>