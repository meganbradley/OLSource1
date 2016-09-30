---
title: "IDiaSectionContrib::get_compiland"
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
  - "IDiaSectionContrib::get_compiland method"
ms.assetid: c0496f6f-f8f2-435f-8674-6c32db6c5934
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSectionContrib::get_compiland
Retrieves a reference to the compiland symbol that contributed this section.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] Returns an [IDiaSymbol](../vs140/idiasymbol.md) object representing the compiland that contributed this section.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaSectionContrib](../vs140/idiasectioncontrib.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)