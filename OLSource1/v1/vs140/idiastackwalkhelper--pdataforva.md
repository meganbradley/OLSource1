---
title: "IDiaStackWalkHelper::pdataForVA"
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
  - "IDiaStackWalkHelper2::pdataByVA method"
ms.assetid: fafc38fe-74dc-4726-9a51-eebf3a673d7f
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackWalkHelper::pdataForVA
Returns the PDATA data block associated with the virtual address.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Specifies the virtual address of the data to obtain.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The size of data in bytes to obtain.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the actual size of data in bytes that was obtained.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in, out] A buffer that is filled in with the requested data. Cannot be <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if there is no PDATA for the specified address. Otherwise, returns an error code.  
  
## Remarks  
 The PDATA (the section named ".pdata") of a compiland contains information about exception handling for functions.  
  
 The caller knows how much data is to be returned so the caller has no need to ask for how much data is available. Therefore, it is acceptable for an implementation of this method to return an error if the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## See Also  
 [IDiaStackWalkHelper](../vs140/idiastackwalkhelper.md)