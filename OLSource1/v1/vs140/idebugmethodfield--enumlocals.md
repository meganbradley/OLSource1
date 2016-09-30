---
title: "IDebugMethodField::EnumLocals"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugMethodField::EnumLocals"
helpviewer_keywords: 
  - "IDebugMethodField::EnumLocals method"
ms.assetid: b0456a6d-2b96-49e2-a871-516571b4f6a5
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugMethodField::EnumLocals
Creates an enumerator for selected local variables of the method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] An [IDebugAddress](../vs140/idebugaddress.md) object representing the debug address that selects the context or scope from which to get the locals.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugFields](../vs140/ienumdebugfields.md) object representing a list of the locals; otherwise, returns a null value if there are no locals.  
  
## Return Value  
 If successful, returns S_OK or returns S_FALSE if there are no locals. Otherwise, returns an error code.  
  
## Remarks  
 Only the variables defined within the block that contains the given debug address are enumerated. If all locals including any compiler-generated locals are needed, call the [IDebugMethodField::EnumAllLocals](../vs140/idebugmethodfield--enumalllocals.md) method.  
  
 A method can contain multiple scoping contexts or blocks. For example, the following contrived method contains three scopes, the two inner blocks and the method body itself.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The [IDebugMethodField](../vs140/idebugmethodfield.md) object represents the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method itself. Calling the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method with an [IDebugAddress](../vs140/idebugaddress.md) set to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> address returns an enumeration containing the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> variable, for example.  
  
## See Also  
 [IDebugMethodField](../vs140/idebugmethodfield.md)   
 [IDebugAddress](../vs140/idebugaddress.md)   
 [IEnumDebugFields](../vs140/ienumdebugfields.md)   
 [IDebugMethodField::EnumAllLocals](../vs140/idebugmethodfield--enumalllocals.md)