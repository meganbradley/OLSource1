---
title: "IDiaEnumInjectedSources::Item"
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
  - "IDiaEnumInjectedSources::Item method"
ms.assetid: 14846955-7270-451d-91d2-9cb34bb65187
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumInjectedSources::Item
Retrieves an injected source by means of an index.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 index  
 [in] Index of the [IDiaInjectedSource](../vs140/idiainjectedsource.md) object to be retrieved. The index is the range 0 to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>-1, where <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is returned by the [IDiaEnumInjectedSources::get_Count](../vs140/idiaenuminjectedsources--get_count.md) method.  
  
 injectedSource  
 [out] Returns an [IDiaInjectedSource](../vs140/idiainjectedsource.md) object representing the injected source.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumInjectedSources](../vs140/idiaenuminjectedsources.md)   
 [IDiaInjectedSource](../vs140/idiainjectedsource.md)