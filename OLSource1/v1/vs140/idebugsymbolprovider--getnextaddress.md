---
title: "IDebugSymbolProvider::GetNextAddress"
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
  - "IDebugSymbolProvider::GetNextAddress"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetNextAddress method"
ms.assetid: 704eeb94-cb13-49d1-82b6-7d83ed0f19c0
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSymbolProvider::GetNextAddress
Gets the debug address that follows a given debug address in a method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Given debug address.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] If TRUE, limits the debug addresses to a single statement.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns the next debug address.  
  
## Return Value  
 Returns a valid <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, typically S_OK.  
  
## See Also  
 [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md)