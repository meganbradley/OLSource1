---
title: "ptr::Detach"
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
  - "ptr.Detach"
  - "msclr.com.ptr.Detach"
  - "ptr::Detach"
  - "msclr::com::ptr::Detach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ptr::Detach"
ms.assetid: 23370c8a-8f79-4880-9fa1-46e110c1a92c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ptr::Detach
Gives up ownership of the COM object, returning a pointer to the object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The pointer to the COM object.  
  
 If no object is owned, NULL is returned.  
  
## Exceptions  
 Internally, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is called on the owned COM object and any error <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is converted to an exception by \<xref:System.Runtime.InteropServices.Marshal.ThrowExceptionForHR*>.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> first adds a reference to the COM object on behalf of the caller and then releases all references owned by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  The caller must ultimately release the returned object to destroy it.  
  
## Example  
 This example implements a CLR class that uses a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to wrap its private member <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member function calls <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to give up ownership of the COM object and return a pointer to the caller.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header file** \<msclr\com\ptr.h>  
  
 **Namespace** msclr::com  
  
## See Also  
 [ptr Members](../vs140/ptr-members.md)   
 [ptr::Release](../vs140/ptr--release.md)   
 [ptr::Attach](../vs140/ptr--attach.md)