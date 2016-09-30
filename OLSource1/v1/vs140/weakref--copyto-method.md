---
title: "WeakRef::CopyTo Method"
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
  - "client/Microsoft::WRL::WeakRef::CopyTo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CopyTo method"
ms.assetid: f83de6da-b3d4-41a6-9845-cd725ecf3b75
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WeakRef::CopyTo Method
Assigns a pointer to an interface, if available, to the specified pointer variable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer an IInspectable interface. An error is emitted if <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is not derived from IInspectable.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An interface ID. An error is emitted if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is not derived from **IWeakReference**.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A doubly-indirect pointer to IInspectable or IWeakReference.  
  
## Return Value  
 S_OK if successful; otherwise, an HRESULT that describes the failure. For more information, see Remarks.  
  
## Remarks  
 A return value of S_OK means that this operation succeeded, but doesn't indicate whether the weak reference was resolved to a strong reference. If S_OK is returned, test that parameter <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a strong reference; that is, parameter <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> isn't equal to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 Starting in the Windows 10 SDK, this method does not set the WeakRef instance to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the weak reference could not be obtained, so you should avoid error checking code that checks the WeakRef for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Instead, check <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [WeakRef Class](../vs140/weakref-class.md)