---
title: "ptr::operator-&gt;"
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
  - "msclr.com.ptr.operator->"
  - "ptr.operator->"
  - "ptr::operator->"
  - "msclr::com::ptr::operator->"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ptr::operator->"
ms.assetid: e752b549-74ed-430d-9a60-6c8e0e441998
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ptr::operator-&gt;
Member access operator, used to call methods on the owned COM object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to the COM object.  
  
## Exceptions  
 Internally, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is called on the owned COM object and any error <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is converted to an exception by \<xref:System.Runtime.InteropServices.Marshal.ThrowExceptionForHR*>.  
  
## Remarks  
 This operator allows you to call methods of the owned COM object. It returns a temporary <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that automatically handles its own <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Example  
 This example implements a CLR class that uses a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to wrap its private member <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> functions uses <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to call the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> member of the document object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **\<word>persnickety\</word>**   
## Requirements  
 **Header file** \<msclr\com\ptr.h>  
  
 **Namespace** msclr::com  
  
## See Also  
 [ptr Members](../vs140/ptr-members.md)