---
title: "CAtlServiceModuleT::Run"
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
  - ATL::CAtlServiceModuleT::Run
  - ATL.CAtlServiceModuleT.Run
  - CAtlServiceModuleT.Run
  - CAtlServiceModuleT::Run
dev_langs: 
  - C++
helpviewer_keywords: 
  - Run method
ms.assetid: b4f8d570-d81b-4c57-b5d6-8308c70df0d7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlServiceModuleT::Run
Runs the service.  
  
## Syntax  
  
```  
  
      HRESULT Run(  
   int nShowCmd = SW_HIDE   
) throw( );  
```  
  
#### Parameters  
 `nShowCmd`  
 Specifies how the window is to be shown. This parameter can be one of the values discussed in the [WinMain](http://msdn.microsoft.com/library/windows/desktop/ms633559) section. The default value is SW_HIDE.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 After being called, **Run** calls [CAtlServiceModuleT::PreMessageLoop](../vs140/catlservicemodulet--premessageloop.md), [CAtlExeModuleT::RunMessageLoop](../vs140/catlexemodulet--runmessageloop.md), and [CAtlExeModuleT::PostMessageLoop](../vs140/catlexemodulet--postmessageloop.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlServiceModuleT Class](../vs140/catlservicemodulet-class.md)