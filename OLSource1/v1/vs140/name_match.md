---
title: "NAME_MATCH"
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
  - "NAME_MATCH"
helpviewer_keywords: 
  - "NAME_MATCH enumeration"
ms.assetid: 3842c417-a3c9-4259-a05f-52b64b829ef6
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# NAME_MATCH
Selects the case option for matching names.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 nmNone  
 No options are specified.  
  
 nmCaseSensitive  
 Indicates that names to be matched are case-sensitive.  
  
 nmCaseInsensitive  
 Indicates that names to be matched are not case-sensitive.  
  
## Remarks  
 Passed as an argument to the following methods:  
  
-   [IDebugSymbolProvider::GetTypeByName](../vs140/idebugsymbolprovider--gettypebyname.md)  
  
-   [IDebugSymbolProvider::GetClassTypeByName](../vs140/idebugsymbolprovider--getclasstypebyname.md)  
  
-   [IDebugContainerField::EnumFields](../vs140/idebugcontainerfield--enumfields.md)  
  
-   [IDebugSymbolProvider::GetMethodFieldsByName](../vs140/idebugsymbolprovider--getmethodfieldsbyname.md)  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [IDebugSymbolProvider::GetTypeByName](../vs140/idebugsymbolprovider--gettypebyname.md)   
 [IDebugSymbolProvider::GetClassTypeByName](../vs140/idebugsymbolprovider--getclasstypebyname.md)   
 [IDebugContainerField::EnumFields](../vs140/idebugcontainerfield--enumfields.md)   
 [IDebugSymbolProvider::GetMethodFieldsByName](../vs140/idebugsymbolprovider--getmethodfieldsbyname.md)