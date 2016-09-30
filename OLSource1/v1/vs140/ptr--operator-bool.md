---
title: "ptr::operator bool"
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
  - "ptr::operator bool"
  - "ptr.operator bool"
  - "operator bool"
  - "msclr::com::ptr::operator bool"
  - "msclr.com.ptr.operator bool"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ptr::operator bool"
ms.assetid: 31123377-6ecd-4cef-9b75-3db3996fbcd1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ptr::operator bool
Operator for using <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in a conditional expression.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the owned COM object is valid; <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 The owned COM object is valid if it is not <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 This operator actually converts to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> which is safer than <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> because it cannot be converted to an integral type.  
  
## Example  
 This example implements a CLR class that uses a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to wrap its private member <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member function uses <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> after creating the new document object to determine if it is valid and writes to the console if it is.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **DOM Document created.**   
## Requirements  
 **Header file** \<msclr\com\ptr.h>  
  
 **Namespace** msclr::com  
  
## See Also  
 [ptr Members](../vs140/ptr-members.md)   
 [ptr::operator!](../vs140/ptr--operator!.md)