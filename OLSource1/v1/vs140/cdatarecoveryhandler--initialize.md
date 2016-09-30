---
title: "CDataRecoveryHandler::Initialize"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CDataRecoveryHandler::Initialize"
  - "CDataRecoveryHandler.Initialize"
  - "Initialize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Initialize method"
ms.assetid: d31df588-3806-4345-b906-828f7e2b586e
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::Initialize
Initializes the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the initialization is successful; otherwise <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 The initialization process loads the path for storing autosave files from the registry. If the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method cannot find this directory or if the path is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> fails and returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 Use [CDataRecoveryHandler::SetAutosavePath](../vs140/cdatarecoveryhandler--setautosavepath.md) to change the autosave path after your application initializes the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method also starts a timer to monitor when the next autosave occurs. Use [CDataRecoveryHandler::SetAutosaveInterval](../vs140/cdatarecoveryhandler--setautosaveinterval.md) to change the autosave interval after your application initializes the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::SetAutosavePath](../vs140/cdatarecoveryhandler--setautosavepath.md)   
 [CDataRecoveryHandler::SetAutosaveInterval](../vs140/cdatarecoveryhandler--setautosaveinterval.md)