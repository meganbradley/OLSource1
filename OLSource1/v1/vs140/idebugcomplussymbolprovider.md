---
title: "IDebugComPlusSymbolProvider"
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
  - "IDebugComPlusSymbolProvider interface"
ms.assetid: 5b98e908-fd15-49a6-9010-933c9b948085
caps.latest.revision: 13
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugComPlusSymbolProvider
Represents a COM+ symbol provider with methods that are specific to managed code.  
  
## Syntax  
  
```  
IDebugComPlusSymbolProvider : IDebugSymbolProvider  
```  
  
## Notes for Implementers  
 Although there is no separation between interfaces that are useful to an expression evaluator (EE) and those that are intended to be used by a debug engine (DE), the following methods will probably interest DE developers only: AreSymbolsLoaded, GetAddressesInModuleFromPosition, GetEntryPoint, GetFunctionLineOffset, GetLocalVariableLayout, IsFunctionStale, LoadSymbols, LoadSymbolsFromStream, ReplaceSymbols, UnloadSymbols, and UpdateSymbols.  
  
## Methods  
 In addition to the methods on the [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md) interface, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugComPlusSymbolProvider::AreSymbolsLoaded](../vs140/idebugcomplussymbolprovider--aresymbolsloaded.md)|Determines if the debug symbols are loaded for the specified module given the application domain identifier.|  
|[IDebugComPlusSymbolProvider::CreateTypeFromPrimitive](../vs140/idebugcomplussymbolprovider--createtypefromprimitive.md)|Creates a type from the specified primitive type.|  
|[IDebugComPlusSymbolProvider::GetAddressesInModuleFromPosition](../vs140/idebugcomplussymbolprovider--getaddressesinmodulefromposition.md)|Maps a document position in the specified module to an array of debug addresses.|  
|[IDebugComPlusSymbolProvider::GetArrayTypeFromAddress](../vs140/idebugcomplussymbolprovider--getarraytypefromaddress.md)|Retrieves type information about the specified array given its debug address.|  
|[IDebugComPlusSymbolProvider::GetAssemblyName](../vs140/idebugcomplussymbolprovider--getassemblyname.md)|Retrieves the name of the assembly given its module and application domain.|  
|[IDebugComPlusSymbolProvider::GetAttributedClassesForLanguage](../vs140/idebugcomplussymbolprovider--getattributedclassesforlanguage.md)|Retrieves the classes with the specified attribute that are implemented in the given programming language.|  
|[IDebugComPlusSymbolProvider::GetAttributedClassesinModule](../vs140/idebugcomplussymbolprovider--getattributedclassesinmodule.md)|Retrieves the classes with the specified attribute in a given module.|  
|[IDebugComPlusSymbolProvider::GetEntryPoint](../vs140/idebugcomplussymbolprovider--getentrypoint.md)|Retrieves the application entry point.|  
|[IDebugComPlusSymbolProvider::GetFunctionLineOffset](../vs140/idebugcomplussymbolprovider--getfunctionlineoffset.md)|Retrieves the address within a function that represents the given line offset.|  
|[IDebugComPlusSymbolProvider::GetLocalVariablelayout](../vs140/idebugcomplussymbolprovider--getlocalvariablelayout.md)|Retrieves the layout of local variables for a set of methods.|  
|[IDebugComPlusSymbolProvider::GetNameFromToken](../vs140/idebugcomplussymbolprovider--getnamefromtoken.md)|Returns the name associated with the specified token given its metadata object.|  
|[IDebugComPlusSymbolProvider::GetSymAttribute](../vs140/idebugcomplussymbolprovider--getsymattribute.md)|Retrieves the debug symbols with the given parent attribute for the specified module.|  
|[IDebugComPlusSymbolProvider::GetSymUnmanagedReader](../vs140/idebugcomplussymbolprovider--getsymunmanagedreader.md)|Retrieves the symbol reader to be used by unmanaged code.|  
|[IDebugComPlusSymbolProvider::GetTypeFromAddress](../vs140/idebugcomplussymbolprovider--gettypefromaddress.md)|Retrieves to a symbol type given its debug address.|  
|[IDebugComPlusSymbolProvider::IsFunctionDeleted](../vs140/idebugcomplussymbolprovider--isfunctiondeleted.md)|Determines if the function at the specified debug address is deleted.|  
|[IDebugComPlusSymbolProvider::IsFunctionStale](../vs140/idebugcomplussymbolprovider--isfunctionstale.md)|Determines if the function at the specified debug address is considered stale.|  
|[IDebugComPlusSymbolProvider::IsHiddenCode](../vs140/idebugcomplussymbolprovider--ishiddencode.md)|Determines if the code at the specified debugger address is hidden.|  
|[IDebugComPlusSymbolProvider::LoadSymbols](../vs140/idebugcomplussymbolprovider--loadsymbols.md)|Loads the specified debug symbols in memory.|  
|[IDebugComPlusSymbolProvider::LoadSymbolsFromStream](../vs140/idebugcomplussymbolprovider--loadsymbolsfromstream.md)|Loads debug symbols given the data stream.|  
|[IDebugComPlusSymbolProvider::ReplaceSymbols](../vs140/idebugcomplussymbolprovider--replacesymbols.md)|Replaces the current debug symbols with those in the specified data stream.|  
|[IDebugComPlusSymbolProvider::UnloadSymbols](../vs140/idebugcomplussymbolprovider--unloadsymbols.md)|Unloads the debug symbols for the specified module from memory.|  
|[IDebugComPlusSymbolProvider::UpdateSymbols](../vs140/idebugcomplussymbolprovider--updatesymbols.md)|Updates the debug symbols in memory with those the specified data stream.|  
  
## Requirements  
 Header: Sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll