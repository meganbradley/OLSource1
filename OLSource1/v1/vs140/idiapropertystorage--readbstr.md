---
title: "IDiaPropertyStorage::ReadBSTR"
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
  - "IDiaPropertyStorage::ReadBSTR"
ms.assetid: 7214643b-3286-48ed-90aa-0fe95b4cae5b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaPropertyStorage::ReadBSTR
Reads <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> values in a property set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Identifier of the property to be read (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is defined in WTypes.h as a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Returns the property value.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise returns an error code. Returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the property is not of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 A <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is defined by Windows as a zero-terminated wide character string.  
  
## See Also  
 [IDiaPropertyStorage](../vs140/idiapropertystorage.md)