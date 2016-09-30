---
title: "AtlModuleUnregisterServerEx"
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
  - "AtlModuleUnregisterServerEx"
  - "ATL::AtlModuleUnregisterServerEx"
  - "ATL.AtlModuleUnregisterServerEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlModuleUnregisterServerEx function"
ms.assetid: 15c611ba-9fbe-4b1f-b041-9676911ad4ab
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlModuleUnregisterServerEx
Unregisters every object in the object map.  
  
 **Note** This function is obsolete in Visual C++ .NET 2002 and later but is available for backward compatibility with projects created with previous versions of Visual C++.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class or derived class.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 TRUE if the type library is to be registered.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Points to the CLSID of the object to be unregistered. If NULL, all objects in the object map will be unregistered.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This function walks the ATL object map and unregisters each object in the map. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not NULL, then only the object referred to by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is unregistered; otherwise all of the objects are unregistered.  
  
 This function is obsolete. Instead, use its replacement, [AtlComModuleUnregisterServer](../vs140/atlcommoduleunregisterserver.md).  
  
 This helper function is used by [CComModule::UnregisterServer](../vs140/ccommodule--unregisterserver.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Server Registration Global Functions](../vs140/server-registration-global-functions.md)   
 [CComModule::UnregisterServer](../vs140/ccommodule--unregisterserver.md)   
 [AtlComModuleUnregisterServer](../vs140/atlcommoduleunregisterserver.md)