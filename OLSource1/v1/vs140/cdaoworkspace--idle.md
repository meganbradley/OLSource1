---
title: "CDaoWorkspace::Idle"
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
  - "CDaoWorkspace::Idle"
  - "Idle"
  - "CDaoWorkspace.Idle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "background processing [C++]"
  - "DAO [C++], idle processing"
  - "Idle method"
  - "workspaces [C++], idle processing"
  - "Jet [C++], background processing"
  - "database engine [C++], background processing"
  - "idle processing"
  - "dbFreeLocks constant"
ms.assetid: fd02647f-c0f0-4c55-a98c-c0d8a0b3a416
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::Idle
Call **Idle** to provide the database engine with the opportunity to perform background tasks that may not be up-to-date because of intense data processing.  
  
## Syntax  
  
```  
  
      static void PASCAL Idle(   
   int nAction = dbFreeLocks    
);  
```  
  
#### Parameters  
 `nAction`  
 An action to take during the idle processing. Currently the only valid action is **dbFreeLocks**.  
  
## Remarks  
 This is often true in multiuser, multitasking environments in which there is not enough background processing time to keep all records in a recordset current.  
  
> [!NOTE]
>  Calling **Idle** is not necessary with databases created with version 3.0 of the Microsoft Jet database engine. Use **Idle** only for databases created with earlier versions.  
  
 Usually, read locks are removed and data in local dynaset-type recordset objects is updated only when no other actions (including mouse movements) are occurring. If you periodically call **Idle**, you provide the database engine with time to catch up on background processing tasks by releasing unneeded read locks. Specifying the **dbFreeLocks** constant as an argument delays processing until all read locks are released.  
  
 This member function is not needed in single-user environments unless multiple instances of an application are running. The **Idle** member function may increase performance in a multiuser environment because it forces the database engine to flush data to disk, releasing locks on memory. You can also release read locks by making operations part of a transaction.  
  
 For related information, see the topic "Idle Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)