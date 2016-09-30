---
title: "IDebugSymbolProvider"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugSymbolProvider"
helpviewer_keywords: 
  - "IDebugSymbolProvider interface"
ms.assetid: df5f095f-1dee-46f9-84cf-92417c71d5fb
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSymbolProvider
This interface represents a symbol provider that provides symbols and types, returning them as fields.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Notes for Implementers  
 A symbol provider must implement this interface to supply symbol and type information to an expression evaluator.  
  
## Notes for Callers  
 This interface is obtained by using COM's <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function (for unmanaged symbol providers) or by loading the appropriate managed code assembly and instantiating the symbol provider based on the information found in that assembly. The debug engine instantiates the symbol provider to work in coordination with the expression evaluator. See the Example for one approach to instantiating this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Deprecated. Do not use.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Deprecated. Do not use.|  
|[GetContainerField](../vs140/idebugsymbolprovider--getcontainerfield.md)|Gets the field that contains the debug address.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Deprecated. Do not use.|  
|[GetAddressesFromPosition](../vs140/idebugsymbolprovider--getaddressesfromposition.md)|Maps a document position into an array of debug addresses.|  
|[GetAddressesFromContext](../vs140/idebugsymbolprovider--getaddressesfromcontext.md)|Maps a document context into an array of debug addresses.|  
|[GetContextFromAddress](../vs140/idebugsymbolprovider--getcontextfromaddress.md)|Maps a debug address into a document context.|  
|[GetLanguage](../vs140/idebugsymbolprovider--getlanguage.md)|Gets the language used to compile the code at the debug address.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Deprecated. Do not use.|  
|[GetMethodFieldsByName](../vs140/idebugsymbolprovider--getmethodfieldsbyname.md)|Gets the field representing a fully qualified method name.|  
|[GetClassTypeByName](../vs140/idebugsymbolprovider--getclasstypebyname.md)|Gets the class field type representing a fully qualified class name.|  
|[GetNamespacesUsedAtAddress](../vs140/idebugsymbolprovider--getnamespacesusedataddress.md)|Creates an enumerator for namespaces associated with the debug address.|  
|[GetTypeByName](../vs140/idebugsymbolprovider--gettypebyname.md)|Maps a symbol name to a symbol type.|  
|[GetNextAddress](../vs140/idebugsymbolprovider--getnextaddress.md)|Gets the debug address that follows a given debug address in a method.|  
  
## Remarks  
 This interface maps document positions into debug addresses and vice versa.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## Example  
 This example shows how to instantiate the symbol provider, given its GUID (a debug engine must know this value).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Symbol Provider Interfaces](../vs140/symbol-provider-interfaces.md)