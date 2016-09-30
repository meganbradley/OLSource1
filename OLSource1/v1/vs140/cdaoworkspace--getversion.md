---
title: "CDaoWorkspace::GetVersion"
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
  - "CDaoWorkspace::GetVersion"
  - "GetVersion"
  - "CDaoWorkspace.GetVersion"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "version information [C++], Jet database engine"
  - "Jet [C++], version"
  - "workspaces [C++], getting information about"
  - "GetVersion method"
  - "DAO [C++], getting Jet engine version"
ms.assetid: 111461d3-9e3b-4348-acb3-15ae8731372f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::GetVersion
Call this member function to determine the version of the Microsoft Jet database engine in use.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A [CString](../vs140/cstringt-class.md) that indicates the version of the database engine associated with the object.  
  
## Remarks  
 The value returned represents the version number in the form "major.minor"; for example, "3.0". The product version number (for example, 3.0) consists of the version number (3), a period, and the release number (0).  
  
 For related information, see the topic "Version Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoDatabase::GetVersion](../vs140/cdaodatabase--getversion.md)