---
title: "ptr::GetInterface"
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
  - "ptr::GetInterface"
  - "msclr::com::ptr::GetInterface"
  - "GetInterface"
  - "msclr.com.ptr.GetInterface"
  - "ptr.GetInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetInterface method"
ms.assetid: d85553ec-fb88-4fd6-9df2-ddcaa8b2dc70
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ptr::GetInterface
Returns a pointer to the owned COM object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the owned COM object.  
  
## Exceptions  
 Internally, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is called on the owned COM object and any error <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is converted to an exception by \<xref:System.Runtime.InteropServices.Marshal.ThrowExceptionForHR*>.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> adds a reference to the COM object on the caller's behalf and also keeps its own reference on the COM object. The caller must ultimately release the reference on the returned object or it will never be destroyed.  
  
## Example  
 This example implements a CLR class that uses a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to wrap its private member <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member function uses <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to return a pointer to the COM object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **\<word>persnickety\</word>**   
## Requirements  
 **Header file** \<msclr\com\ptr.h>  
  
 **Namespace** msclr::com  
  
## See Also  
 [ptr Members](../vs140/ptr-members.md)   
 [ptr::QueryInterface](../vs140/ptr--queryinterface.md)