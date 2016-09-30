---
title: "ComPtr::CopyTo Method"
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
  - "client/Microsoft::WRL::ComPtr::CopyTo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CopyTo method"
ms.assetid: 8801bc49-6db4-4393-a55f-a701ae3b8718
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ComPtr::CopyTo Method
Copies the current or specified interface associated with this ComPtr to the specified pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A type name.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 When this operation completes, a pointer to the requested interface.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An interface ID.  
  
## Return Value  
 S_OK if successful; otherwise, an HRESULT that indicates why the implicit QueryInterface operation failed.  
  
## Remarks  
 The first function returns a copy of a pointer to the interface associated with this ComPtr. This function always returns S_OK.  
  
 The second function performs a QueryInterface operation on the interface associated with this ComPtr for the interface specified by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.  
  
 The third function performs a QueryInterface operation on the interface associated with this ComPtr for the underlying interface of the  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [ComPtr Class](../vs140/comptr-class.md)