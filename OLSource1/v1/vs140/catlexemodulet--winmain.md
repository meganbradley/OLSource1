---
title: "CAtlExeModuleT::WinMain"
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
  - "ATL::CAtlExeModuleT::WinMain"
  - "CAtlExeModuleT<T>::WinMain"
  - "ATL.CAtlExeModuleT.WinMain"
  - "CAtlExeModuleT::WinMain"
  - "ATL::CAtlExeModuleT<T>::WinMain"
  - "ATL.CAtlExeModuleT<T>.WinMain"
  - "WinMain"
  - "CAtlExeModuleT<T>.WinMain"
  - "CAtlExeModuleT.WinMain"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WinMain method, running exes"
  - "WinMain method"
ms.assetid: a4525dd5-fa67-420a-9603-709ae50b0381
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlExeModuleT::WinMain
This method implements the code required to run an EXE.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies how the window is to be shown. This parameter can be one of the values discussed in the [WinMain](http://msdn.microsoft.com/library/windows/desktop/ms633559) section.  
  
## Return Value  
 Returns the executable's return value.  
  
## Remarks  
 This method can be overridden. If overriding [CAtlExeModuleT::PreMessageLoop](../vs140/catlexemodulet--premessageloop.md), [CAtlExeModuleT::PostMessageLoop](../vs140/catlexemodulet--postmessageloop.md), or [CAtlExeModuleT::RunMessageLoop](../vs140/catlexemodulet--runmessageloop.md) doesn't provide enough flexibility, it's possible to override the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function using this method.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlExeModuleT Class](../vs140/catlexemodulet-class.md)   
 [WinMain](http://msdn.microsoft.com/library/windows/desktop/ms633559)