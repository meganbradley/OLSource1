---
title: "Module::RegisterCOMObject Method"
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
  - "module/Microsoft::WRL::Module::RegisterCOMObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RegisterCOMObject method"
ms.assetid: 59f223dc-03c6-429d-95da-b74b3f73b702
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Module::RegisterCOMObject Method
Registers one or more COM objects so other applications can connect to them.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Fully-qualified name of a server.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An array of CLSIDs to register.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An array of IUnknown interfaces of the class objects whose availability is being published.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 When the operation completes, an array of pointers to values that identify the class objects that were registered. These values are later used revoke the registration.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The number of CLSIDs to register.  
  
## Return Value  
 S_OK if successfu; otherwise, an HRESULT such as CO_E_OBJISREG that indicates the reason the operation failed.  
  
## Remarks  
 The COM objects are registered with the CLSCTX_LOCAL_SERVER enumerator of the CLSCTX enumeration.  
  
 The type of connection to the registered objects is specified by a combination of the current <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> template parameter and the REGCLS_SUSPENDED enumerator of the REGCLS enumeration.  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [Module Class](../vs140/module-class.md)