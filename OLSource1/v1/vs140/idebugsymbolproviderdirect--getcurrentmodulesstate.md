---
title: "IDebugSymbolProviderDirect::GetCurrentModulesState"
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
  - "GetCurrentModulesState"
  - "IDebugSymbolProviderDirect::GetCurrentModulesState"
ms.assetid: a0c85318-5686-4eed-b213-21f2b9e681e6
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSymbolProviderDirect::GetCurrentModulesState
Retrieves information about the symbol group of which the symbol provider is a member.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] The state of the symbol provider group.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Number of modules in the group.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The state is changed whenever a module is added to, or removed from, the symbol group. Therefore, this method can be used to detect if a symbol group has been modified.  
  
## See Also  
 [IDebugSymbolProviderDirect](../vs140/idebugsymbolproviderdirect.md)