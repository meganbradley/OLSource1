---
title: "IDiaSession::findLines"
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
  - "IDiaSession::findLines method"
ms.assetid: d6e84916-fd55-457e-b057-57f97b51fe73
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::findLines
Retrieves line numbers within specified compiland and source file identifiers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in]An [IDiaSymbol](../vs140/idiasymbol.md) object representing the compiland. Use this interface as a context in which to search for the line numbers.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDiaSourceFile](../vs140/idiasourcefile.md) object representing the source file in which to search for the line numbers.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IDiaEnumLineNumbers](../vs140/idiaenumlinenumbers.md) object that contains a list of the line numbers retrieved.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumLineNumbers](../vs140/idiaenumlinenumbers.md)   
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaSourceFile](../vs140/idiasourcefile.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)