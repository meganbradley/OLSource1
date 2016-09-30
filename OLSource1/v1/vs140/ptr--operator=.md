---
title: "ptr::operator="
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
  - "ptr.operator="
  - "msclr.com.ptr.operator="
  - "msclr::com::ptr::operator="
  - "ptr::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator="
ms.assetid: 58619910-46c0-4db8-b183-c811b23b2df1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ptr::operator=
Attaches a COM object to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The COM interface pointer to attach.  
  
## Return Value  
 A tracking reference on the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Exceptions  
 If the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> already owns a reference to a COM object, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> throws \<xref:System.InvalidOperationException*>.  
  
## Remarks  
 Assigning a COM object to a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> references the COM object but does not release the caller's reference to it.  
  
 This operator has the same effect as <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
 This example implements a CLR class that uses a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to wrap its private member <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> member function first calls <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> on any previously owned object and then uses <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to attach a new document object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header file** \<msclr\com\ptr.h>  
  
 **Namespace** msclr::com  
  
## See Also  
 [ptr Members](../vs140/ptr-members.md)   
 [ptr::Attach](../vs140/ptr--attach.md)   
 [ptr::Detach](../vs140/ptr--detach.md)   
 [ptr::Release](../vs140/ptr--release.md)