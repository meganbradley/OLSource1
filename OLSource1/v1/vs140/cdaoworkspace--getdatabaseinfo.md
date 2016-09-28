---
title: "CDaoWorkspace::GetDatabaseInfo"
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
  - "GetDatabaseInfo"
  - "CDaoWorkspace::GetDatabaseInfo"
  - "AFX_DAO_SECONDARY_INFO"
  - "AFX_DAO_ALL_INFO"
  - "CDaoWorkspace.GetDatabaseInfo"
  - "AFX_DAO_PRIMARY_INFO"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "databases [C++], getting information about"
  - "AFX_DAO_ALL_INFO"
  - "workspaces [C++], getting information about"
  - "AFX_DAO_SECONDARY_INFO"
  - "DAO [C++], getting workspace information"
  - "GetDatabaseInfo method"
  - "AFX_DAO_PRIMARY_INFO"
  - "Databases collection, getting information from"
ms.assetid: 172f71ff-2af2-463f-a0f2-d2a07b8d688e
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::GetDatabaseInfo
Call this member function to obtain various kinds of information about a database open in the workspace.  
  
## Syntax  
  
```  
  
      void GetDatabaseInfo(   
   int nIndex,   
   CDaoDatabaseInfo& dbinfo,   
   DWORD dwInfoOptions = AFX_DAO_PRIMARY_INFO    
);  
void GetDatabaseInfo(   
   LPCTSTR lpszName,   
   CDaoDatabaseInfo& dbinfo,   
   DWORD dwInfoOptions = AFX_DAO_PRIMARY_INFO    
);  
```  
  
#### Parameters  
 `nIndex`  
 The zero-based index of the database object in the workspace's Databases collection, for lookup by index.  
  
 `dbinfo`  
 A reference to a [CDaoDatabaseInfo](../vs140/cdaodatabaseinfo-structure.md) object that returns the information requested.  
  
 `dwInfoOptions`  
 Options that specify which information about the database to retrieve. The available options are listed here along with what they cause the function to return:  
  
-   `AFX_DAO_PRIMARY_INFO` (Default) Name, Updatable, Transactions  
  
-   `AFX_DAO_SECONDARY_INFO` Primary information plus: Version, Collating Order, Query Timeout  
  
-   `AFX_DAO_ALL_INFO` Primary and secondary information plus: Connect  
  
 `lpszName`  
 The name of the database object, for lookup by name. The name is a string with up to 14 characters that uniquely names the new workspace object.  
  
## Remarks  
 One version of the function lets you look up a database by index. The other version lets you look up a database by name.  
  
 For a description of the information returned in `dbinfo`, see the [CDaoDatabaseInfo](../vs140/cdaodatabaseinfo-structure.md) structure. This structure has members that correspond to the items of information listed above in the description of `dwInfoOptions`. When you request information at one level, you get information for any prior levels as well.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoWorkspace::GetDatabaseCount](../vs140/cdaoworkspace--getdatabasecount.md)