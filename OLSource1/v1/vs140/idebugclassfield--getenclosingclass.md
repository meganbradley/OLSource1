---
title: "IDebugClassField::GetEnclosingClass"
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
  - "IDebugClassField::GetEnclosingClass"
helpviewer_keywords: 
  - "IDebugClassField::GetEnclosingClass method"
ms.assetid: a0c12e3c-9ea0-4dfb-9e45-8cea18725022
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugClassField::GetEnclosingClass
Gets the class that encloses this class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugClassField](../vs140/idebugclassfield.md) object representing the enclosing class. Returns a null value if there is no enclosing class.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 If the class represented by this [IDebugClassField](../vs140/idebugclassfield.md) object is a nested class, then the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter returns an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object representing the enclosing class. For example, given this class definition:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Calling the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method on the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object representing the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class returns an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object representing the class <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## See Also  
 [IDebugClassField](../vs140/idebugclassfield.md)