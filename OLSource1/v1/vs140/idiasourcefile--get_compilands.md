---
title: "IDiaSourceFile::get_compilands"
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
  - "IDiaSourceFile::get_compilands method"
ms.assetid: 57deb50a-9c22-43ea-a80c-eab205997bc4
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSourceFile::get_compilands
Retrieves an enumerator of compilands that have line numbers referencing this file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns an [IDiaEnumSymbols](../vs140/idiaenumsymbols.md) object that contains a list of all compilands that have line numbers referencing this file.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDiaSourceFile](../vs140/idiasourcefile.md)   
 [IDiaEnumSymbols](../vs140/idiaenumsymbols.md)