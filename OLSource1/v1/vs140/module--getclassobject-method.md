---
title: "Module::GetClassObject Method"
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
  - "module/Microsoft::WRL::Module::GetClassObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetClassObject method"
ms.assetid: 95b0de1b-f728-4f96-9f44-f6ea71ce56e4
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Module::GetClassObject Method
Retreives a cache of class factories.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Class ID.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Interface ID that you request.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to returned object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The server name that is specified in either the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> macro; or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to get the default server name.  
  
## Return Value  
  
## Remarks  
 Use this method only for COM, not the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. This method exposes only IClassFactory methods.  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [Module Class](../vs140/module-class.md)