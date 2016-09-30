---
title: "RuntimeClassBaseT::GetImplementedIIDS Method"
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
  - "implements/Microsoft::WRL::Details::RuntimeClassBaseT::GetImplementedIIDS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetImplementedIIDS method"
ms.assetid: adae54da-521d-4add-87f5-242fbd85f33b
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RuntimeClassBaseT::GetImplementedIIDS Method
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the type specified by parameter <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The maximum number of interface IDs to retrieve.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 If this operation completes successfully, an array of the interface IDs implemented by type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 S_OK if successful; otherwise, an HRESULT that describes the error.  
  
## Remarks  
 Retrieves an array of interface IDs that are implemented by a specified type.  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [RuntimeClassBaseT Structure](../vs140/runtimeclassbaset-structure.md)