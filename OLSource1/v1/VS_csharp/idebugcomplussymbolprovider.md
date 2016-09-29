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
ms.author: "gregvanl"
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
 In addition to the methods on the [IDebugSymbolProvider](../VS_csharp/idebugsymbolprovider.md) interface, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugComPlusSymbolProvider::AreSymbolsLoaded](../VS_csharp/idebugcomplussymbolprovider--aresymbolsloaded.md)|Determines if the debug symbols are loaded for the specified module given the application domain identifier.|  
|[IDebugComPlusSymbolProvider::CreateTypeFromPrimitive](../VS_csharp/idebugcomplussymbolprovider--createtypefromprimitive.md)|Creates a type from the specified primitive type.|  
|[IDebugComPlusSymbolProvider::GetAddressesInModuleFromPosition](../VS_csharp/idebugcomplussymbolprovider--getaddressesinmodulefromposition.md)|Maps a document position in the specified module to an array of debug addresses.|  
|[IDebugComPlusSymbolProvider::GetArrayTypeFromAddress](../VS_csharp/idebugcomplussymbolprovider--getarraytypefromaddress.md)|Retrieves type information about the specified array given its debug address.|  
|[IDebugComPlusSymbolProvider::GetAssemblyName](../VS_csharp/idebugcomplussymbolprovider--getassemblyname.md)|Retrieves the name of the assembly given its module and application domain.|  
|[IDebugComPlusSymbolProvider::GetAttributedClassesForLanguage](../VS_csharp/idebugcomplussymbolprovider--getattributedclassesforlanguage.md)|Retrieves the classes with the specified attribute that are implemented in the given programming language.|  
|[IDebugComPlusSymbolProvider::GetAttributedClassesinModule](../VS_csharp/idebugcomplussymbolprovider--getattributedclassesinmodule.md)|Retrieves the classes with the specified attribute in a given module.|  
|[IDebugComPlusSymbolProvider::GetEntryPoint](../VS_csharp/idebugcomplussymbolprovider--getentrypoint.md)|Retrieves the application entry point.|  
|[IDebugComPlusSymbolProvider::GetFunctionLineOffset](../VS_csharp/idebugcomplussymbolprovider--getfunctionlineoffset.md)|Retrieves the address within a function that represents the given line offset.|  
|[IDebugComPlusSymbolProvider::GetLocalVariablelayout](../VS_csharp/idebugcomplussymbolprovider--getlocalvariablelayout.md)|Retrieves the layout of local variables for a set of methods.|  
|[IDebugComPlusSymbolProvider::GetNameFromToken](../VS_csharp/idebugcomplussymbolprovider--getnamefromtoken.md)|Returns the name associated with the specified token given its metadata object.|  
|[IDebugComPlusSymbolProvider::GetSymAttribute](../VS_csharp/idebugcomplussymbolprovider--getsymattribute.md)|Retrieves the debug symbols with the given parent attribute for the specified module.|  
|[IDebugComPlusSymbolProvider::GetSymUnmanagedReader](../VS_csharp/idebugcomplussymbolprovider--getsymunmanagedreader.md)|Retrieves the symbol reader to be used by unmanaged code.|  
|[IDebugComPlusSymbolProvider::GetTypeFromAddress](../VS_csharp/idebugcomplussymbolprovider--gettypefromaddress.md)|Retrieves to a symbol type given its debug address.|  
|[IDebugComPlusSymbolProvider::IsFunctionDeleted](../VS_csharp/idebugcomplussymbolprovider--isfunctiondeleted.md)|Determines if the function at the specified debug address is deleted.|  
|[IDebugComPlusSymbolProvider::IsFunctionStale](../VS_csharp/idebugcomplussymbolprovider--isfunctionstale.md)|Determines if the function at the specified debug address is considered stale.|  
|[IDebugComPlusSymbolProvider::IsHiddenCode](../VS_csharp/idebugcomplussymbolprovider--ishiddencode.md)|Determines if the code at the specified debugger address is hidden.|  
|[IDebugComPlusSymbolProvider::LoadSymbols](../VS_csharp/idebugcomplussymbolprovider--loadsymbols.md)|Loads the specified debug symbols in memory.|  
|[IDebugComPlusSymbolProvider::LoadSymbolsFromStream](../VS_csharp/idebugcomplussymbolprovider--loadsymbolsfromstream.md)|Loads debug symbols given the data stream.|  
|[IDebugComPlusSymbolProvider::ReplaceSymbols](../VS_csharp/idebugcomplussymbolprovider--replacesymbols.md)|Replaces the current debug symbols with those in the specified data stream.|  
|[IDebugComPlusSymbolProvider::UnloadSymbols](../VS_csharp/idebugcomplussymbolprovider--unloadsymbols.md)|Unloads the debug symbols for the specified module from memory.|  
|[IDebugComPlusSymbolProvider::UpdateSymbols](../VS_csharp/idebugcomplussymbolprovider--updatesymbols.md)|Updates the debug symbols in memory with those the specified data stream.|  
  
## Requirements  
 Header: Sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll