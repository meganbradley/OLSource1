---
title: "CComSafeArray::CopyFrom"
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
  - "CopyFrom"
  - "CComSafeArray::CopyFrom"
  - "CComSafeArray.CopyFrom"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CopyFrom method"
ms.assetid: 3546cfaa-3fa0-4494-a4c9-6acbb2ac5c5f
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArray::CopyFrom
Copies the contents of a **SAFEARRAY** structure into the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the **SAFEARRAY** to copy.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method copies the contents of a **SAFEARRAY** into the current <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. The existing contents of the array are replaced.  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArray Class](../vs140/ccomsafearray-class.md)   
 [CComSafeArray::CopyTo](../vs140/ccomsafearray--copyto.md)