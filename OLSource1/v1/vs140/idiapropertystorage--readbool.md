---
title: "IDiaPropertyStorage::ReadBOOL"
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
  - "IDiaPropertyStorage::ReadBOOL"
ms.assetid: ad1822db-4572-48f7-9919-f8137f6701f2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaPropertyStorage::ReadBOOL
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
 For consistent results, interpret the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> value so that nonzero values are <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and zero is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## See Also  
 [IDiaPropertyStorage](../vs140/idiapropertystorage.md)