---
title: "IDebugSymbolProvider::GetAddressesFromPosition"
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
  - "IDebugSymbolProvider::GetAddressesFromPosition"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetAddressesFromPosition method"
ms.assetid: 1b0f02cb-8ace-4614-88f3-0e10239012b3
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSymbolProvider::GetAddressesFromPosition
This method maps a document position into an array of debug addresses.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The document position.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] If TRUE, limits the debug addresses to a single statement.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns an enumerator for the starting debug addresses associated with this statement or line.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugAddresses](../vs140/ienumdebugaddresses.md) enumerator for the ending debug addresses associated with this statement or line.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 A document position typically indicates a range of source lines. This method provides the starting and ending debug addresses associated with these lines. Some languages allow statements that span multiple lines, or lines that contains more than one statement. This method provides a flag to limit the debug addresses to a single statement.  
  
 It is possible for a single statement to have multiple debug addresses, as in the case of templates.  
  
## See Also  
 [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md)   
 [GetAddressesFromContext](../vs140/idebugsymbolprovider--getaddressesfromcontext.md)   
 [IEnumDebugAddresses](../vs140/ienumdebugaddresses.md)