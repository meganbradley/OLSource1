---
title: "ptr::~ptr"
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
  - "msclr.com.ptr.~ptr"
  - "ptr.~ptr"
  - "msclr::com.ptr::~ptr"
  - "~ptr"
  - "ptr::~ptr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ptr::~ptr"
ms.assetid: 5f644aa5-fe66-4992-a5f8-13ec1292c949
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ptr::~ptr
Destructs a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 On destruction, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> releases all references it owns to its COM object. Assuming that there are no other references held to the COM object, the COM object will be deleted and its memory freed.  
  
## Example  
 This example implements a CLR class that uses a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to wrap its private member <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  In the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function, the two <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> objects' destructors will be called when they go out of the scope of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> block, resulting in the underlying <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> destructor being called, releasing all owned references to the COM object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header file** \<msclr\com\ptr.h>  
  
 **Namespace** msclr::com  
  
## See Also  
 [ptr Members](../vs140/ptr-members.md)   
 [ptr::ptr](../vs140/ptr--ptr.md)   
 [ptr::CreateInstance](../vs140/ptr--createinstance.md)