---
title: "CAtlComModule::RegisterServer"
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
  - "ATL::CAtlComModule::RegisterServer"
  - "ATL.CAtlComModule.RegisterServer"
  - "CAtlComModule.RegisterServer"
  - "CAtlComModule::RegisterServer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RegisterServer method"
ms.assetid: dd64994c-c820-4992-9b17-b8bd2dedd496
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlComModule::RegisterServer
Call this method to update the system registry for each object in the object map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 TRUE if the type library is to be registered. The default value is FALSE.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to the CLSID of the object to be registered. If NULL (the default value), all objects in the object map will be registered.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 Calls the global function [AtlComModuleRegisterServer](../vs140/atlcommoduleregisterserver.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlComModule Class](../vs140/catlcommodule-class.md)   
 [CAtlComModule::UnregisterServer](../vs140/catlcommodule--unregisterserver.md)