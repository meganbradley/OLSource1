---
title: "THREADPROPERTY_FIELDS"
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
  - "THREADPROPERTY_FIELDS"
helpviewer_keywords: 
  - "THREADPROPERTY_FIELDS enumeration"
ms.assetid: 5b88acb9-03ea-4c29-a788-f0087dccbe23
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# THREADPROPERTY_FIELDS
Specifies what information about a thread is to be retrieved.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 TPF_ID  
 Initialize/use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> field of the [THREADPROPERTIES](../vs140/threadproperties.md) structure.  
  
 TPF_SUSPENDCOUNT  
 Initialize/use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>S structure.  
  
 TPF_STATE  
 Initialize/use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>S structure.  
  
 TPF_PRIORITY  
 Initialize/use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>S structure.  
  
 TPF_NAME  
 Initialize/use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>S structure.  
  
 TPF_LOCATION  
 Initialize/use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>S structure.  
  
 TPF_ALLFIELDS  
 Specifies all fields.  
  
## Remarks  
 These values are passed as an argument to the [GetThreadProperties](../vs140/idebugthread2--getthreadproperties.md) method to indicate which fields of the [THREADPROPERTIES](../vs140/threadproperties.md) structure are to be initialized.  
  
 These values are also used in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> structure to indicate which fields are used and valid.  
  
 These flags may be combined with a bitwise <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [THREADPROPERTIES](../vs140/threadproperties.md)   
 [GetThreadProperties](../vs140/idebugthread2--getthreadproperties.md)