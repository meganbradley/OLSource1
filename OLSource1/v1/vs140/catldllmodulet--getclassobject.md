---
title: "CAtlDllModuleT::GetClassObject"
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
  - "ATL::CAtlDllModuleT<T>::GetClassObject"
  - "CAtlDllModuleT.GetClassObject"
  - "ATL::CAtlDllModuleT::GetClassObject"
  - "ATL.CAtlDllModuleT.GetClassObject"
  - "CAtlDllModuleT::GetClassObject"
  - "GetClassObject"
  - "CAtlDllModuleT<T>::GetClassObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetClassObject method"
ms.assetid: 10bc1a59-911f-4f29-bfb8-3d4c8052fa80
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlDllModuleT::GetClassObject
Creates an object of the specified CLSID.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The CLSID of the object to be created.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The IID of the requested interface.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the interface pointer identified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is set to NULL.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method is called by [CAtlDllModuleT::DllGetClassObject](../vs140/catldllmodulet--dllgetclassobject.md) and is included for backward compatibility.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlDllModuleT Class](../vs140/catldllmodulet-class.md)