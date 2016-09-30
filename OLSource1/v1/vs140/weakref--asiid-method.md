---
title: "WeakRef::AsIID Method"
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
  - "client/Microsoft::WRL::WeakRef::AsIID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AsIID method"
ms.assetid: 94e87309-32da-4dbb-8233-e77313a1f448
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WeakRef::AsIID Method
Sets the specified ComPtr pointer parameter to represent the specified interface ID.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An interface ID.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 When this operation completes, an object that represents parameter <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
  
-   S_OK if this operation succeeds; otherwise, an HRESULT that indicates the reason the operation failed, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
-   S_OK if this operation succeeds, but the current WeakRef object has already been released. Parameter <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
-   S_OK if this operation succeeds, but the current WeakRef object is not derived from parameter <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Parameter <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. (For more information, see Remarks.)  
  
## Remarks  
 An error is emitted if parameter <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is not derived from IInspectable. This error supersedes the return value.  
  
 The first template is the form that you should use in your code. The second template (not shown here, but declared in the header file) is an internal, helper specialization that supports C++ language features such as the [auto](../vs140/auto--c---.md) type deduction keyword.  
  
 Starting in the Windows 10 SDK, this method does not set the WeakRef instance to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if the weak reference could not be obtained, so you should avoid error-checking code that checks the WeakRef for <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Instead, check <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [WeakRef Class](../vs140/weakref-class.md)