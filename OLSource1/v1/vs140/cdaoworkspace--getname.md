---
title: "CDaoWorkspace::GetName"
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
  - "GetName"
  - "CDaoWorkspace.GetName"
  - "CDaoWorkspace::GetName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "names [C++], workspace"
  - "GetName method"
  - "workspaces [C++], getting information about"
  - "DAO [C++], getting workspace information"
ms.assetid: 2fa809f4-8b33-40db-a982-b6edcc8fee53
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::GetName
Call this member function to get the user-defined name of the DAO workspace object underlying the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A [CString](../vs140/cstringt-class.md) containing the user-defined name of the DAO workspace object.  
  
## Remarks  
 The name is useful for accessing the DAO workspace object in the database engine's Workspaces collection by name.  
  
 For related information, see the topic "Name Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)