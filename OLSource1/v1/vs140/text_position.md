---
title: "TEXT_POSITION"
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
  - "TEXT_POSITION"
helpviewer_keywords: 
  - "TEXT_POSITION structure"
ms.assetid: 6dcec574-a852-49fa-8c2e-2e71cbb5e3c6
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# TEXT_POSITION
Describes the line and column location in the given text.  
  
## Syntax  
  
```cpp#  
typedef struct _tagTEXT_POSITION {   
   DWORD dwLine;  
   DWORD dwColumn;  
} TEXT_POSITION;  
```  
  
```c#  
public struct TEXT_POSITION {   
   public uint dwLine;  
   public uint dwColumn;  
};  
```  
  
## Members  
 dwLine  
 Index of line in source file.  
  
 dwColumn  
 Character offset into line.  
  
## Remarks  
 This structure is used in the [CONTEXT_INFO](../vs140/context_info.md) and [DisassemblyData](../vs140/disassemblydata.md) structures.  
  
 This structure is filled in by a call to the following methods:  
  
-   [IDebugDocumentContext2::GetStatementRange](../vs140/idebugdocumentcontext2--getstatementrange.md)  
  
-   [IDebugDocumentContext2::GetSourceRange](../vs140/idebugdocumentcontext2--getsourcerange.md)  
  
-   [IDebugDocumentPosition2::GetRange](../vs140/idebugdocumentposition2--getrange.md)  
  
-   [IDebugFunctionPosition2::GetOffset](../vs140/idebugfunctionposition2--getoffset.md)  
  
 This structure is passed as a parameter to the following methods:  
  
-   [IDebugDocumentText2::GetText](../vs140/idebugdocumenttext2--gettext.md)  
  
-   [IDebugDocumentTextEvents2::OnInsertText](../vs140/idebugdocumenttextevents2--oninserttext.md)  
  
-   [IDebugDocumentTextEvents2::OnRemoveText](../vs140/idebugdocumenttextevents2--onremovetext.md)  
  
-   [IDebugDocumentTextEvents2::OnReplaceText](../vs140/idebugdocumenttextevents2--onreplacetext.md)  
  
-   [IDebugDocumentTextEvents2::OnUpdateTextAttributes](../vs140/idebugdocumenttextevents2--onupdatetextattributes.md)  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [IDebugDocumentContext2::GetStatementRange](../vs140/idebugdocumentcontext2--getstatementrange.md)   
 [IDebugDocumentContext2::GetSourceRange](../vs140/idebugdocumentcontext2--getsourcerange.md)   
 [GetRange](../vs140/idebugdocumentposition2--getrange.md)   
 [GetOffset](../vs140/idebugfunctionposition2--getoffset.md)   
 [GetText](../vs140/idebugdocumenttext2--gettext.md)   
 [IDebugDocumentTextEvents2](../vs140/idebugdocumenttextevents2.md)   
 [CONTEXT_INFO](../vs140/context_info.md)   
 [DisassemblyData](../vs140/disassemblydata.md)