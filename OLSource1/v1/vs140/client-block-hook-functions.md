---
title: "Client Block Hook Functions"
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
  - "vs.debug.hooks"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "client blocks, validating and reporting data"
  - "debugging [C++], hook functions"
  - "_CrtSetDumpClient function"
  - "client blocks, hook functions"
  - "hooks, client block"
ms.assetid: f21c197e-565d-4e3f-9b27-4c018c9b87fc
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Client Block Hook Functions
If you want to validate or report the contents of the data stored in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> blocks, you can write a function specifically for this purpose. The function that you write must have a prototype similar to the following, as defined in CRTDBG.H:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In other words, your hook function should accept a **void** pointer to the beginning of the allocation block, together with a **size_t** type value indicating the size of the allocation, and return <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Other than that, its contents are up to you.  
  
 Once you have installed your hook function using [_CrtSetDumpClient](../vs140/_crtsetdumpclient.md), it will be called every time a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> block is dumped. You can then use [_CrtReportBlockType](../vs140/_crtreportblocktype.md) to get information on the type or subtype of dumped blocks.  
  
 The pointer to your function that you pass to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is of type **_CRT_DUMP_CLIENT**, as defined in CRTDBG.H:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Debug Hook Function Writing](../vs140/debug-hook-function-writing.md)   
 [crt_dbg2 Sample](assetId:///21e1346a-6a17-4f57-b275-c76813089167)   
 [_CrtReportBlockType](../vs140/_crtreportblocktype.md)