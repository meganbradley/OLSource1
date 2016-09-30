---
title: "PROCESS_INFO_FIELDS"
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
  - "PROCESS_INFO_FIELDS"
helpviewer_keywords: 
  - "PROCESS_INFO_FIELDS enumeration"
ms.assetid: 0d9cc345-3d3a-44d8-ae15-a67acb97a828
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# PROCESS_INFO_FIELDS
Specified what kind of information to retrieve for a process.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 PIF_FILE_NAME  
 Initialize/use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> field of the [PROCESS_INFO](../vs140/process_info.md) structure.  
  
 PIF_BASE_NAME  
 Initialize/use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure.  
  
 PIF_TITLE  
 Initialize/use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure.  
  
 PIF_PROCESS_ID  
 Initialize/use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure.  
  
 PIF_SESSION_ID  
 Initialize/use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> structure.  
  
 PIF_ATTACHED_SESSION_NAME  
 Initialize/use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> structure.  
  
 PIF_CREATION_TIME  
 Initialize/use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> structure.  
  
 PIF_FLAGS  
 Initialize/use the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> structure.  
  
 PIF_ALL  
 Fills out all fields.  
  
## Remarks  
 Passed to the [GetInfo](../vs140/idebugprocess2--getinfo.md) method to indicate which fields of the [PROCESS_INFO](../vs140/process_info.md) structure are to be initialized.  
  
 Also used in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> structure to indicate which fields are used and valid.  
  
 These flags may be combined with a bitwise <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [PROCESS_INFO](../vs140/process_info.md)