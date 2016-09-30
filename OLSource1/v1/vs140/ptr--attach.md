---
title: "ptr::Attach"
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
  - "msclr::com::ptr::Attach"
  - "ptr::Attach"
  - "ptr.Attach"
  - "msclr.com.ptr.Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method"
ms.assetid: 81d930de-cb2a-4c30-9bd6-94d65942c47a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ptr::Attach
Attaches a COM object to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The COM interface pointer to attach.  
  
## Exceptions  
 If the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> already owns a reference to a COM object, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> throws \<xref:System.InvalidOperationException*>.  
  
## Remarks  
 A call to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> references the COM object but does not release the caller's reference to it.  
  
 Passing <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> results in no action being taken.  
  
## Example  
 This example implements a CLR class that uses a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to wrap its private member <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> member function first calls <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> on any previously owned object and then calls <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to attach a new document object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header file** \<msclr\com\ptr.h>  
  
 **Namespace** msclr::com  
  
## See Also  
 [ptr Members](../vs140/ptr-members.md)   
 [ptr::operator=](../vs140/ptr--operator=.md)   
 [ptr::Release](../vs140/ptr--release.md)