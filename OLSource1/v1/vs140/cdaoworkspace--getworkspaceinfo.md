---
title: "CDaoWorkspace::GetWorkspaceInfo"
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
  - "CDaoWorkspace.GetWorkspaceInfo"
  - "CDaoWorkspace::GetWorkspaceInfo"
  - "GetWorkspaceInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AFX_DAO_ALL_INFO"
  - "Workspaces collection, getting information"
  - "workspaces [C++], getting information about"
  - "AFX_DAO_SECONDARY_INFO"
  - "DAO [C++], getting workspace information"
  - "GetWorkspaceInfo method"
  - "AFX_DAO_PRIMARY_INFO"
ms.assetid: 5a746165-c397-4904-90f9-1e6bb3fd6302
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::GetWorkspaceInfo
Call this member function to obtain various kinds of information about a workspace open in the session.  
  
## Syntax  
  
```  
  
      void GetWorkspaceInfo(   
   int nIndex,   
   CDaoWorkspaceInfo& wkspcinfo,   
   DWORD dwInfoOptions = AFX_DAO_PRIMARY_INFO    
);  
void GetWorkspaceInfo(   
   LPCTSTR lpszName,   
   CDaoWorkspaceInfo& wkspcinfo,   
   DWORD dwInfoOptions = AFX_DAO_PRIMARY_INFO    
);  
```  
  
#### Parameters  
 `nIndex`  
 The zero-based index of the database object in the Workspaces collection, for lookup by index.  
  
 `wkspcinfo`  
 A reference to a [CDaoWorkspaceInfo](../vs140/cdaoworkspaceinfo-structure.md) object that returns the information requested.  
  
 `dwInfoOptions`  
 Options that specify which information about the workspace to retrieve. The available options are listed here along with what they cause the function to return:  
  
-   `AFX_DAO_PRIMARY_INFO` (Default) Name  
  
-   `AFX_DAO_SECONDARY_INFO` Primary information plus: User Name  
  
-   `AFX_DAO_ALL_INFO` Primary and secondary information plus: Isolate ODBCTrans  
  
 `lpszName`  
 The name of the workspace object, for lookup by name. The name is a string with up to 14 characters that uniquely names the new workspace object.  
  
## Remarks  
 For a description of the information returned in `wkspcinfo`, see the [CDaoWorkspaceInfo](../vs140/cdaoworkspaceinfo-structure.md) structure. This structure has members that correspond to the items of information listed above in the description of `dwInfoOptions`. When you request information at one level, you get information for prior levels as well.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoWorkspace::GetWorkspaceCount](../vs140/cdaoworkspace--getworkspacecount.md)