---
title: "_WAIT_CHILD, _WAIT_GRANDCHILD"
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
  - "_WAIT_GRANDCHILD"
  - "WAIT_CHILD"
  - "WAIT_GRANDCHILD"
  - "_WAIT_CHILD"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "WAIT_CHILD constant"
  - "WAIT_GRANDCHILD constant"
  - "_WAIT_CHILD constant"
  - "_WAIT_GRANDCHILD constant"
ms.assetid: 7acd96fa-d118-4339-bb00-e5afaf286945
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _WAIT_CHILD, _WAIT_GRANDCHILD
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function can be used by any process to wait for any other process (if the process ID is known). The action argument can be one of the following values:  
  
|Constant|Meaning|  
|--------------|-------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Calling process waits until specified new process terminates.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Calling process waits until specified new process, and all processes created by that new process, terminate.|  
  
## See Also  
 [_cwait](../vs140/_cwait.md)   
 [Global Constants](../vs140/global-constants.md)