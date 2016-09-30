---
title: "IDebugSymbolProviderDirect::GetCurrentModulesInfo"
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
  - "IDebugSymbolProviderDirect::GetCurrentModulesInfo"
  - "GetCurrentModulesInfo"
ms.assetid: b3b45ed2-ea4e-4389-b78a-11fc9796a6c1
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSymbolProviderDirect::GetCurrentModulesInfo
Retrieves information about the modules in the symbol group.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Number of modules in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> array.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Array that contains the unique identifiers for the modules.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Identifiers for the application domains.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] Current state of the symbol group.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] Returns an object that contains the modules in the symbol group.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugSymbolProviderDirect](../vs140/idebugsymbolproviderdirect.md)