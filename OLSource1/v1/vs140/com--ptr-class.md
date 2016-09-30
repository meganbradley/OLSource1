---
title: "com::ptr Class"
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
  - "com::ptr"
  - "msclr::com::ptr"
  - "msclr.com.ptr"
  - "com.ptr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ptr class"
ms.assetid: 0144d0e4-919c-45f9-a3f8-fbc9edba32bf
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# com::ptr Class
A wrapper for a COM object that can be used as a member of a CLR class.  The wrapper also automates lifetime management of the COM object, releasing all owned references on the object when its destructor is called. Analogous to [CComPtr](../vs140/ccomptr-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 COM interface.  
  
## Remarks  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> can also be used as a local function variable to simplify various COM tasks and to automate lifetime management.  
  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> cannot be used directly as a function parameter; use a [tracking reference (%)](../vs140/tracking-reference-operator--c---component-extensions-.md) or a [handle (^)](../vs140/handle-to-object-operator--^----c---component-extensions-.md) instead.  
  
 A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> cannot be directly returned from a function; use a handle instead.  
  
## Example  
 This example implements a CLR class that uses a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to wrap its private member <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  Calling the public methods of the class results in calls to the contained <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  The sample creates an instance of an XML document, fills it with some simple XML, and does a simplified walk of the nodes in the parsed document tree to print the XML to the console.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **\<word>persnickety\</word>**   
## Requirements  
 **Header file** \<msclr\com\ptr.h>  
  
 **Namespace** msclr::com  
  
## See Also  
 [C++ Support Library](../vs140/c---support-library.md)   
 [ptr Members](../vs140/ptr-members.md)