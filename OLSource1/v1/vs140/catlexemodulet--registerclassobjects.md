---
title: "CAtlExeModuleT::RegisterClassObjects"
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
  - "ATL::CAtlExeModuleT<T>::RegisterClassObjects"
  - "ATL::CAtlExeModuleT::RegisterClassObjects"
  - "CAtlExeModuleT.RegisterClassObjects"
  - "RegisterClassObjects"
  - "CAtlExeModuleT::RegisterClassObjects"
  - "ATL.CAtlExeModuleT.RegisterClassObjects"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RegisterClassObjects method"
ms.assetid: 1bf8b4c2-b827-4018-bb8b-799c7954d365
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlExeModuleT::RegisterClassObjects
Registers the class object with OLE so other applications can connect to it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *dwClsContext*  
 Specifies the context in which the class object is to be run. Possible values are CLSCTX_INPROC_SERVER, CLSCTX_INPROC_HANDLER, or CLSCTX_LOCAL_SERVER.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Determines the connection types to the class object. Possible values are REGCLS_SINGLEUSE, REGCLS_MULTIPLEUSE, or REGCLS_MULTI_SEPARATE.  
  
## Return Value  
 Returns S_OK on success, S_FALSE if there were no classes to register, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlExeModuleT Class](../vs140/catlexemodulet-class.md)   
 [CLSCTX](http://msdn.microsoft.com/library/windows/desktop/ms693716)   
 [REGCLS](http://msdn.microsoft.com/library/windows/desktop/ms679697)   
 [CAtlExeModuleT::RevokeClassObjects](../vs140/catlexemodulet--revokeclassobjects.md)