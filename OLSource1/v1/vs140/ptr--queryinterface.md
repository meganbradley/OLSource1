---
title: "ptr::QueryInterface"
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
  - "ptr.QueryInterface"
  - "ptr::QueryInterface"
  - "msclr::com::ptr::QueryInterface"
  - "msclr.com.ptr.QueryInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryInterface method"
ms.assetid: c2619517-3fde-493b-b12d-da8f62d5d803
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ptr::QueryInterface
Queries the owned COM object for an interface and attaches the result to another <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that will get the interface.  
  
## Exceptions  
 Internally, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is called on the owned COM object and any error <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is converted to an exception by \<xref:System.Runtime.InteropServices.Marshal.ThrowExceptionForHR*>.  
  
## Remarks  
 Use this method to create a COM wrapper for a different interface of the COM object owned by the current wrapper. This method calls <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> through the owned COM object to request a pointer to a specific interface of the COM object and attaches the returned interface pointer to the passed-in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
 This example implements a CLR class that uses a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to wrap its private member <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> member function uses <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to fill a local <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> with an <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and then passes the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> (by tracking reference) to a private member function that writes the node's name and text properties to the console.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **\<#document>persnickety\</#document>**   
## Requirements  
 **Header file** \<msclr\com\ptr.h>  
  
 **Namespace** msclr::com  
  
## See Also  
 [ptr Members](../vs140/ptr-members.md)   
 [ptr::GetInterface](../vs140/ptr--getinterface.md)