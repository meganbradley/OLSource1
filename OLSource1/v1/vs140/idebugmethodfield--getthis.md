---
title: "IDebugMethodField::GetThis"
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
  - "IDebugMethodField::GetThis"
helpviewer_keywords: 
  - "IDebugMethodField::GetThis method"
ms.assetid: cc235bea-e909-4d8c-ab54-936736c803fc
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugMethodField::GetThis
Gets the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]) pointer of the object containing the method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugClassField](../vs140/idebugclassfield.md) object representing the "this" pointer.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 In object-oriented languages, there is typically an implied pointer to the current instantiation of a class. This is known as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in C#/C++ and as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
## See Also  
 [IDebugMethodField](../vs140/idebugmethodfield.md)   
 [IDebugClassField](../vs140/idebugclassfield.md)