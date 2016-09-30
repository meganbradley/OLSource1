---
title: "ActivatableClass Macros"
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
  - "ActivatableClass"
  - "ActivatableClassWithFactory"
  - "ActivatableClassWithFactoryEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ActivatableClassWithFactory"
  - "ActivatableClass"
  - "ActivatableClassWithFactoryEx"
ms.assetid: 9bd64709-ec2c-4678-8c96-ea5982622bdd
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ActivatableClass Macros
Populates an internal cache that contains a factory that can create an instance of the specified class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Name of the class to create.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Factory that will create an instance of the specified class.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A name that specifies a subset of factories in the module.  
  
## Remarks  
 Do not use these macros with classic COM unless you use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> directive to ensure that the **__WRL_WINRT_STRICT\_\_** macro definition is removed.  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [Module Class](../vs140/module-class.md)