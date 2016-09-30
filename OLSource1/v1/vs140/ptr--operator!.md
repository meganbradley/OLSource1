---
title: "ptr::operator!"
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
  - "ptr::operator!"
  - "msclr::com::ptr::operator!"
  - "ptr.operator!"
  - "msclr.com.ptr.operator!"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ptr::operator!"
ms.assetid: 7f4101dc-2045-42e7-abb1-6a30e17147f2
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ptr::operator!
Operator to determine if the owned COM object is invalid.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the owned COM object is invalid; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 The owned COM object is valid if it is not <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
 This example implements a CLR class that uses a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to wrap its private member <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member function uses <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to determine if a document object is already owned, and only creates a new instance if the object is invalid.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **DOM Document created.**   
## Requirements  
 **Header file** \<msclr\com\ptr.h>  
  
 **Namespace** msclr::com  
  
## See Also  
 [ptr Members](../vs140/ptr-members.md)   
 [ptr::operator bool](../vs140/ptr--operator-bool.md)