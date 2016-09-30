---
title: "IDebugPortPicker::DisplayPortPicker"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "DisplayPortPicker"
  - "IDebugPortPicker::DisplayPortPicker"
ms.assetid: 08511ef5-be64-4069-b169-a569cc94bc64
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPortPicker::DisplayPortPicker
Displays the specified dialog box that allows the user to select a port.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Handle for the parent dialog box.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Port identifier string.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code. A return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (or a return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) indicates that the user  clicked **Cancel**.  
  
## See Also  
 [IDebugPortPicker](../vs140/idebugportpicker.md)