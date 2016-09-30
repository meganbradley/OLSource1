---
title: "TerminateMap Function"
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
  - "module/Microsoft::WRL::Details::TerminateMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TerminateMap function"
ms.assetid: 1c314a61-da5d-49bb-ac44-c34ee3c23b66
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TerminateMap Function
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A [module](../vs140/module-class.md).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of a subset of class factories in the module specified by parameter <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to terminate the class factories regardless of they are active; <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to not terminate the class factories if any factory is active.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if all class factories were terminated; otherwise, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 Shuts down the class factories in the specified module.  
  
## Requirements  
 **Header:** module.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)