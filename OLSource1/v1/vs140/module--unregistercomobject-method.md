---
title: "Module::UnregisterCOMObject Method"
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
  - "module/Microsoft::WRL::Module::UnregisterCOMObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnregisterCOMObject method"
ms.assetid: 5d377525-0385-482a-a215-6e8a1f032861
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Module::UnregisterCOMObject Method
Unregisters one or more COM objects, which prevents other applications from connecting to them.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 (Unused)  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An array of pointers to values that identify the class objects to be unregistered. The array was created by the [RegisterCOMObject](../vs140/module--registercomobject-method.md) method.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of classes to unregister.  
  
## Return Value  
 S_OK if this operation is successful; otherwise, an error HRESULT that indicates the reason the operation failed.  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [Module Class](../vs140/module-class.md)