---
title: "CComSafeArray::CopyTo"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CComSafeArray.CopyTo"
  - "CComSafeArray::CopyTo"
  - "ATL.CComSafeArray.CopyTo"
  - "ATL::CComSafeArray::CopyTo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CopyTo method"
ms.assetid: e256e290-c00c-4f80-ba5a-8d1d5ce50a39
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArray::CopyTo
Creates a copy of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a location in which to create the new **SAFEARRAY**.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method copies the contents of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object into a **SAFEARRAY** structure.  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArray Class](../vs140/ccomsafearray-class.md)   
 [CComSafeArray::CopyFrom](../vs140/ccomsafearray--copyfrom.md)