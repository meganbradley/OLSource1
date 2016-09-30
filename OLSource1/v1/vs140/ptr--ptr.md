---
title: "ptr::ptr"
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
  - "ptr::ptr"
  - "ptr.ptr"
  - "msclr.com.ptr.ptr"
  - "msclr::com::ptr::ptr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ptr::ptr"
ms.assetid: 4f5883b4-7c0a-46c6-aa9f-4e49eed463eb
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ptr::ptr
Constructs a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to wrap a COM object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A COM interface pointer.  
  
## Remarks  
 The no-argument constructor assigns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to the underlying object handle. Subsequent calls to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> will validate the internal object and silently fail until an object is actually created or attached.  
  
 The one-argument constructor adds a reference to the COM object but does not release the caller's reference, so the caller must call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> on the COM object to truly give up control. When the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>'s destructor is called it will automatically release its references on the COM object.  
  
 Passing <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to this constructor is the same as calling the no-argument version.  
  
## Example  
 This example implements a CLR class that uses a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to wrap its private member <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object. It demonstrates usage of both versions of the constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header file** \<msclr\com\ptr.h>  
  
 **Namespace** msclr::com  
  
## See Also  
 [ptr Members](../vs140/ptr-members.md)   
 [ptr::CreateInstance](../vs140/ptr--createinstance.md)   
 [ptr::~ptr](../vs140/ptr--~ptr.md)