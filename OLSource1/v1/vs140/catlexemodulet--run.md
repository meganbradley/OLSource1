---
title: "CAtlExeModuleT::Run"
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
  - "CAtlExeModuleT<T>::Run"
  - "CAtlExeModuleT<T>.Run"
  - "CAtlExeModuleT.Run"
  - "ATL.CAtlExeModuleT<T>.Run"
  - "ATL::CAtlExeModuleT::Run"
  - "ATL.CAtlExeModuleT.Run"
  - "ATL::CAtlExeModuleT<T>::Run"
  - "CAtlExeModuleT::Run"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Run method"
ms.assetid: dbf55f9e-a128-47ab-8e57-49f209148e65
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlExeModuleT::Run
This method executes code in the EXE module to initialize, run the message loop, and clean up.  
  
## Syntax  
  
```  
  
      HRESULT Run(  
   int nShowCmd = SW_HIDE   
) throw( );  
```  
  
#### Parameters  
 `nShowCmd`  
 Specifies how the window is to be shown. This parameter can be one of the values discussed in the [WinMain](http://msdn.microsoft.com/library/windows/desktop/ms633559) section. Defaults to SW_HIDE.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method can be overridden. However, in practice is it better to override [CAtlExeModuleT::PreMessageLoop](../vs140/catlexemodulet--premessageloop.md), [CAtlExeModuleT::RunMessageLoop](../vs140/catlexemodulet--runmessageloop.md), or [CAtlExeModuleT::PostMessageLoop](../vs140/catlexemodulet--postmessageloop.md) instead.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlExeModuleT Class](../vs140/catlexemodulet-class.md)