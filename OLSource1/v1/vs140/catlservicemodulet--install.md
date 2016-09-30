---
title: "CAtlServiceModuleT::Install"
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
  - "ATL.CAtlServiceModuleT.Install"
  - "CAtlServiceModuleT.Install"
  - "ATL::CAtlServiceModuleT::Install"
  - "Install"
  - "CAtlServiceModuleT::Install"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Install method"
ms.assetid: 9bbbf339-d387-4ceb-9c5b-fd8d9db19a63
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlServiceModuleT::Install
Installs and creates the service.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns TRUE on success, FALSE on failure.  
  
## Remarks  
 Installs the service into the Service Control Manager (SCM) database and then creates the service object. If the service could not be created, a message box is displayed and the method returns FALSE.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlServiceModuleT Class](../vs140/catlservicemodulet-class.md)   
 [CreateService](http://msdn.microsoft.com/library/windows/desktop/ms682450)   
 [CAtlServiceModuleT::Uninstall](../vs140/catlservicemodulet--uninstall.md)