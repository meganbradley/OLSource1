---
title: "IDiaEnumSourceFiles::Clone"
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
  - "IDiaEnumSourceFiles::Clone method"
ms.assetid: 87a9a9b6-3927-4131-927c-ad95f8f098b9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumSourceFiles::Clone
Creates an enumerator that contains the same enumeration state as the current enumerator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 ppenum  
 [out] Returns an [IDiaEnumSourceFiles](../vs140/idiaenumsourcefiles.md) object that contains a duplicate of the enumerator. The source files are not duplicated, only the enumerator.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumSourceFiles](../vs140/idiaenumsourcefiles.md)