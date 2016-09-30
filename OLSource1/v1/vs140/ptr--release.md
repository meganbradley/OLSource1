---
title: "ptr::Release"
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
  - "ptr.Release"
  - "ptr::Release"
  - "msclr.com.ptr.Release"
  - "msclr::com::ptr::Release"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Release method"
ms.assetid: 7855781e-e4f6-4ad5-86a5-a81e2c3d90db
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ptr::Release
Releases all owned references on the COM object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Calling this function releases all owned references on the COM object and sets the internal handle to the COM object to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  If no other references on the COM object exist, it will be destroyed.  
  
## Example  
 This example implements a CLR class that uses a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to wrap its private member <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function uses <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to release any prior document object before attaching the new document.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header file** \<msclr\com\ptr.h>  
  
 **Namespace** msclr::com  
  
## See Also  
 [ptr Members](../vs140/ptr-members.md)   
 [ptr::Detach](../vs140/ptr--detach.md)