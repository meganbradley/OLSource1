---
title: "spawn Constants"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "_P_NOWAIT"
  - "_P_OVERLAY"
  - "_P_WAIT"
  - "_P_DETACH"
  - "_P_NOWAITO"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_P_OVERLAY constant"
  - "P_DETACH constant"
  - "P_OVERLAY constant"
  - "P_NOWAIT constant"
  - "_P_DETACH constant"
  - "_P_NOWAIT constant"
  - "_P_NOWAITO constant"
  - "P_NOWAITO constant"
  - "spawn constants"
  - "P_WAIT constant"
  - "_P_WAIT constant"
ms.assetid: e0533e88-d362-46fc-b53c-5f193226d879
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# spawn Constants
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> argument determines the action taken by the calling process before and during a spawn operation. The following values for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> are possible:  
  
|Constant|Meaning|  
|--------------|-------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Overlays calling process with new process, destroying calling process (same effect as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> calls).|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Suspends calling thread until execution of new process is complete (synchronous <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Continues to execute calling process concurrently with new process (asynchronous <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Continues to execute calling process; new process is run in background with no access to console or keyboard. Calls to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> against new process will fail. This is an asynchronous <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
  
## See Also  
 [_spawn, _wspawn Functions](../vs140/_spawn--_wspawn-functions.md)   
 [Global Constants](../vs140/global-constants.md)