---
title: "IDebugComPlusSymbolProvider2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugComPlusSymbolProvider2 interface"
ms.assetid: fa2f9b49-03ad-43c7-92d6-6dcb9c3d0531
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugComPlusSymbolProvider2
Represents a COM+ symbol provider with methods that are specific to managed code and extends the **IDebugComPlusSymbolProvider**[](../vs140/idebugcomplussymbolprovider.md "IDebugComPlusSymbolProvider").  
  
## Syntax  
  
```  
IDebugComPlusSymbolProvider2 : IDebugComPlusSymbolProvider  
```  
  
## Methods  
 In addition to the methods on the [IDebugComPlusSymbolProvider](../vs140/idebugcomplussymbolprovider.md) interface, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugComPlusSymbolProvider2::FunctionHasLineInfo](../vs140/idebugcomplussymbolprovider2--functionhaslineinfo.md)|Determines if the specified method has line information.|  
|[IDebugComPlusSymbolProvider2::GetTypesByName](../vs140/idebugcomplussymbolprovider2--gettypesbyname.md)|Retrieves a type given its name.|  
|[IDebugComPlusSymbolProvider2::GetTypeFromToken](../vs140/idebugcomplussymbolprovider2--gettypefromtoken.md)|Retrieves a type given its token.|  
|[IDebugComPlusSymbolProvider2::IsAddressSequencePoint](../vs140/idebugcomplussymbolprovider2--isaddresssequencepoint.md)|Determines if the specified debug address is a sequence point.|  
|[IDebugComPlusSymbolProvider2::LoadSymbolsFromCallback](../vs140/idebugcomplussymbolprovider2--loadsymbolsfromcallback.md)|Loads debug symbols using the specified callback method.|  
|[IDebugComPlusSymbolProvider2::LoadSymbolsFromStreamWithCorModule](../vs140/idebugcomplussymbolprovider2--loadsymbolsfromstreamwithcormodule.md)|Load debug symbols from a data stream given the **ICorDebugModule** object.|  
|[IDebugComPlusSymbolProvider2::LoadSymbolsWithCorModule](../vs140/idebugcomplussymbolprovider2--loadsymbolswithcormodule.md)|Loads debug symbols given the **ICorDebugModule** object.|  
  
## Requirements  
 Header: Sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll