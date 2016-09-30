---
title: "MODULE_INFO_FIELDS"
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
  - "MODULE_INFO_FIELDS"
helpviewer_keywords: 
  - "MODULE_INFO_FIELDS enumeration"
ms.assetid: 8bed85f4-235f-4192-b58f-5fad7a4d7a78
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# MODULE_INFO_FIELDS
Specifies the flags for the debug module information.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 MIF_NONE  
 Initialize/use none of the fields in the structure.  
  
 MIF_NAME  
 Initialize/use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> field in the [MODULE_INFO](../vs140/module_info.md) structure.  
  
 MIF_URL  
 Initialize/use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> field in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure.  
  
 MIF_VERSION  
 Initialize/use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> field in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure.  
  
 MIF_DEBUGMESSAGE  
 Initialize/use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure.  
  
 MIF_LOADADDRESS  
 Initialize/use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> field in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> structure.  
  
 MIF_PREFFEREDADDRESS  
 Initialize/use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> field in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> structure.  
  
 MIF_SIZE  
 Initialize/use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> field in the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> structure.  
  
 MIF_LOADORDER  
 Initialize/use the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> field in the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> structure.  
  
 MIF_TIMESTAMP  
 Initialize/use the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> field in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> structure.  
  
 MIF_URLSYMBOLLOCATION  
 Initialize/use the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> field in the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> structure.  
  
 MIF_FLAGS  
 Initialize/use the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> field in the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> structure.  
  
 MIF_ALLFIELDS  
 Initialize/use all of the fields in the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> structure.  
  
## Remarks  
 These values are passed as an argument to the [GetInfo](../vs140/idebugmodule2--getinfo.md) method to indicate which fields of the [MODULE_INFO](../vs140/module_info.md) structure are to be initialized.  
  
 These values are also used in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> structure to indicate which fields are used and valid.  
  
 These flags may be combined with a bitwise <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [MODULE_INFO](../vs140/module_info.md)   
 [GetInfo](../vs140/idebugmodule2--getinfo.md)