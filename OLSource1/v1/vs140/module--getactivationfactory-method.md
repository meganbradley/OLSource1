---
title: "Module::GetActivationFactory Method"
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
  - "module/Microsoft::WRL::Module::GetActivationFactory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetActivationFactory method"
ms.assetid: 59da8844-072e-414b-b89c-1db1cc4fd81d
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Module::GetActivationFactory Method
Gets an activation factory for the module.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 IID of a runtime class.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The IActivationFactory for the specified runtime class.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The name of a subset of class factories in the current module. Specify the server name used in the [ActivatableClassWithFactoryEx](../vs140/activatableclass-macros.md) macro, or specify <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to get the default server name.  
  
## Return Value  
 S_OK if successful; otherwise, the HRESULT returned by GetActivationFactory.  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [Module Class](../vs140/module-class.md)   
 [ActivatableClass Macros](../vs140/activatableclass-macros.md)