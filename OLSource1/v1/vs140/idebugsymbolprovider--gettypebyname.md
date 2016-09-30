---
title: "IDebugSymbolProvider::GetTypeByName"
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
  - "IDebugSymbolProvider::GetTypeByName"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetTypeByName method"
ms.assetid: b9d88d3b-8b75-484a-b9cc-dc8c0fbb4bc8
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSymbolProvider::GetTypeByName
This method maps a symbol name to a symbol type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The symbol name.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Selects the type of match, for example, case-sensitive. A value from the [NAME_MATCH](../vs140/name_match.md) enumeration.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns the symbol type as an [IDebugField](../vs140/idebugfield.md) object.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This method is a generic version of [IDebugSymbolProvider::GetClassTypeByName](../vs140/idebugsymbolprovider--getclasstypebyname.md).  
  
## See Also  
 [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md)   
 [IDebugField](../vs140/idebugfield.md)   
 [NAME_MATCH](../vs140/name_match.md)   
 [IDebugSymbolProvider::GetClassTypeByName](../vs140/idebugsymbolprovider--getclasstypebyname.md)