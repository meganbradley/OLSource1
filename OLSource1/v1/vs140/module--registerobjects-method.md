---
title: "Module::RegisterObjects Method"
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
  - "module/Microsoft::WRL::Module::RegisterObjects"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RegisterObjects method"
ms.assetid: db4077b7-068d-4534-aaa5-41b5444ccb49
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Module::RegisterObjects Method
Registers COM or [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] objects so other applications can connect to them.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An array of COM or [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] objects.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Name of the server that created the objects.  
  
## Return Value  
 S_OK if successful; otherwise, an HRESULT that indicates the reason the operation failed.  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [Module Class](../vs140/module-class.md)