---
title: "IDiaPropertyStorage::ReadPropertyNames"
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
  - "IDiaPropertyStorage::ReadPropertyNames"
ms.assetid: f8bcab77-afca-4a8f-8710-697842f8a518
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaPropertyStorage::ReadPropertyNames
Retrieves corresponding string names for given property identifiers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Number of property ids in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Array of property ids for which to get the names (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is defined in WTypes.h as a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in, out] Array of property names for the specified property ids. The array must be pre-allocated to hold the requested number of property names and must be able to hold at least <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> strings.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; otherwise returns an error code.  
  
## Remarks  
 The returned property names must be freed (by calling the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function) when they are no longer needed.  
  
## See Also  
 [IDiaPropertyStorage](../vs140/idiapropertystorage.md)