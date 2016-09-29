---
title: "AtlLoadTypeLib"
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
  - "ATL::AtlLoadTypeLib"
  - "AtlLoadTypeLib"
  - "ATL.AtlLoadTypeLib"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlLoadTypeLib function"
ms.assetid: ac46602d-63fd-4464-b1ce-92ddd3250d71
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlLoadTypeLib
This function is called to load a type library.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      ATLINLINE ATLAPI AtlLoadTypeLib(  
HINSTANCE hInstTypeLib,  
LPCOLESTR lpszIndex,  
BSTR* pbstrPath,  
ITypeLib** ppTypeLib   
);  
```  
  
#### Parameters  
 `hInstTypeLib`  
 Handle to the module associated with the type library.  
  
 `lpszIndex`  
 String in the format "\\\N", where N is the integer index of the type library resource. Can be NULL if no index is required.  
  
 *pbstrPath*  
 On successful return, contains the full path of the module associated with the type library.  
  
 `ppTypeLib`  
 On successful return, contains a pointer to a pointer to the loaded type library.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This helper function is utilized by [AtlRegisterTypeLib](../vs140/atlregistertypelib.md) and [AtlUnRegisterTypeLib](../vs140/atlunregistertypelib.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Server Registration Global Functions](../vs140/server-registration-global-functions.md)   
 [AtlUnRegisterTypeLib](../vs140/atlunregistertypelib.md)   
 [AtlRegisterTypeLib](../vs140/atlregistertypelib.md)