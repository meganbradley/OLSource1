---
title: "DECLARE_REGISTRY_APPID_RESOURCEID"
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
  - "DECLARE_REGISTRY_APPID_RESOURCEID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_REGISTRY_APPID_RESOURCEID macro"
ms.assetid: 84701e63-bfa1-4604-b1d0-103d65e8d014
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_REGISTRY_APPID_RESOURCEID
Specifies the information required to automatically register the *appid*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *resid*  
 The resource id of the .rgs file that contains information about the *appid*.  
  
 *appid*  
 A GUID.  
  
## Remarks  
 Use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-derived class.  
  
## Example  
 Classes added to ATL projects with the Add Class code wizard will have a sample of using this macro.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Registry Macros](../vs140/registry-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [CAtlModuleT Class](../vs140/catlmodulet-class.md)