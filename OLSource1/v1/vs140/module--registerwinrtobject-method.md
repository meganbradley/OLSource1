---
title: "Module::RegisterWinRTObject Method"
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
  - "module/Microsoft::WRL::Module::RegisterWinRTObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RegisterWinRTObject method"
ms.assetid: a2782c9c-b9c5-4e4b-9c8d-ef513aea20c5
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Module::RegisterWinRTObject Method
Registers one or more [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] objects so other applications can connect to them.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A name that specifies a subset of objects affected by this operation.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An array of activatable CLSIDs to register.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A value that identifies the class objects that were registered. This value is used later to revoke the registration.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The number of objects to register.  
  
## Return Value  
 S_OK if successful; otherwise, an error HRESULT such as CO_E_OBJISREG that indicates the reason the operation failed.  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [Module Class](../vs140/module-class.md)