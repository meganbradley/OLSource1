---
title: "IDiaSession::getSymbolsByAddr"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSession::getSymbolsByAddr method"
ms.assetid: eafcc757-b488-487d-a063-ad3703ff42e8
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::getSymbolsByAddr
Retrieves an enumerator that finds symbols in the order of their addresses.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns an [IDiaEnumSymbolsByAddr](../vs140/idiaenumsymbolsbyaddr.md) object. Use this interface to search for symbols in the symbol store by memory location.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaEnumSymbolsByAddr](../vs140/idiaenumsymbolsbyaddr.md)