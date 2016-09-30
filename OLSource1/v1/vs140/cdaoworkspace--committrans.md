---
title: "CDaoWorkspace::CommitTrans"
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
  - "CommitTrans"
  - "CDaoWorkspace.CommitTrans"
  - "CDaoWorkspace::CommitTrans"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "transactions [C++], committing"
  - "workspaces [C++], committing transactions"
  - "DAO [C++], transactions"
  - "CommitTrans method"
ms.assetid: b10883a1-93c8-4ffb-a361-747d1a0d4ea3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::CommitTrans
Call this member function to commit a transaction — save a group of edits and updates to one or more databases in the workspace.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A transaction consists of a series of changes to the database's data or its structure, beginning with a call to [BeginTrans](../vs140/cdaoworkspace--begintrans.md). When you complete the transaction, either commit it or roll it back (cancel the changes) with [Rollback](../vs140/cdaoworkspace--rollback.md). By default, without transactions, updates to records are committed immediately. Calling **BeginTrans** causes commitment of updates to be delayed until you call **CommitTrans**.  
  
> [!CAUTION]
>  Within one workspace, transactions are always global to the workspace and are not limited to only one database or recordset. If you perform operations on more than one database or recordset within a workspace transaction, **CommitTrans** commits all pending updates, and **Rollback** restores all operations on those databases and recordsets.  
  
 When you close a database or workspace with pending transactions, the transactions are all rolled back.  
  
> [!NOTE]
>  This is not a two-phase commit mechanism. If one update fails to commit, others still will commit.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)