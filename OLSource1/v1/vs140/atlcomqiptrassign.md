---
title: "AtlComQIPtrAssign"
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
  - "ATL.AtlComQIPtrAssign"
  - "ATL::AtlComQIPtrAssign"
  - "AtlComQIPtrAssign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlComQIPtrAssign function"
ms.assetid: eab94dad-65e1-47c8-8ba8-edce86b2760f
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlComQIPtrAssign
Assigns an interface pointer to another interface pointer of a different type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Address of an **IUnknown** pointer to which to assign another pointer.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An **IUnknown** pointer of a type different from the one in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. This is assigned to the pointer in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The IID of the requested interface.  
  
## Return Value  
 Returns NULL on error; otherwise returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function copies an interface pointer using COM reference counting rules. It calls <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> on <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, specifying <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to obtain the required interface. It calls **Release** on the interface pointed to by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and then assigns the pointer returned by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 This smart pointer helper function is used by [CComPtr Class](../vs140/ccomptr-class.md) and [CComQIPtr Class](../vs140/ccomqiptr-class.md).  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComPtr Class](../vs140/ccomptr-class.md)   
 [CComQIPtr Class](../vs140/ccomqiptr-class.md)