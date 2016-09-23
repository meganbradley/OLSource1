---
title: "CDaoWorkspace::GetIniPath"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - GetIniPath
  - CDaoWorkspace::GetIniPath
  - CDaoWorkspace.GetIniPath
dev_langs: 
  - C++
helpviewer_keywords: 
  - DAO (Data Access Objects), getting workspace information
  - Jet, INI file
  - GetIniPath method
  - DAO (Data Access Objects), INI paths
  - IniPath property
  - paths, getting MS Jet INI file
ms.assetid: ff969872-abc1-4aec-ac6a-37e49bd7eca2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoWorkspace::GetIniPath
Call this member function to obtain the location of the Microsoft Jet database engine's initialization settings in the Windows registry.  
  
## Syntax  
  
```  
  
static CString PASCAL GetIniPath( );  
  
```  
  
## Return Value  
 A [CString](../vs140/cstringt-class.md) containing the registry location.  
  
## Remarks  
 You can use the location to obtain information about settings for the database engine. The information returned is actually the name of a registry subkey.  
  
 For related information, see the topics "IniPath Property" and "Customizing Windows Registry Settings for Data Access" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoWorkspace::SetIniPath](../vs140/cdaoworkspace--setinipath.md)   
 [CDaoWorkspace::GetVersion](../vs140/cdaoworkspace--getversion.md)