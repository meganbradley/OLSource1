---
title: "CComAutoThreadModule::CreateInstance"
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
  - "CComAutoThreadModule::CreateInstance"
  - "CComAutoThreadModule.CreateInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInstance method"
ms.assetid: 20c3a1ef-300e-4fcd-b189-c11c62265924
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAutoThreadModule::CreateInstance
As of ATL 7.0, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pfnCreateInstance*  
 [in] A pointer to a creator function.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The IID of the requested interface.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is set to NULL.  
  
## Return Value  
 A standard HRESULT value.  
  
## Remarks  
 Selects a thread and then creates an object in the associated apartment.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComAutoThreadModule Class](../vs140/ccomautothreadmodule-class.md)