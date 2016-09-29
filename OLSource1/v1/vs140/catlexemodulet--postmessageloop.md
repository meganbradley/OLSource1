---
title: "CAtlExeModuleT::PostMessageLoop"
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
  - "PostMessageLoop"
  - "CAtlExeModuleT.PostMessageLoop"
  - "CAtlExeModuleT::PostMessageLoop"
  - "ATL::CAtlExeModuleT::PostMessageLoop"
  - "ATL::CAtlExeModuleT<T>::PostMessageLoop"
  - "ATL.CAtlExeModuleT.PostMessageLoop"
  - "CAtlExeModuleT<T>::PostMessageLoop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PostMessageLoop method"
ms.assetid: 8badf726-ad2a-41c4-8b8c-5c52fb7c7fc3
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlExeModuleT::PostMessageLoop
This method is called immediately after the message loop exits.  
  
## Syntax  
  
```  
  
HRESULT PostMessageLoop( ) throw( );  
  
```  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 Override this method to perform custom application cleanup. The default implementation calls [CAtlExeModuleT::RevokeClassObjects](../vs140/catlexemodulet--revokeclassobjects.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlExeModuleT Class](../vs140/catlexemodulet-class.md)   
 [CAtlExeModuleT::PreMessageLoop](../vs140/catlexemodulet--premessageloop.md)