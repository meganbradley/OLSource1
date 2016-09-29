---
title: "CDaoDatabase::GetVersion"
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
  - "CDaoDatabase::GetVersion"
  - "GetVersion"
  - "CDaoDatabase.GetVersion"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "version information [C++], Jet database engine"
  - "Jet [C++], version"
  - "engine [C++], getting version of Jet"
  - "databases [C++], getting Jet engine version"
  - "GetVersion method"
  - "engine [C++]"
  - "DAO [C++], getting Jet engine version"
ms.assetid: f31a2b78-7fc0-430b-9617-dc13ce75dc99
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoDatabase::GetVersion
Call this member function to determine the version of the Microsoft Jet database file.  
  
## Syntax  
  
```  
  
CString GetVersion( );  
  
```  
  
## Return Value  
 A [CString](../vs140/cstringt-class.md) that indicates the version of the database file associated with the object.  
  
## Remarks  
 The value returned represents the version number in the form "major.minor"; for example, "3.0". The product version number (for example, 3.0) consists of the version number (3), a period, and the release number (0). The versions to date are 1.0, 1.1, 2.0, and 3.0.  
  
 For related information, see the topic "Version Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)