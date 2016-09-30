---
title: "AtlComModuleRegisterClassObjects"
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
  - "ATL.AtlComModuleRegisterClassObjects"
  - "ATL::AtlComModuleRegisterClassObjects"
  - "AtlComModuleRegisterClassObjects"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlComModuleRegisterClassObjects function"
ms.assetid: 031ae876-030f-49f9-80b2-6817ea5befe4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlComModuleRegisterClassObjects
This function is called to register class objects.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the COM module.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the context in which the class object is to be run. Possible values are CLSCTX_INPROC_SERVER, CLSCTX_INPROC_HANDLER, or CLSCTX_LOCAL_SERVER. See [CLSCTX](http://msdn.microsoft.com/library/windows/desktop/ms693716) for more details.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Determines the connection types to the class object. Possible values are REGCLS_SINGLEUSE, REGCLS_MULTIPLEUSE, or REGCLS_MULTI_SEPARATE. See [REGCLS](http://msdn.microsoft.com/library/windows/desktop/ms679697) for more details.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This helper function is utilized by [CComModule::RegisterClassObjects](../vs140/ccommodule--registerclassobjects.md) (obsolete in ATL 7.0) and [CAtlExeModuleT::RegisterClassObjects](../vs140/catlexemodulet--registerclassobjects.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Server Registration Global Functions](../vs140/server-registration-global-functions.md)